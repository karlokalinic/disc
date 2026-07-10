using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class BuildKlaasjeBalcony
{
    const float BackW = 13f;

    static Material Lit(Color c)
    {
        var s = Shader.Find("Standard") ?? Shader.Find("Legacy Shaders/Diffuse");
        var m = new Material(s); if (m.HasProperty("_Color")) m.color = c; return m;
    }

    public static void Build()
    {
        var log = new System.Text.StringBuilder();
        void L(string s){ log.AppendLine(s); Debug.Log("[KLAASJE] "+s); }
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // Clean source-asset hallway/balcony composition. Raw roof prefabs are lightfield fragments,
        // so use source textures on simple planes and keep the actors/props readable.
        AddTexturedQuad("WhirlingLeftWindowArt", "Assets/Texture2D/additive-lightmap-whirling-left.png", new Vector3(-2.55f, 0.10f, 0f), new Vector3(7.0f, 7.0f, 1f), 0f, L);
        AddTexturedQuad("WhirlingRightWindowArt", "Assets/Texture2D/additive-lightmap-whirling-right.png", new Vector3(3.0f, 0.35f, -0.02f), new Vector3(7.2f, 7.2f, 1f), 0f, L);
        AddTexturedQuad("BalconyFloor", "Assets/Texture2D/int-doors-whirling-zigzag-TEX.png", new Vector3(0f, -3.05f, -0.05f), new Vector3(12.8f, 2.05f, 1f), 0f, L);
        AddTexturedQuad("HallwayDoorBackdrop", "Assets/Texture2D/int-doors-whirling-zigzag-TEX2.png", new Vector3(-4.25f, -1.15f, -0.04f), new Vector3(1.45f, 2.1f, 1f), 0f, L);

        AddAnchor("BalconyRailAnchor", new Vector3(-4.2f, -3.0f, -1.05f), L);
        AddAnchor("KlaasjeWindow", new Vector3(3.8f, -0.9f, -1.05f), L);
        AddAnchor("HallwayDoor", new Vector3(-3.85f, 0.75f, -1.05f), L);

        var harryPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/TequillaSunset.prefab");
        var harry = harryPrefab != null ? (GameObject)PrefabUtility.InstantiatePrefab(harryPrefab) : GameObject.CreatePrimitive(PrimitiveType.Capsule);
        harry.name = "Harry";
        harry.transform.position = new Vector3(-4.1f, -2.72f, -1.2f);
        harry.transform.localScale = Vector3.one * 1.15f;
        harry.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        DisableUnsafe(harry);
        BrightenRenderers(harry, 1.18f);

        var klaasjePrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/klaasjeRoof Prefab.prefab");
        if (klaasjePrefab == null) klaasjePrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/Klaasje.prefab");
        var klaasje = klaasjePrefab != null ? (GameObject)PrefabUtility.InstantiatePrefab(klaasjePrefab) : GameObject.CreatePrimitive(PrimitiveType.Capsule);
        klaasje.name = "Klaasje";
        klaasje.transform.position = new Vector3(3.1f, -2.35f, -1.2f);
        klaasje.transform.localScale = Vector3.one * 1.05f;
        klaasje.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        DisableUnsafe(klaasje);
        BrightenRenderers(klaasje, 1.22f);

        AddMesh("KlaasjeCigarette", "Assets/Mesh/cigarette.asset", "Assets/Material/cigarette_mat.mat", klaasje.transform.position + new Vector3(0.34f, 1.40f, -0.08f), new Vector3(0,0,18), 1.25f, L);
        var smoke = GameObject.CreatePrimitive(PrimitiveType.Sphere); smoke.name = "KlaasjeSmoke";
        Object.DestroyImmediate(smoke.GetComponent<Collider>());
        smoke.transform.localScale = new Vector3(0.12f,0.12f,0.12f);
        smoke.GetComponent<Renderer>().sharedMaterial = Lit(new Color(0.85f,0.88f,0.84f,0.45f));

        AddMesh("OtherShoe", "Assets/Mesh/shoes_snakeskin.asset", "Assets/Material/tequila_shoes.mat", new Vector3(-5.0f, -3.25f, -1.15f), new Vector3(0,0,-30), 2.05f, L);

        var ctrl = new GameObject("KlaasjeSceneController").AddComponent<KlaasjeSceneController>();
        ctrl.database = AssetDatabase.LoadAssetAtPath<PixelCrushers.DialogueSystem.DialogueDatabase>("Assets/Dialogue Databases/Disco Elysium.asset");
        ctrl.harry = harry.transform;
        ctrl.klaasje = klaasje.transform;
        var shoe = GameObject.Find("OtherShoe"); if (shoe != null) ctrl.shoe = shoe.transform;

        var light = new GameObject("BalconyKeyLight").AddComponent<Light>();
        light.type = LightType.Directional; light.intensity = 0.95f; light.color = new Color(1f,0.94f,0.84f); light.transform.rotation = Quaternion.Euler(45f, -20f, 0f);

        string outPath = "Assets/_IntroReal/KlaasjeBalconyReal.unity";
        EditorSceneManager.SaveScene(scene, outPath);
        L("saved " + outPath);

        var list = new List<EditorBuildSettingsScene>();
        foreach (var s in EditorBuildSettings.scenes) if (s.path != outPath) list.Add(s);
        list.Add(new EditorBuildSettingsScene(outPath, true));
        EditorBuildSettings.scenes = list.ToArray();

        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "klaasje_scene_result.txt"), log.ToString());
    }

    static void AddPrefab(string name, Vector3 offset, System.Action<string> log)
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/" + name);
        if (prefab == null) { log("missing prefab " + name); return; }
        var go = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        go.name = Path.GetFileNameWithoutExtension(name);
        go.transform.position += offset;
        DisableUnsafe(go);
        log("prefab " + name);
    }

    static Material Unlit(Texture t)
    {
        var s = Shader.Find("Unlit/Texture") ?? Shader.Find("Sprites/Default");
        var m = new Material(s); m.mainTexture = t; return m;
    }

    static void AddTexturedQuad(string name, string texturePath, Vector3 pos, Vector3 scale, float zRot, System.Action<string> log)
    {
        var tex = AssetDatabase.LoadAssetAtPath<Texture2D>(texturePath);
        var go = GameObject.CreatePrimitive(PrimitiveType.Quad);
        go.name = name;
        Object.DestroyImmediate(go.GetComponent<Collider>());
        go.transform.position = pos;
        go.transform.localScale = scale;
        go.transform.rotation = Quaternion.Euler(0f, 0f, zRot);
        if (tex != null) go.GetComponent<Renderer>().sharedMaterial = Unlit(tex);
        else go.GetComponent<Renderer>().sharedMaterial = Lit(new Color(0.12f,0.11f,0.10f));
        log("quad " + name + " tex=" + (tex != null ? texturePath : "missing"));
    }

    static void AddColoredQuad(string name, Color color, Vector3 pos, Vector3 scale, System.Action<string> log)
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Quad);
        go.name = name;
        Object.DestroyImmediate(go.GetComponent<Collider>());
        go.transform.position = pos;
        go.transform.localScale = scale;
        go.GetComponent<Renderer>().sharedMaterial = Lit(color);
        log("quad " + name);
    }

    static void AddAnchor(string name, Vector3 pos, System.Action<string> log)
    {
        var go = new GameObject(name);
        go.transform.position = pos;
        log("anchor " + name + " at " + pos);
    }

    static void AddMesh(string name, string meshPath, string matPath, Vector3 pos, Vector3 euler, float scale, System.Action<string> log)
    {
        var mesh = AssetDatabase.LoadAssetAtPath<Mesh>(meshPath);
        if (mesh == null) { log("missing mesh " + meshPath); return; }
        var go = new GameObject(name);
        go.AddComponent<MeshFilter>().sharedMesh = mesh;
        var mr = go.AddComponent<MeshRenderer>();
        var mat = AssetDatabase.LoadAssetAtPath<Material>(matPath);
        mr.sharedMaterial = mat != null ? mat : Lit(Color.white);
        go.transform.position = pos;
        go.transform.rotation = Quaternion.Euler(euler);
        go.transform.localScale = Vector3.one * scale;
    }

    static void DisableUnsafe(GameObject root)
    {
        foreach (var cloth in root.GetComponentsInChildren<Cloth>(true)) cloth.enabled = false;
        foreach (var animator in root.GetComponentsInChildren<Animator>(true))
        {
            animator.avatar = null;
            animator.runtimeAnimatorController = null;
            animator.enabled = false;
        }
    }

    static void BrightenRenderers(GameObject root, float factor)
    {
        foreach (var renderer in root.GetComponentsInChildren<Renderer>(true))
        {
            if (renderer == null || renderer.sharedMaterial == null) continue;
            var mat = new Material(renderer.sharedMaterial);
            if (mat.HasProperty("_Color")) mat.color = mat.color * factor;
            renderer.sharedMaterial = mat;
        }
    }

    public static void ValidateVisual()
    {
        EditorSceneManager.OpenScene("Assets/_IntroReal/KlaasjeBalconyReal.unity", OpenSceneMode.Single);
        var cam = Object.FindAnyObjectByType<Camera>();
        if (cam == null)
        {
            var camGO = new GameObject("KlaasjeValidationCamera");
            cam = camGO.AddComponent<Camera>();
        }
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.black;
        cam.orthographic = true;
        cam.orthographicSize = 6.2f;
        cam.transform.position = new Vector3(0, 0, -18);
        cam.transform.rotation = Quaternion.identity;

        int w = 1280, h = 720;
        var rt = new RenderTexture(w, h, 24);
        cam.targetTexture = rt; cam.Render(); RenderTexture.active = rt;
        var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0,0,w,h),0,0); tex.Apply();
        cam.targetTexture = null; RenderTexture.active = null;
        var pixels = tex.GetPixels(); float lum=0f, mag=0f;
        foreach(var c in pixels){ lum+=(c.r+c.g+c.b)/3f; if(c.r>0.6f&&c.b>0.6f&&c.g<0.3f) mag++; }
        lum/=pixels.Length; mag/=pixels.Length;
        string root = Directory.GetParent(Application.dataPath).FullName;
        File.WriteAllBytes(Path.Combine(root,"klaasje_visual_validation.png"), tex.EncodeToPNG());
        File.WriteAllText(Path.Combine(root,"klaasje_visual_validation.txt"), "avgLum="+lum.ToString("0.000")+"\nmagentaFrac="+mag.ToString("0.0000"));
        Object.DestroyImmediate(rt); Object.DestroyImmediate(tex);
    }
}
