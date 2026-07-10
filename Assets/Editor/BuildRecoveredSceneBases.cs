using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class BuildRecoveredSceneBases
{
    class SceneDef
    {
        public string name, title;
        public string[] prefabs;
        public SceneDef(string name, string title, params string[] prefabs)
        { this.name = name; this.title = title; this.prefabs = prefabs; }
    }

    static readonly SceneDef[] Scenes = {
        new SceneDef("Recovered_WhirlingF1", "Whirling-in-Rags F1", "Props whirling f1.prefab", "_AMBIENCE-Whirling.prefab", "Whirling 1 Revealer.prefab", "Whirling F1 music day.prefab", "Curtains Whirling Open All.prefab", "Karaoke Prefab.prefab"),
        new SceneDef("Recovered_WhirlingF2", "Whirling-in-Rags F2", "Props whirling f2.prefab", "_AMBIENCE-Whirling.prefab", "Whirling 2 Nightlights.prefab", "Karaoke Prefab 2f.prefab"),
        new SceneDef("Recovered_WhirlingF3", "Whirling-in-Rags F3", "Whirling_F3_props.prefab", "_AMBIENCE-Whirling F3.prefab"),
        new SceneDef("Recovered_MartinaiseNorth", "Martinaise North", "Props MARTINAISE North.prefab", "Interactable Martinaise North.prefab", "_IEG Martinaise North.prefab"),
        new SceneDef("Recovered_MartinaiseSouth", "Martinaise South", "Props MARTINAISE South.prefab", "Interactable Martinaise South.prefab", "_IEG Martinaise South.prefab"),
        new SceneDef("Recovered_MartinaiseEast", "Martinaise East", "Props Martinaise East.prefab", "Interactable Martinaise East.prefab", "_IEG Martinaise East.prefab"),
        new SceneDef("Recovered_MartinaiseWest", "Martinaise West", "Props MARTINAISE West.prefab", "Interactable Martinaise West.prefab", "_IEG Martinaise West.prefab"),
        new SceneDef("Recovered_Church", "Church", "Props Church.prefab", "_IEG-Church.prefab", "Church Lights.prefab", "Church Daylight.prefab", "Night light Church.prefab"),
        new SceneDef("Recovered_Communist", "Communist Vision", "Props Communist.prefab", "_IEG Communist.prefab"),
        new SceneDef("Recovered_Dream3", "Dream 3", "Props Dream 3.prefab", "_IEG Dream 3.prefab", "FX_Dream.prefab", "dolores_dreamScene_wOffset Prefab.prefab"),
        new SceneDef("Recovered_SeaFort", "Sea Fort", "Props Sea Fort.prefab"),
        new SceneDef("Recovered_DoomedF1", "Doomed Commercial Area F1", "_IEG-Doomed-F1.prefab", "Bookstore Props.prefab", "NightLights Doomed F1.prefab", "Bookstore Curtains open.prefab"),
        new SceneDef("Recovered_DoomedF2", "Doomed Commercial Area F2", "_IEG-Doomed-F2.prefab", "Doomed F2 props Variant.prefab", "Windows-shafts-doomed-f2.prefab"),
        new SceneDef("Recovered_DoomedS1", "Doomed Basement", "_IEG-Doomed-S1.prefab", "ext_doomed-bars.prefab"),
        new SceneDef("Recovered_Capeside", "Capeside Interiors", "_IEG-Capeside-apartments.prefab", "_IEG-Capeside-coalchamber.prefab", "_IEG-Capeside-smoker.prefab", "_IEG-Capeside-wcw.prefab", "additive-lightmap-capeside-int.prefab", "Props - Smoker.prefab"),
        new SceneDef("Recovered_InstigatorsLair", "Instigators Lair", "_IEG Instigators Lair.prefab"),
        new SceneDef("Recovered_HarbourCrowd", "Harbour Crowd", "Scab Crowds Prefab.prefab", "Scab1.prefab", "Scab2.prefab", "ScabLeader.prefab", "EvrartClaire.prefab"),
        new SceneDef("Recovered_CoastPier", "Coast and Pier", "Pier Laterns.prefab", "Pier Sloop.prefab", "Pier Nightlights.prefab", "ME-Coast day.prefab", "morell boardwalk Prefab.prefab", "cryptofascist boardwalk Prefab.prefab"),
        new SceneDef("Recovered_CunoShack", "Cuno Shack", "Props Cunos Shack.prefab", "Cunos-Raft.prefab", "Cuno.prefab", "Cunoesse.prefab"),
        new SceneDef("Recovered_URR", "Union / Ruins / Revachol", "URR npcs.prefab", "URR light.prefab", "Latenight Guests.prefab", "Canal Crew Prefab.prefab")
    };

    public static void Build()
    {
        Directory.CreateDirectory("Assets/RecoveredScenes");
        var builtPaths = new List<string>();
        var builtNames = new List<string>();
        var titles = new List<string>();
        var log = new System.Text.StringBuilder();

        for (int i = 0; i < Scenes.Length; i++)
        {
            var def = Scenes[i];
            string path = "Assets/RecoveredScenes/" + def.name + ".unity";
            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var loaded = new List<string>();

            foreach (var prefabName in def.prefabs)
            {
                string prefabPath = "Assets/GameObject/" + prefabName;
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
                if (prefab == null) { log.AppendLine(def.name + " missing " + prefabName); continue; }
                var go = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                if (go == null) { log.AppendLine(def.name + " failed " + prefabName); continue; }
                go.name = Path.GetFileNameWithoutExtension(prefabName);
                DisableUnsafeAnimators(go);
                loaded.Add(prefabName);
            }

            var boot = new GameObject("RecoveredSceneBootstrap").AddComponent<RecoveredSceneBootstrap>();
            boot.sceneTitle = def.title;
            boot.sourcePrefabs = loaded.Count == 0 ? "none loaded" : string.Join(", ", loaded.ToArray());
            boot.indexScene = "RecoveredSceneIndex";
            boot.previousScene = i > 0 ? Scenes[i - 1].name : Scenes[Scenes.Length - 1].name;
            boot.nextScene = i < Scenes.Length - 1 ? Scenes[i + 1].name : Scenes[0].name;
            boot.playerPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/TequillaSunset.prefab");
            boot.playerController = AssetDatabase.LoadAssetAtPath<RuntimeAnimatorController>("Assets/AnimatorController/Tequila Sunset Controller.controller");
            boot.database = AssetDatabase.LoadAssetAtPath<PixelCrushers.DialogueSystem.DialogueDatabase>("Assets/Dialogue Databases/Disco Elysium.asset");
            AddRecoveryLighting();

            EditorSceneManager.SaveScene(scene, path);
            builtPaths.Add(path); builtNames.Add(def.name); titles.Add(def.title);
            log.AppendLine(def.name + ": loaded " + loaded.Count + "/" + def.prefabs.Length + " -> " + path);
        }

        BuildIndexScene(builtNames.ToArray(), titles.ToArray(), log);
        UpdateBuildSettings(builtPaths);
        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "recovered_scene_bases.txt"), log.ToString());
        Debug.Log("[RECOVERED] Built " + builtPaths.Count + " recovered base scenes");
    }

    static void BuildIndexScene(string[] sceneNames, string[] titles, System.Text.StringBuilder log)
    {
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        var go = new GameObject("RecoveredSceneIndex");
        var idx = go.AddComponent<RecoveredSceneIndex>();
        idx.sceneNames = sceneNames;
        idx.sceneTitles = titles;
        var camGO = new GameObject("IndexCamera");
        var cam = camGO.AddComponent<Camera>(); cam.clearFlags = CameraClearFlags.SolidColor; cam.backgroundColor = new Color(0.02f,0.018f,0.014f); camGO.AddComponent<AudioListener>(); camGO.tag = "MainCamera";
        EditorSceneManager.SaveScene(scene, "Assets/RecoveredScenes/RecoveredSceneIndex.unity");
        log.AppendLine("RecoveredSceneIndex: " + sceneNames.Length + " entries");
    }

    static void UpdateBuildSettings(List<string> builtPaths)
    {
        var list = new List<EditorBuildSettingsScene>{
            new EditorBuildSettingsScene("Assets/_IntroReal/BootBlank.unity", true),
            new EditorBuildSettingsScene("Assets/_IntroReal/FlowReal.unity", false),
            new EditorBuildSettingsScene("Assets/_IntroReal/IntroReal.unity", true),
            new EditorBuildSettingsScene("Assets/_IntroReal/RoomReal.unity", true),
            new EditorBuildSettingsScene("Assets/Scenes/PreInitialize.unity", false),
            new EditorBuildSettingsScene("Assets/Scenes/Initialize.unity", false),
            new EditorBuildSettingsScene("Assets/Scenes/Init.unity", false),
            new EditorBuildSettingsScene("Assets/Scenes/Lobby.unity", false),
            new EditorBuildSettingsScene("Assets/3DShowcase.unity", true),
            new EditorBuildSettingsScene("Assets/RecoveredScenes/RecoveredSceneIndex.unity", true)
        };
        foreach (var path in builtPaths) list.Add(new EditorBuildSettingsScene(path, true));
        EditorBuildSettings.scenes = list.ToArray();
    }

    static void DisableUnsafeAnimators(GameObject root)
    {
        foreach (var cloth in root.GetComponentsInChildren<Cloth>(true)) cloth.enabled = false;
        foreach (var animator in root.GetComponentsInChildren<Animator>(true))
        {
            animator.runtimeAnimatorController = null;
            animator.avatar = null;
            animator.enabled = false;
        }
    }

    static void AddRecoveryLighting()
    {
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = new Color(0.72f, 0.70f, 0.66f);

        var key = new GameObject("RecoveredKeyLight").AddComponent<Light>();
        key.type = LightType.Directional;
        key.intensity = 1.25f;
        key.color = new Color(1f, 0.94f, 0.84f);
        key.transform.rotation = Quaternion.Euler(50f, -35f, 0f);

        var fill = new GameObject("RecoveredFillLight").AddComponent<Light>();
        fill.type = LightType.Directional;
        fill.intensity = 0.55f;
        fill.color = new Color(0.62f, 0.70f, 1f);
        fill.transform.rotation = Quaternion.Euler(25f, 140f, 0f);
    }

    public static void ValidateVisuals()
    {
        var report = new System.Text.StringBuilder();
        report.AppendLine("Recovered scene visual validation");
        report.AppendLine("scene,renderers,avgLum,magentaFrac,boundsSize");

        foreach (var def in Scenes)
        {
            string path = "Assets/RecoveredScenes/" + def.name + ".unity";
            if (!File.Exists(path)) { report.AppendLine(def.name + ",MISSING,0,0,0"); continue; }
            EditorSceneManager.OpenScene(path, OpenSceneMode.Single);
            var renderers = Object.FindObjectsByType<Renderer>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
            if (renderers.Length == 0) { report.AppendLine(def.name + ",0,0,0,0"); continue; }

            Bounds bounds = UsefulBounds(renderers);

            var camGO = new GameObject("ValidationCamera");
            var cam = camGO.AddComponent<Camera>();
            cam.clearFlags = CameraClearFlags.SolidColor;
            cam.backgroundColor = Color.black;
            cam.nearClipPlane = 0.05f;
            cam.farClipPlane = Mathf.Max(1000f, bounds.size.magnitude * 8f);
            float dist = Mathf.Clamp(bounds.size.magnitude * 0.72f, 18f, 260f);
            Vector3 dir = new Vector3(-0.75f, 0.55f, -0.75f).normalized;
            cam.transform.position = bounds.center - dir * dist;
            cam.transform.LookAt(bounds.center);

            int w = 480, h = 270;
            var rt = new RenderTexture(w, h, 24);
            cam.targetTexture = rt;
            cam.Render();
            RenderTexture.active = rt;
            var tex = new Texture2D(w, h, TextureFormat.RGB24, false);
            tex.ReadPixels(new Rect(0, 0, w, h), 0, 0);
            tex.Apply();
            var px = tex.GetPixels();
            float lum = 0f, mag = 0f;
            foreach (var c in px)
            {
                lum += (c.r + c.g + c.b) / 3f;
                if (c.r > 0.6f && c.b > 0.6f && c.g < 0.3f) mag += 1f;
            }
            lum /= px.Length; mag /= px.Length;
            cam.targetTexture = null; RenderTexture.active = null;
            Object.DestroyImmediate(rt); Object.DestroyImmediate(tex); Object.DestroyImmediate(camGO);

            report.AppendLine(def.name + "," + renderers.Length + "," + lum.ToString("0.000") + "," + mag.ToString("0.0000") + "," + bounds.size.magnitude.ToString("0.0"));
        }

        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "recovered_scene_visual_validation.txt"), report.ToString());
        Debug.Log("[RECOVERED] Visual validation complete");
    }

    static Bounds UsefulBounds(Renderer[] renderers)
    {
        Bounds all = renderers[0].bounds;
        for (int i = 1; i < renderers.Length; i++) all.Encapsulate(renderers[i].bounds);
        float maxUsefulSize = Mathf.Max(40f, all.size.magnitude * 0.35f);
        bool found = false;
        Bounds useful = new Bounds(all.center, Vector3.one);
        foreach (var renderer in renderers)
        {
            if (renderer == null || !renderer.enabled) continue;
            string n = renderer.name.ToLowerInvariant();
            if (n.Contains("blob shadow") || n.Contains("fog") || n.Contains("unseen")) continue;
            if (renderer.bounds.size.magnitude > maxUsefulSize) continue;
            if (!found) { useful = renderer.bounds; found = true; }
            else useful.Encapsulate(renderer.bounds);
        }
        return found ? useful : all;
    }
}
