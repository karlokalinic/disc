using System.Collections.Generic;
using System.IO;
using PixelCrushers.DialogueSystem;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public static class BuildRootWorld
{
    static readonly Color FloorColor = new Color(0.20f, 0.17f, 0.13f);
    static readonly Color WallColor = new Color(0.11f, 0.10f, 0.09f);

    public static void Build()
    {
        var log = new System.Text.StringBuilder();
        void Log(string message)
        {
            log.AppendLine(message);
            Debug.Log("[ROOT WORLD] " + message);
        }

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        BuildWorld(Log);

        var harry = InstantiatePrefab("Assets/GameObject/TequillaSunset.prefab", "Harry", new Vector3(-2.8f, 0f, -0.7f), 1.0f, Log);
        var kim = InstantiatePrefab("Assets/GameObject/Kim.prefab", "Kim", new Vector3(1.4f, 0f, -1.1f), 1.0f, Log);
        var klaasje = InstantiatePrefab("Assets/GameObject/Klaasje.prefab", "Klaasje", new Vector3(3.6f, 0f, 1.7f), 1.0f, Log);

        if (harry != null)
        {
            harry.tag = "Player";
            FitToHeight(harry, 1.85f);
            DisableCloth(harry);
            EnsureCharacterController(harry);
        }
        if (kim != null)
        {
            FitToHeight(kim, 1.78f);
            DisableUnsafeNpcAnimation(kim);
            AddTalkTarget(kim, "kim", "Kim Kitsuragi");
        }
        if (klaasje != null)
        {
            FitToHeight(klaasje, 1.72f);
            DisableUnsafeNpcAnimation(klaasje);
            AddTalkTarget(klaasje, "klaasje", "Klaasje");
        }

        var cameraObject = new GameObject("RootWorldCamera");
        var camera = cameraObject.AddComponent<Camera>();
        cameraObject.AddComponent<AudioListener>();
        camera.transform.position = new Vector3(-2.8f, 9.2f, -10.1f);
        camera.transform.rotation = Quaternion.Euler(47f, 0f, 0f);
        camera.orthographic = true;
        camera.orthographicSize = 6.2f;
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.backgroundColor = new Color(0.025f, 0.026f, 0.027f);
        camera.tag = "MainCamera";

        var controllerObject = new GameObject("RootWorldController");
        var controller = controllerObject.AddComponent<RootWorldController>();
        controller.database = AssetDatabase.LoadAssetAtPath<DialogueDatabase>("Assets/Dialogue Databases/Disco Elysium.asset");
        controller.customDialogueJson = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/_IntroReal/RootWorldDialogue.json");
        controller.player = harry != null ? harry.transform : null;
        controller.kim = kim != null ? kim.transform : null;
        controller.klaasje = klaasje != null ? klaasje.transform : null;
        controller.playerController = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>("Assets/_IntroReal/RecoveredTequilaMovement.controller");
        controller.worldCamera = camera;
        controller.preferCustomDialogue = true;
        controller.kimPortrait = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Addressables Resources/NPC_portraits/portrait_kitsuragi.png");
        controller.klaasjePortrait = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Addressables Resources/NPC_portraits/portrait_klaasje.png");
        controller.worldMapTexture = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Resources/lobby/Martinaise-worldmap.png");

        AddTrigger("CaseBoardTrigger", "case_board", "Case board updated", new Vector3(-5.2f, 0.08f, 2.4f), new Vector3(1.4f, 0.16f, 1.0f), controller);
        AddTrigger("BalconyLeadTrigger", "balcony_lead", "Balcony lead discovered", new Vector3(4.6f, 0.08f, 2.5f), new Vector3(1.8f, 0.16f, 0.9f), controller);

        if (Object.FindAnyObjectByType<EventSystem>() == null)
        {
            var eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
        }

        var light = new GameObject("RootWorldKeyLight").AddComponent<Light>();
        light.type = LightType.Directional;
        light.intensity = 1.1f;
        light.color = new Color(1f, 0.94f, 0.82f);
        light.transform.rotation = Quaternion.Euler(55f, -30f, 0f);

        string outPath = "Assets/_IntroReal/RootWorldReal.unity";
        EditorSceneManager.SaveScene(scene, outPath);
        PutSceneFirst(outPath);
        Log("saved " + outPath);

        string root = Directory.GetParent(Application.dataPath).FullName;
        File.WriteAllText(Path.Combine(root, "root_world_result.txt"), log.ToString());
    }

    public static void Validate()
    {
        var log = new System.Text.StringBuilder();
        void Line(string message)
        {
            log.AppendLine(message);
            Debug.Log("[ROOT WORLD VALIDATE] " + message);
        }

        string scenePath = "Assets/_IntroReal/RootWorldReal.unity";
        EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);
        var controller = Object.FindAnyObjectByType<RootWorldController>();
        var talkTargets = Object.FindObjectsByType<RootWorldTalkTarget>(FindObjectsInactive.Exclude);
        var triggers = Object.FindObjectsByType<RootWorldTrigger>(FindObjectsInactive.Exclude);
        var cameras = Object.FindObjectsByType<Camera>(FindObjectsInactive.Exclude);

        int failures = 0;
        Check(controller != null, "RootWorldController exists", ref failures, Line);
        if (controller != null)
        {
            Check(controller.player != null, "player assigned", ref failures, Line);
            Check(controller.kim != null, "kim assigned", ref failures, Line);
            Check(controller.klaasje != null, "klaasje assigned", ref failures, Line);
            Check(controller.customDialogueJson != null, "custom dialogue JSON assigned", ref failures, Line);
            Check(controller.preferCustomDialogue, "custom dialogue preferred for restored root scene", ref failures, Line);
            Check(controller.playerController != null, "player movement controller assigned", ref failures, Line);
            Check(controller.kimPortrait != null, "Kim portrait assigned", ref failures, Line);
            Check(controller.klaasjePortrait != null, "Klaasje portrait assigned", ref failures, Line);
            Check(controller.worldMapTexture != null, "world map texture assigned", ref failures, Line);
        }
        Check(talkTargets.Length >= 2, "Kim/Klaasje talk targets present: " + talkTargets.Length, ref failures, Line);
        Check(triggers.Length >= 2, "world triggers present: " + triggers.Length, ref failures, Line);
        Check(cameras.Length >= 1, "camera present: " + cameras.Length, ref failures, Line);
        Check(!HasVisibleGeneratedPlaceholder(), "generated placeholder colliders/markers are invisible", ref failures, Line);

        string root = Directory.GetParent(Application.dataPath).FullName;
        File.WriteAllText(Path.Combine(root, "root_world_validation.txt"), "failures=" + failures + "\n" + log);
        if (failures > 0) throw new System.InvalidOperationException("RootWorld validation failed: " + failures);
    }

    static void Check(bool condition, string message, ref int failures, System.Action<string> log)
    {
        if (condition) log("OK " + message);
        else
        {
            failures++;
            log("FAIL " + message);
        }
    }

    static bool HasVisibleGeneratedPlaceholder()
    {
        foreach (var renderer in Object.FindObjectsByType<Renderer>(FindObjectsInactive.Include))
        {
            if (renderer == null || !renderer.enabled) continue;
            string name = renderer.gameObject.name;
            if (name == "WhirlingRootWalkable" || name.StartsWith("MapMarker_") || name.EndsWith("Trigger")) return true;
            if (name == "BackWall" || name == "LeftWall" || name == "RightWall" || name == "WhirlingRootFloor") return true;
        }
        return false;
    }

    static void BuildWorld(System.Action<string> log)
    {
        AddInvisibleCollider("WhirlingRootWalkable", new Vector3(0f, -0.08f, 0f), new Vector3(12f, 0.16f, 8f));

        var backdropTexture = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Texture2D/WhirlingF1.png");
        if (backdropTexture != null)
        {
            var backdrop = GameObject.CreatePrimitive(PrimitiveType.Quad);
            backdrop.name = "WhirlingPaintedBackdrop";
            Object.DestroyImmediate(backdrop.GetComponent<Collider>());
            backdrop.transform.position = new Vector3(0f, 0.015f, 0f);
            backdrop.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
            backdrop.transform.localScale = new Vector3(11.8f, 7.4f, 1f);
            backdrop.GetComponent<Renderer>().sharedMaterial = Unlit(backdropTexture);
            log("backdrop WhirlingF1 loaded");
        }
        else log("missing WhirlingF1 backdrop texture");

        AddMapMarker("Room", new Vector3(-4.8f, 0.03f, -3.0f), new Color(0.34f, 0.25f, 0.16f));
        AddMapMarker("Lobby", new Vector3(-0.4f, 0.03f, -3.0f), new Color(0.27f, 0.31f, 0.24f));
        AddMapMarker("Balcony", new Vector3(4.2f, 0.03f, -3.0f), new Color(0.20f, 0.30f, 0.35f));
    }

    static void AddWall(string name, Vector3 position, Vector3 scale)
    {
        var wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.name = name;
        wall.transform.position = position;
        wall.transform.localScale = scale;
        wall.GetComponent<Renderer>().sharedMaterial = Lit(WallColor);
    }

    static void AddInvisibleCollider(string name, Vector3 position, Vector3 scale)
    {
        var colliderObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        colliderObject.name = name;
        colliderObject.transform.position = position;
        colliderObject.transform.localScale = scale;
        var renderer = colliderObject.GetComponent<Renderer>();
        if (renderer != null) renderer.enabled = false;
    }

    static void AddMapMarker(string name, Vector3 position, Color color)
    {
        var marker = GameObject.CreatePrimitive(PrimitiveType.Cube);
        marker.name = "MapMarker_" + name;
        marker.transform.position = position;
        marker.transform.localScale = new Vector3(1.6f, 0.06f, 0.72f);
        var renderer = marker.GetComponent<Renderer>();
        renderer.sharedMaterial = Lit(color);
        renderer.enabled = false;
    }

    static GameObject InstantiatePrefab(string path, string name, Vector3 position, float scale, System.Action<string> log)
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
        GameObject go = prefab != null ? (GameObject)PrefabUtility.InstantiatePrefab(prefab) : GameObject.CreatePrimitive(PrimitiveType.Capsule);
        if (go == null)
        {
            log("failed " + path);
            return null;
        }
        go.name = name;
        go.transform.position = position;
        go.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        go.transform.localScale = Vector3.one * scale;
        log(name + " prefab=" + path + " exists=" + (prefab != null));
        return go;
    }

    static void FitToHeight(GameObject root, float targetHeight)
    {
        var renderers = root.GetComponentsInChildren<Renderer>(true);
        if (renderers.Length == 0) return;
        Bounds bounds = renderers[0].bounds;
        for (int i = 1; i < renderers.Length; i++) bounds.Encapsulate(renderers[i].bounds);
        float scale = Mathf.Clamp(targetHeight / Mathf.Max(0.01f, bounds.size.y), 0.05f, 8f);
        root.transform.localScale *= scale;
        root.transform.position = new Vector3(root.transform.position.x, 0f, root.transform.position.z);
    }

    static void DisableCloth(GameObject root)
    {
        foreach (var cloth in root.GetComponentsInChildren<Cloth>(true)) cloth.enabled = false;
    }

    static void DisableUnsafeNpcAnimation(GameObject root)
    {
        DisableCloth(root);
        foreach (var animator in root.GetComponentsInChildren<Animator>(true))
        {
            animator.avatar = null;
            animator.runtimeAnimatorController = null;
            animator.enabled = false;
        }
    }

    static void EnsureCharacterController(GameObject root)
    {
        var controller = root.GetComponent<CharacterController>();
        if (controller == null) controller = root.AddComponent<CharacterController>();
        controller.height = 1.85f;
        controller.radius = 0.34f;
        controller.center = new Vector3(0f, 0.92f, 0f);
    }

    static void AddTalkTarget(GameObject root, string key, string label)
    {
        var target = root.GetComponent<RootWorldTalkTarget>();
        if (target == null) target = root.AddComponent<RootWorldTalkTarget>();
        target.targetKey = key;
        target.displayName = label;

        var collider = root.GetComponent<CapsuleCollider>();
        if (collider == null) collider = root.AddComponent<CapsuleCollider>();
        collider.height = 1.9f;
        collider.radius = 0.48f;
        collider.center = new Vector3(0f, 0.95f, 0f);
    }

    static void AddTrigger(string name, string key, string label, Vector3 position, Vector3 scale, RootWorldController controller)
    {
        var trigger = GameObject.CreatePrimitive(PrimitiveType.Cube);
        trigger.name = name;
        trigger.transform.position = position;
        trigger.transform.localScale = scale;
        var renderer = trigger.GetComponent<Renderer>();
        renderer.sharedMaterial = Lit(new Color(0.55f, 0.42f, 0.18f));
        renderer.enabled = false;
        var collider = trigger.GetComponent<BoxCollider>();
        collider.isTrigger = true;
        var rootTrigger = trigger.AddComponent<RootWorldTrigger>();
        rootTrigger.controller = controller;
        rootTrigger.triggerKey = key;
        rootTrigger.displayName = label;
    }

    static Material Lit(Color color)
    {
        var shader = Shader.Find("Standard") ?? Shader.Find("Legacy Shaders/Diffuse");
        var material = new Material(shader);
        if (material.HasProperty("_Color")) material.color = color;
        return material;
    }

    static Material Unlit(Texture texture)
    {
        var shader = Shader.Find("Unlit/Texture") ?? Shader.Find("Sprites/Default");
        var material = new Material(shader);
        material.mainTexture = texture;
        return material;
    }

    static void PutSceneFirst(string path)
    {
        var scenes = new List<EditorBuildSettingsScene>();
        scenes.Add(new EditorBuildSettingsScene(path, true));
        foreach (var scene in EditorBuildSettings.scenes)
            if (scene.path != path) scenes.Add(scene);
        EditorBuildSettings.scenes = scenes.ToArray();
    }
}