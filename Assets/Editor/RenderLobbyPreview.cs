// TEMP editor utility - renders the original Lobby scene camera to a PNG for verification.
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class RenderLobbyPreview
{
    public static void Run()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Lobby.unity", OpenSceneMode.Single);
        var cams = Object.FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        var cam = cams.Length > 0 ? cams[0] : null;
        if (cam == null) { Debug.LogError("No camera in Lobby"); return; }
        cam.gameObject.SetActive(true);
        cam.enabled = true;
        var rt = new RenderTexture(1280, 720, 24, RenderTextureFormat.ARGB32);
        cam.targetTexture = rt;
        cam.Render();
        RenderTexture.active = rt;
        var tex = new Texture2D(1280, 720, TextureFormat.RGBA32, false);
        tex.ReadPixels(new Rect(0, 0, 1280, 720), 0, 0);
        tex.Apply();
        File.WriteAllBytes(Path.Combine(Directory.GetParent(Application.dataPath).FullName, "lobby_preview.png"), tex.EncodeToPNG());
        cam.targetTexture = null;
        RenderTexture.active = null;
        Object.DestroyImmediate(rt);
        Debug.Log("[LOBBY] rendered original Lobby preview");
    }
}
