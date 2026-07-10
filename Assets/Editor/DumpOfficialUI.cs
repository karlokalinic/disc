// TEMP DIAGNOSTIC - dumps real Lobby/Init UI hierarchy and cameras for official layout reconstruction.
using System.IO;
using System.Text;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.UI;
using TMPro;

public static class DumpOfficialUI
{
    public static void Run()
    {
        var sb = new StringBuilder();
        DumpScene("Assets/Scenes/Lobby.unity", sb);
        DumpScene("Assets/Scenes/Init.unity", sb);
        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "official_ui_dump.txt"), sb.ToString());
        Debug.Log("[OFFICIAL_UI] dump done");
    }

    static void DumpScene(string path, StringBuilder sb)
    {
        sb.AppendLine("===== " + path + " =====");
        var scene = EditorSceneManager.OpenScene(path, OpenSceneMode.Single);
        foreach (var root in scene.GetRootGameObjects())
            Walk(root.transform, "", sb);
    }

    static void Walk(Transform t, string prefix, StringBuilder sb)
    {
        string p = string.IsNullOrEmpty(prefix) ? t.name : prefix + "/" + t.name;
        bool interesting = p.ToLower().Contains("mainmenu") || p.ToLower().Contains("main menu") ||
            p.ToLower().Contains("character creation") || p.ToLower().Contains("archetype") ||
            p.ToLower().Contains("select") || p.ToLower().Contains("discoelys") ||
            p.ToLower().Contains("newstitle") || p.ToLower().Contains("lobby_backdrop") ||
            p.ToLower().Contains("canvas") || p.ToLower().Contains("camera") ||
            p.ToLower().Contains("feld") || p.ToLower().Contains("loading") ||
            p.ToLower().Contains("title") || p.ToLower().Contains("template") ||
            p.ToLower().Contains("thinker") || p.ToLower().Contains("sensitive") ||
            p.ToLower().Contains("physical") || p.ToLower().Contains("mystic") ||
            p.ToLower().Contains("predator") || p.ToLower().Contains("detective") ||
            p.ToLower().Contains("peony") || p.ToLower().Contains("grey");
        if (interesting || t.GetComponent<Camera>() || t.GetComponent<Canvas>() || t.GetComponent<Image>() || t.GetComponent<RawImage>() || t.GetComponent<SpriteRenderer>())
        {
            sb.AppendLine($"PATH: {p} activeSelf={t.gameObject.activeSelf} activeInHierarchy={t.gameObject.activeInHierarchy} layer={t.gameObject.layer}");
            var rt = t as RectTransform;
            if (rt) sb.AppendLine($"  RT anchorMin={rt.anchorMin} anchorMax={rt.anchorMax} anchored={rt.anchoredPosition} size={rt.sizeDelta} pivot={rt.pivot}");
            var cam = t.GetComponent<Camera>();
            if (cam) sb.AppendLine($"  CAMERA enabled={cam.enabled} clear={cam.clearFlags} bg={cam.backgroundColor} depth={cam.depth} ortho={cam.orthographic} size={cam.orthographicSize} fov={cam.fieldOfView}");
            var canvas = t.GetComponent<Canvas>();
            if (canvas) sb.AppendLine($"  CANVAS enabled={canvas.enabled} mode={canvas.renderMode} sorting={canvas.sortingOrder} camera={(canvas.worldCamera?canvas.worldCamera.name:"null")}");
            var img = t.GetComponent<Image>();
            if (img) sb.AppendLine($"  IMAGE enabled={img.enabled} sprite={(img.sprite?img.sprite.name:"null")} color={img.color} preserve={img.preserveAspect} mat={(img.material?img.material.name:"null")}");
            var raw = t.GetComponent<RawImage>();
            if (raw) sb.AppendLine($"  RAW enabled={raw.enabled} tex={(raw.texture?raw.texture.name:"null")} color={raw.color} mat={(raw.material?raw.material.name:"null")}");
            var sr = t.GetComponent<SpriteRenderer>();
            if (sr) sb.AppendLine($"  SPRITERENDERER enabled={sr.enabled} sprite={(sr.sprite?sr.sprite.name:"null")} color={sr.color} mat={(sr.sharedMaterial?sr.sharedMaterial.name:"null")}");
            var tmp = t.GetComponent<TextMeshProUGUI>();
            if (tmp) sb.AppendLine($"  TMP enabled={tmp.enabled} text='{Short(tmp.text)}' font={(tmp.font?tmp.font.name:"null")} size={tmp.fontSize} color={tmp.color}");
        }
        for (int i = 0; i < t.childCount; i++) Walk(t.GetChild(i), p, sb);
    }

    static string Short(string s)
    {
        if (s == null) return "";
        s = s.Replace("\n", " ");
        return s.Length > 90 ? s.Substring(0, 90) : s;
    }
}
