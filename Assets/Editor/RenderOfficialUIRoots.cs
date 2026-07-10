// TEMP utility: activates official UI roots from Init/Lobby one at a time and renders screenshots.
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class RenderOfficialUIRoots
{
    public static void Run()
    {
        RenderRoot("Assets/Scenes/Init.unity", "ArchetypeSelection", "official_Init_ArchetypeSelection.png");
        RenderRoot("Assets/Scenes/Init.unity", "MainMenu", "official_Init_MainMenu.png");
        RenderRoot("Assets/Scenes/Lobby.unity", "Archetype Selection", "official_Lobby_ArchetypeSelection.png");
        RenderRoot("Assets/Scenes/Lobby.unity", "Character Creation", "official_Lobby_CharacterCreation.png");
    }

    static void RenderRoot(string scenePath, string rootName, string outName)
    {
        var scene = EditorSceneManager.OpenScene(scenePath, OpenSceneMode.Single);
        foreach (var go in Object.FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None))
        {
            if (go.transform.parent == null || go.name == rootName || go.name.Contains("Camera") || go.name.Contains("Canvas")) go.SetActive(true);
        }
        var target = Find(rootName);
        if (target != null) target.SetActive(true);
        // disable obvious debug screens except requested root and parents
        foreach (var go in Object.FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None))
        {
            if (target != null && (go == target || go.transform.IsChildOf(target.transform))) continue;
            string n = go.name.ToLowerInvariant();
            if (n.Contains("debug") || n.Contains("writers") || n.Contains("options screen")) go.SetActive(false);
        }
        var cam = FirstCamera();
        if (cam == null) { Debug.LogError("No camera for " + outName); return; }
        cam.gameObject.SetActive(true); cam.enabled = true;
        var rt = new RenderTexture(1280,720,24,RenderTextureFormat.ARGB32);
        cam.targetTexture = rt; cam.Render(); RenderTexture.active = rt;
        var tex = new Texture2D(1280,720,TextureFormat.RGBA32,false); tex.ReadPixels(new Rect(0,0,1280,720),0,0); tex.Apply();
        File.WriteAllBytes(Path.Combine(Directory.GetParent(Application.dataPath).FullName,outName), tex.EncodeToPNG());
        cam.targetTexture=null; RenderTexture.active=null; Object.DestroyImmediate(rt);
        Debug.Log("[OFFROOT] rendered " + outName + " target=" + (target?target.name:"null"));
    }

    static GameObject Find(string name)
    {
        foreach (var go in Object.FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None)) if (go.name == name) return go;
        return null;
    }
    static Camera FirstCamera()
    {
        foreach (var c in Object.FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None)) return c;
        return null;
    }
}
