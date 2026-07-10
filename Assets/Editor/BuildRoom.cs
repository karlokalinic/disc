// BuildRoom — the waking-up room as Disco renders it: a 2.5D scene where the REAL painted room
// image (WhirlingF2.png) is the backdrop and the REAL 3D Harry (tequila) body mesh stands in front.
// Fixed orthographic/isometric camera. All content is the game's own extracted assets.
// Run: Unity -batchmode -executeMethod BuildRoom.Build
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditor.SceneManagement;

public static class BuildRoom
{
    const float BackW = 13f;   // backdrop world size (square 512x512 painting)

    static Material Lit(Color c){ var s=Shader.Find("Standard")??Shader.Find("Legacy Shaders/Diffuse"); var m=new Material(s); if(m.HasProperty("_Color"))m.color=c; if(m.HasProperty("_Glossiness"))m.SetFloat("_Glossiness",0.05f); return m; }
    static Material Unlit(Texture t){ var s=Shader.Find("Unlit/Texture")??Shader.Find("Sprites/Default"); var m=new Material(s); m.mainTexture=t; return m; }

    public static void Build()
    {
        var log=new System.Text.StringBuilder(); void L(string s){ log.AppendLine(s); Debug.Log("[ROOM] "+s); }
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // 1) backdrop = the real painted room
        var tex = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Texture2D/WhirlingF2.png");
        var back = GameObject.CreatePrimitive(PrimitiveType.Quad); back.name="Backdrop";
        Object.DestroyImmediate(back.GetComponent<Collider>());
        back.transform.position = new Vector3(0,0,0);
        back.transform.localScale = new Vector3(BackW, BackW, 1);
        if (tex != null) { back.GetComponent<Renderer>().sharedMaterial = Unlit(tex); L("backdrop WhirlingF2.png "+tex.width+"x"+tex.height); }
        else { back.GetComponent<Renderer>().sharedMaterial = Lit(new Color(0.3f,0.28f,0.25f)); L("WhirlingF2.png NOT FOUND"); }

        // 2) Harry — real rigged TequilaSunset prefab, not the raw body mesh.
        var teqPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/TequillaSunset.prefab");
        GameObject harry = teqPrefab != null ? (GameObject)PrefabUtility.InstantiatePrefab(teqPrefab) : new GameObject("Harry");
        harry.name = "Harry";
        harry.transform.position = new Vector3(-0.5f, -2.2f, -1.2f);
        harry.transform.localScale = Vector3.one * 1.2f;
        harry.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        // Start after waking with pants and shoes missing. They appear when picked up.
        foreach (var smr in harry.GetComponentsInChildren<SkinnedMeshRenderer>(true))
        {
            string n = smr.name.ToLowerInvariant();
            if (n.Contains("tequila_pants") || n.Contains("shoes")) smr.gameObject.SetActive(false);
        }
        InstallRecoveredMovementAnimator(harry, L);
        L("Harry prefab="+(teqPrefab?teqPrefab.name:"fallback")+" renderers="+harry.GetComponentsInChildren<SkinnedMeshRenderer>(true).Length);

        // 3) trousers (real mesh) on the floor -> carries the keys
        var pantsMesh = AssetDatabase.LoadAssetAtPath<Mesh>("Assets/Mesh/tequila_pants.asset");
        var pants = new GameObject("PantsItem");
        if (pantsMesh != null)
        {
            pants.AddComponent<MeshFilter>().sharedMesh = pantsMesh;
            var pantsRenderer = pants.AddComponent<MeshRenderer>();
            pantsRenderer.sharedMaterial = Lit(new Color(0.30f,0.26f,0.22f));
            // The exported standalone pants mesh is not posed for pickup display and renders like a
            // grey prop stand over the painting. Keep this as an interaction anchor only.
            pantsRenderer.enabled = false;
            float s = 1.2f / Mathf.Max(0.01f, pantsMesh.bounds.size.y);
            pants.transform.localScale = Vector3.one * s;
            pants.transform.position = new Vector3(2.6f, -4.2f, -1.2f);
        }
        else pants.transform.position = new Vector3(2.6f,-4.2f,-1.2f);

        // 3b) real tie and thrown shoe props (source meshes/materials), placed over the painting.
        AddMeshProp("CeilingTie", "Assets/Mesh/tequila_tie.asset", "Assets/Material/tequila_tie.mat", new Vector3(1.0f, 3.6f, -1.1f), new Vector3(0,0,30), 0.9f, L);
        AddMeshProp("ThrownShoe", "Assets/Mesh/shoes_snakeskin.asset", "Assets/Material/tequila_shoes.mat", new Vector3(-3.35f, -3.06f, -1.12f), new Vector3(0,0,-28), 2.05f, L);

        // 3c) source-named interaction anchors from the Whirling F2 prefab object list. Do not render
        // the extracted click meshes here: they are raw mask/collider meshes and visually cover the
        // painting with grey/white slabs. The painted room is the source-accurate full-room visual;
        // these anchors preserve object identity for interaction logic.
        AddRoomAnchor("Room_Bath", new Vector3(-0.1f, 3.15f, -1.05f), L);
        AddRoomAnchor("Room_BathroomMirror", new Vector3(5.05f, 5.00f, -1.05f), L);
        AddRoomAnchor("Room_BrokenWindow", new Vector3(-3.85f, -3.18f, -1.05f), L);
        AddRoomAnchor("Room_TapePlayer", new Vector3(3.15f, -1.85f, -1.08f), L);
        AddRoomAnchor("Room_Tape", new Vector3(2.3f, -1.2f, -1.08f), L);
        AddRoomAnchor("Room_Shelves", new Vector3(3.3f, 0.7f, -1.08f), L);
        AddRoomAnchor("Room_BedMess", new Vector3(-4.0f, -3.35f, -1.08f), L);
        AddRoomAnchor("Room_MedicalSupplies", new Vector3(4.25f, -2.25f, -1.08f), L);
        AddMeshPropFit("Room_WhiskeyBottle", "Assets/Mesh/int-bottle-whiskey-2.asset", "Assets/Material/int-bottle-whiskey-mat.mat", new Vector3(1.5f, -3.85f, -1.08f), new Vector3(0,0,-25), 0.55f, L);
        AddRoomAnchor("Room_FanBody", new Vector3(0.75f, 4.25f, -1.08f), L);
        AddRoomAnchor("Room_FanBlades", new Vector3(0.75f, 4.25f, -1.09f), L);

        // 4) locked door over the painting's doorway (centre-left)
        var door = GameObject.CreatePrimitive(PrimitiveType.Cube); door.name="RoomDoor";
        door.transform.position = new Vector3(-2.2f, -0.4f, -0.8f);
        door.transform.localScale = new Vector3(1.6f, 3.2f, 0.15f);
        // Invisible interaction blocker over the painted doorway. The actual door is in the painting.
        door.GetComponent<Renderer>().enabled = false;

        // 5) controller + light
        var roomController = new GameObject("RoomController").AddComponent<RoomController>();
        roomController.database = AssetDatabase.LoadAssetAtPath<PixelCrushers.DialogueSystem.DialogueDatabase>("Assets/Dialogue Databases/Disco Elysium.asset");
        var lg = new GameObject("KeyLight").AddComponent<Light>();
        lg.type=LightType.Directional; lg.intensity=0.9f; lg.color=new Color(1f,0.94f,0.85f); lg.transform.rotation=Quaternion.Euler(35,10,0);

        string outPath = "Assets/_IntroReal/RoomReal.unity";
        EditorSceneManager.SaveScene(scene, outPath);
        L("saved "+outPath);

        var list = new List<EditorBuildSettingsScene>{
            new EditorBuildSettingsScene("Assets/_IntroReal/BootBlank.unity", true),
            new EditorBuildSettingsScene("Assets/_IntroReal/FlowReal.unity", false),
            new EditorBuildSettingsScene("Assets/_IntroReal/IntroReal.unity", true),
            new EditorBuildSettingsScene(outPath, true),
            new EditorBuildSettingsScene("Assets/Scenes/PreInitialize.unity", false),
            new EditorBuildSettingsScene("Assets/Scenes/Initialize.unity", false),
            new EditorBuildSettingsScene("Assets/Scenes/Init.unity", false),
            new EditorBuildSettingsScene("Assets/Scenes/Lobby.unity", false)
        };
        if (File.Exists(Path.Combine(Application.dataPath, "3DShowcase.unity")))
            list.Add(new EditorBuildSettingsScene("Assets/3DShowcase.unity", true));
        EditorBuildSettings.scenes = list.ToArray();

        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName,"room_result.txt"), log.ToString());
        Debug.Log("[ROOM] DONE");
    }

    static void AddMeshProp(string name, string meshPath, string matPath, Vector3 pos, Vector3 euler, float scale, System.Action<string> log)
    {
        var mesh = AssetDatabase.LoadAssetAtPath<Mesh>(meshPath);
        if (mesh == null) { log(name+" mesh missing: "+meshPath); return; }
        var go = new GameObject(name);
        go.AddComponent<MeshFilter>().sharedMesh = mesh;
        var mr = go.AddComponent<MeshRenderer>();
        var mat = AssetDatabase.LoadAssetAtPath<Material>(matPath);
        mr.sharedMaterial = mat != null ? mat : Lit(Color.white);
        go.transform.position = pos;
        go.transform.rotation = Quaternion.Euler(euler);
        go.transform.localScale = Vector3.one * scale;
    }

    static void AddMeshPropFit(string name, string meshPath, string matPath, Vector3 pos, Vector3 euler, float targetHeight, System.Action<string> log)
    {
        var mesh = AssetDatabase.LoadAssetAtPath<Mesh>(meshPath);
        if (mesh == null) { log(name+" mesh missing: "+meshPath); return; }
        float size = Mathf.Max(0.01f, mesh.bounds.size.y);
        float scale = Mathf.Clamp(targetHeight / size, 0.02f, 20f);
        AddMeshProp(name, meshPath, matPath, pos, euler, scale, log);
    }

    static void AddRoomAnchor(string name, Vector3 pos, System.Action<string> log)
    {
        var go = new GameObject(name);
        go.transform.position = pos;
        log("anchor " + name + " at " + pos);
    }

    static void InstallRecoveredMovementAnimator(GameObject harry, System.Action<string> log)
    {
        foreach (var cloth in harry.GetComponentsInChildren<Cloth>(true)) cloth.enabled = false;
        var anim = harry.GetComponent<Animator>() ?? harry.AddComponent<Animator>();
        anim.avatar = null;
        anim.applyRootMotion = false;
        anim.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        anim.updateMode = AnimatorUpdateMode.Normal;

        var controller = BuildRecoveredMovementController(log);
        if (controller == null)
        {
            anim.runtimeAnimatorController = null;
            anim.enabled = false;
            log("Harry Animator disabled: recovered Tequila movement clips are missing.");
            return;
        }

        anim.runtimeAnimatorController = controller;
        anim.enabled = true;
        log("Harry Animator enabled with recovered Tequila idle/walk/jog blend controller.");
    }

    static RuntimeAnimatorController BuildRecoveredMovementController(System.Action<string> log)
    {
        const string controllerPath = "Assets/_IntroReal/RecoveredTequilaMovement.controller";
        var getUp = AssetDatabase.LoadAssetAtPath<AnimationClip>("Assets/AnimationClip/Get up from bed.anim");
        var idle = AssetDatabase.LoadAssetAtPath<AnimationClip>("Assets/AnimationClip/tequila_idles_offCenterIdle.anim");
        var walk = AssetDatabase.LoadAssetAtPath<AnimationClip>("Assets/AnimationClip/Hangover Walk.anim");
        var jog = AssetDatabase.LoadAssetAtPath<AnimationClip>("Assets/AnimationClip/jog_2.anim");
        if (getUp == null || idle == null || walk == null || jog == null)
        {
            log("movement clips missing getUp=" + (getUp != null) + " idle=" + (idle != null) + " walk=" + (walk != null) + " jog=" + (jog != null));
            return null;
        }

        var existing = AssetDatabase.LoadAssetAtPath<AnimatorController>(controllerPath);
        if (existing != null) AssetDatabase.DeleteAsset(controllerPath);

        var controller = AnimatorController.CreateAnimatorControllerAtPath(controllerPath);
        controller.AddParameter("Forward", AnimatorControllerParameterType.Float);

        var stateMachine = controller.layers[0].stateMachine;
        var getUpState = stateMachine.AddState("Get Up From Bed");
        getUpState.motion = getUp;
        getUpState.writeDefaultValues = false;
        getUpState.iKOnFeet = false;

        var state = stateMachine.AddState("Player Movement");
        state.writeDefaultValues = false;
        state.iKOnFeet = false;

        var tree = new BlendTree
        {
            name = "Recovered Tequila Forward",
            blendType = BlendTreeType.Simple1D,
            blendParameter = "Forward",
            useAutomaticThresholds = false,
            minThreshold = 0f,
            maxThreshold = 2f
        };
        AssetDatabase.AddObjectToAsset(tree, controller);
        tree.AddChild(idle, 0f);
        tree.AddChild(walk, 1f);
        tree.AddChild(jog, 2f);

        state.motion = tree;
        stateMachine.defaultState = getUpState;
        var transition = getUpState.AddTransition(state);
        transition.hasExitTime = true;
        transition.exitTime = 0.98f;
        transition.duration = 0.15f;
        transition.hasFixedDuration = true;
        AssetDatabase.SaveAssets();
        AssetDatabase.ImportAsset(controllerPath);
        log("movement controller saved " + controllerPath);
        return controller;
    }

    public static void ValidateVisual()
    {
        EditorSceneManager.OpenScene("Assets/_IntroReal/RoomReal.unity", OpenSceneMode.Single);
        var cam = Object.FindAnyObjectByType<Camera>();
        if (cam == null)
        {
            var camGO = new GameObject("RoomValidationCamera");
            cam = camGO.AddComponent<Camera>();
            cam.orthographic = true;
            cam.orthographicSize = 6.6f;
            cam.transform.position = new Vector3(0, 0, -18);
            cam.transform.rotation = Quaternion.identity;
        }
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.black;
        cam.orthographic = true;
        cam.orthographicSize = 6.6f;
        cam.transform.position = new Vector3(0, 0, -18);
        cam.transform.rotation = Quaternion.identity;

        int w = 1280, h = 720;
        var rt = new RenderTexture(w, h, 24);
        cam.targetTexture = rt;
        cam.Render();
        RenderTexture.active = rt;
        var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
        tex.Apply();
        cam.targetTexture = null;
        RenderTexture.active = null;

        var pixels = tex.GetPixels();
        float lum = 0f, mag = 0f, bright = 0f;
        foreach (var c in pixels)
        {
            float l = (c.r + c.g + c.b) / 3f;
            lum += l;
            if (c.r > 0.6f && c.b > 0.6f && c.g < 0.3f) mag++;
            if (l > 0.82f) bright++;
        }
        lum /= pixels.Length;
        mag /= pixels.Length;
        bright /= pixels.Length;

        string root = Directory.GetParent(Application.dataPath).FullName;
        File.WriteAllBytes(Path.Combine(root, "room_visual_validation.png"), tex.EncodeToPNG());
        File.WriteAllText(Path.Combine(root, "room_visual_validation.txt"),
            "avgLum=" + lum.ToString("0.000") + "\nmagentaFrac=" + mag.ToString("0.0000") + "\nbrightFrac=" + bright.ToString("0.0000") + "\nRoom_ renderer count=" + CountRoomRenderers());
        Object.DestroyImmediate(rt);
        Object.DestroyImmediate(tex);
    }

    static int CountRoomRenderers()
    {
        int count = 0;
        foreach (var r in Object.FindObjectsByType<Renderer>(FindObjectsInactive.Include, FindObjectsSortMode.None))
            if (r != null && r.name.StartsWith("Room_") && r.enabled) count++;
        return count;
    }
}
