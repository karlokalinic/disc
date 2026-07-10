// BuildShowcase — assembles Assets/3DShowcase.unity: a cinematic gallery of the REAL Disco Elysium
// characters and 3D objects, each on a turntable pedestal with full materials/textures, cinematic
// three-point lighting, a floor, ambient audio and an orbit camera driven by ShowcaseController.
// Humanoid Animators/Avatars are neutralised (they crash the IL2CPP-ripped native retargeter in a
// player build); figures are presented on turntables with an idle sway so the models read clearly.
// Run: Unity -batchmode -quit -projectPath <proj> -executeMethod BuildShowcase.Build
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class BuildShowcase
{
    // character prefabs that carry a real self-contained rig (label, subtitle)
    static readonly (string path, string label, string sub)[] Chars = new (string,string,string)[]
    {
        ("Assets/GameObject/TequillaSunset.prefab", "Harry Du Bois",  "The Detective — codename \"Tequila Sunset\""),
        ("Assets/GameObject/Klaasje.prefab",        "Klaasje",        "Miss Oranje Disco Dancer"),
        ("Assets/GameObject/Garte_0.prefab",        "Garte",          "Manager of the Whirling-in-Rags"),
        ("Assets/GameObject/Cunoesse.prefab",       "Cunoesse",       "Cuno's companion"),
        ("Assets/GameObject/Eugene.prefab",         "Eugene",         "Dockworker of the Union"),
        ("Assets/GameObject/Steban Prefab.prefab",  "Steban",         "The Communist student"),
        ("Assets/GameObject/EasyLeo.prefab",        "Easy Leo",       "Dockworker"),
        ("Assets/GameObject/FatAngus.prefab",       "Fat Angus",      "Union hardsman"),
        ("Assets/GameObject/Lena.prefab",           "Lena",           "The Cryptozoologist's wife"),
        ("Assets/GameObject/Working Woman.prefab",  "Working Woman",  "Martinaise local"),
        ("Assets/GameObject/DrunkWorker.prefab",    "Drunk Worker",   "Harbour drunk"),
        ("Assets/GameObject/Money Man.prefab",      "Money Man",      "Martinaise figure"),
    };

    // real 3D object exhibits (mesh + material)
    static readonly (string mesh, string mat, string label, string sub)[] Props = new (string,string,string,string)[]
    {
        ("Assets/Mesh/tequila_tie.asset",     "Assets/Material/tequila_tie.mat",   "The Necktie",  "Horrific silhouette — hangs from the fan"),
        ("Assets/Mesh/tequila_pants.asset",   "Assets/Material/teq_pants_TEX.mat",  "The Trousers", "Fila brand, disco-era"),
        ("Assets/Mesh/shoes_snakeskin.asset", "Assets/Material/tequila_shoes.mat",  "Snakeskin Shoe","One is lost"),
        ("Assets/Mesh/int-bottle-whiskey-2.asset", "Assets/Material/int-bottle-whiskey-mat.mat", "Whiskey Bottle", "The night before"),
    };

    static Material Lit(Color c)
    {
        var s = Shader.Find("Standard") ?? Shader.Find("Legacy Shaders/Diffuse");
        var m = new Material(s); if (m.HasProperty("_Color")) m.color = c;
        if (m.HasProperty("_Glossiness")) m.SetFloat("_Glossiness", 0.1f);
        return m;
    }

    public static void Build()
    {
        var log = new System.Text.StringBuilder();
        void L(string s){ log.AppendLine(s); Debug.Log("[SHOWCASE] " + s); }

        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // ---- environment ----
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Trilight;
        RenderSettings.ambientSkyColor    = new Color(0.16f, 0.18f, 0.22f);
        RenderSettings.ambientEquatorColor= new Color(0.10f, 0.10f, 0.12f);
        RenderSettings.ambientGroundColor = new Color(0.04f, 0.04f, 0.05f);
        RenderSettings.fog = true; RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fogColor = new Color(0.05f,0.06f,0.08f); RenderSettings.fogStartDistance = 14f; RenderSettings.fogEndDistance = 55f;

        var floor = GameObject.CreatePrimitive(PrimitiveType.Plane); floor.name = "GalleryFloor";
        floor.transform.localScale = new Vector3(12f, 1f, 12f);
        floor.GetComponent<Renderer>().sharedMaterial = Lit(new Color(0.10f, 0.10f, 0.12f));

        var key = new GameObject("KeyLight").AddComponent<Light>();
        key.type = LightType.Directional; key.intensity = 1.15f; key.color = new Color(1f, 0.95f, 0.86f);
        key.shadows = LightShadows.Soft; key.transform.rotation = Quaternion.Euler(40f, 40f, 0f);
        var fill = new GameObject("FillLight").AddComponent<Light>();
        fill.type = LightType.Directional; fill.intensity = 0.4f; fill.color = new Color(0.6f, 0.7f, 1f);
        fill.transform.rotation = Quaternion.Euler(20f, -120f, 0f);

        var camGO = new GameObject("ShowcaseCamera");
        var cam = camGO.AddComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = new Color(0.03f, 0.035f, 0.05f);
        cam.fieldOfView = 42f; cam.nearClipPlane = 0.05f;
        camGO.tag = "MainCamera"; camGO.AddComponent<AudioListener>();
        camGO.transform.position = new Vector3(0f, 1.4f, -4f);

        var controllerGO = new GameObject("ShowcaseController");
        var ctrl = controllerGO.AddComponent<ShowcaseController>();
        ctrl.cam = cam; ctrl.keyLight = key;
        ctrl.exhibits = new List<ShowcaseController.Exhibit>();

        // ---- characters row (z = 0) ----
        float spacing = 2.6f; int placed = 0;
        int nChars = Chars.Length;
        float startX = -(nChars - 1) * spacing * 0.5f;
        for (int i = 0; i < nChars; i++)
        {
            var e = BuildExhibit(Chars[i].path, Chars[i].label, Chars[i].sub,
                new Vector3(startX + i * spacing, 0f, 0f), 1.85f, false, L);
            if (e != null) { ctrl.exhibits.Add(e); placed++; }
        }

        // ---- objects row (z = 4, behind) ----
        int nProps = Props.Length;
        float startXp = -(nProps - 1) * spacing * 0.5f;
        for (int i = 0; i < nProps; i++)
        {
            var e = BuildPropExhibit(Props[i].mesh, Props[i].mat, Props[i].label, Props[i].sub,
                new Vector3(startXp + i * spacing, 0f, 4.5f), 0.7f, L);
            if (e != null) ctrl.exhibits.Add(e);
        }

        // ---- ambient audio (first real clip found) ----
        var clipGuids = AssetDatabase.FindAssets("t:AudioClip", new[] { "Assets/AudioClip" });
        if (clipGuids.Length > 0)
        {
            var clip = AssetDatabase.LoadAssetAtPath<AudioClip>(AssetDatabase.GUIDToAssetPath(clipGuids[0]));
            if (clip != null)
            {
                var a = camGO.AddComponent<AudioSource>();
                a.clip = clip; a.loop = true; a.playOnAwake = true; a.volume = 0.35f; a.spatialBlend = 0f;
                L("ambient audio = " + clip.name);
            }
        }

        L("exhibits total = " + ctrl.exhibits.Count + " (characters " + placed + " / " + nChars + ", props " + (ctrl.exhibits.Count - placed) + ")");

        Directory.CreateDirectory(Path.Combine(Application.dataPath));
        string outPath = "Assets/3DShowcase.unity";
        EditorSceneManager.MarkSceneDirty(scene);
        EditorSceneManager.SaveScene(scene, outPath);
        L("saved " + outPath);

        // add to build settings (enabled, after the existing chain)
        var list = new List<EditorBuildSettingsScene>();
        foreach (var s in EditorBuildSettings.scenes) if (s.path != outPath) list.Add(s);
        list.Add(new EditorBuildSettingsScene(outPath, true));
        EditorBuildSettings.scenes = list.ToArray();

        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "showcase_result.txt"), log.ToString());
        Debug.Log("[SHOWCASE] DONE");
    }

    static ShowcaseController.Exhibit BuildExhibit(string prefabPath, string label, string sub, Vector3 at, float targetH, bool isProp, System.Action<string> L)
    {
        var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
        if (prefab == null) { L("MISSING prefab: " + prefabPath); return null; }
        var model = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
        if (model == null) { L("instantiate failed: " + prefabPath); return null; }

        // neutralise humanoid animators (native retarget crashes the ripped player build)
        foreach (var an in model.GetComponentsInChildren<Animator>(true)) { an.runtimeAnimatorController = null; an.avatar = null; an.enabled = false; }

        var rends = model.GetComponentsInChildren<Renderer>(true);
        if (rends.Length == 0) { L("no renderers, skipping: " + prefabPath); Object.DestroyImmediate(model); return null; }
        // hide contact/blob-shadow and decal quads that render as flat black under gallery lighting
        var visible = new List<Renderer>();
        foreach (var r in rends)
        {
            string rn = r.name.ToLowerInvariant();
            string mn = (r.sharedMaterial != null ? r.sharedMaterial.name : "").ToLowerInvariant();
            if (rn.Contains("shadow") || rn.Contains("blob") || rn.Contains("decal") || rn.Contains("projector") ||
                mn.Contains("shadow") || mn.Contains("blob")) { r.enabled = false; continue; }
            r.enabled = true; visible.Add(r);
        }
        if (visible.Count == 0) { L("only shadow renderers, skipping: " + prefabPath); Object.DestroyImmediate(model); return null; }
        rends = visible.ToArray();

        MakePedestal(at, label);
        var turn = new GameObject("Turntable_" + label).transform;
        turn.position = new Vector3(at.x, PedestalTop, at.z);

        model.transform.SetParent(turn, true);
        model.transform.localRotation = Quaternion.identity;

        // scale to target height then seat feet on pedestal, centre horizontally
        Bounds b = WorldBounds(rends);
        float h = Mathf.Max(0.01f, b.size.y);
        float scale = Mathf.Clamp(targetH / h, 0.05f, 50f);
        model.transform.localScale = model.transform.localScale * scale;
        b = WorldBounds(rends);
        Vector3 off;
        off.x = turn.position.x - b.center.x;
        off.z = turn.position.z - b.center.z;
        off.y = turn.position.y - b.min.y;
        model.transform.position += off;

        var e = new ShowcaseController.Exhibit {
            pedestal = turn, model = model.transform, label = label, subtitle = sub, baseY = model.transform.localPosition.y
        };
        L("placed " + label + "  renderers=" + rends.Length + " scale=" + scale.ToString("0.00"));
        return e;
    }

    static ShowcaseController.Exhibit BuildPropExhibit(string meshPath, string matPath, string label, string sub, Vector3 at, float targetH, System.Action<string> L)
    {
        var mesh = AssetDatabase.LoadAssetAtPath<Mesh>(meshPath);
        if (mesh == null) { L("MISSING mesh: " + meshPath); return null; }
        var model = new GameObject(label + "_model");
        model.AddComponent<MeshFilter>().sharedMesh = mesh;
        var mr = model.AddComponent<MeshRenderer>();
        var mat = AssetDatabase.LoadAssetAtPath<Material>(matPath);
        mr.sharedMaterial = mat != null ? mat : Lit(new Color(0.6f,0.5f,0.4f));

        MakePedestal(at, label);
        var turn = new GameObject("Turntable_" + label).transform;
        turn.position = new Vector3(at.x, PedestalTop, at.z);
        model.transform.SetParent(turn, true);
        model.transform.localRotation = Quaternion.identity;

        float h = Mathf.Max(0.01f, mesh.bounds.size.y);
        model.transform.localScale = Vector3.one * Mathf.Clamp(targetH / h, 0.02f, 100f);
        var rends = model.GetComponentsInChildren<Renderer>(true);
        Bounds b = WorldBounds(rends);
        Vector3 off;
        off.x = turn.position.x - b.center.x;
        off.z = turn.position.z - b.center.z;
        off.y = turn.position.y - b.min.y + 0.05f;
        model.transform.position += off;

        var e = new ShowcaseController.Exhibit {
            pedestal = turn, model = model.transform, label = label, subtitle = sub, baseY = model.transform.localPosition.y
        };
        L("placed prop " + label);
        return e;
    }

    const float PedestalTop = 0.35f;
    static GameObject MakePedestal(Vector3 at, string name)
    {
        var ped = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        ped.name = "Pedestal_" + name;
        Object.DestroyImmediate(ped.GetComponent<Collider>());
        ped.transform.position = at + new Vector3(0f, PedestalTop * 0.5f, 0f);
        ped.transform.localScale = new Vector3(1.3f, PedestalTop * 0.5f, 1.3f);
        ped.GetComponent<Renderer>().sharedMaterial = Lit(new Color(0.14f, 0.13f, 0.14f));
        return ped;
    }

    static Bounds WorldBounds(Renderer[] rends)
    {
        Bounds b = rends[0].bounds;
        for (int i = 1; i < rends.Length; i++) b.Encapsulate(rends[i].bounds);
        return b;
    }

    // Render a proof screenshot of the assembled scene (Built-in RP -> Camera.Render is reliable).
    public static void Snapshot()
    {
        EditorSceneManager.OpenScene("Assets/3DShowcase.unity", OpenSceneMode.Single);
        var cam = Object.FindAnyObjectByType<Camera>();
        if (cam == null) { Debug.Log("[SNAP] no camera"); return; }
        // frame the first character exhibit
        var ctrl = Object.FindAnyObjectByType<ShowcaseController>();
        Vector3 look = Vector3.up * 1.2f;
        if (ctrl != null && ctrl.exhibits.Count > 0 && ctrl.exhibits[0].pedestal != null)
        {
            var t = ctrl.exhibits[0].pedestal;
            cam.transform.position = t.position + new Vector3(0f, 1.4f, -3.4f);
            look = t.position + Vector3.up * 1.0f;
        }
        cam.transform.rotation = Quaternion.LookRotation(look - cam.transform.position);

        int W = 1280, H = 720;
        var rt = new RenderTexture(W, H, 24);
        cam.targetTexture = rt; cam.Render();
        RenderTexture.active = rt;
        var tex = new Texture2D(W, H, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, W, H), 0, 0); tex.Apply();
        cam.targetTexture = null; RenderTexture.active = null;

        // brightness/colour stats to prove it isn't black/magenta
        var px = tex.GetPixels(); float lum = 0f, mag = 0f;
        foreach (var c in px) { lum += (c.r + c.g + c.b) / 3f; if (c.r > 0.6f && c.b > 0.6f && c.g < 0.3f) mag++; }
        lum /= px.Length; mag /= px.Length;
        string outp = Path.Combine(Directory.GetParent(Application.dataPath).FullName, "showcase_snapshot.png");
        File.WriteAllBytes(outp, tex.EncodeToPNG());
        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "snap_stats.txt"),
            "avgLum=" + lum.ToString("0.000") + " magentaFrac=" + mag.ToString("0.0000") + " -> " + outp);
        Debug.Log("[SNAP] avgLum=" + lum.ToString("0.000") + " magenta=" + mag.ToString("0.0000") + " saved " + outp);
    }
}
