using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public static class BuildWhirlingLobby
{
    const float BackW = 13f;

    static Material Lit(Color c){ var s=Shader.Find("Standard")??Shader.Find("Legacy Shaders/Diffuse"); var m=new Material(s); if(m.HasProperty("_Color"))m.color=c; return m; }
    static Material Unlit(Texture t){ var s=Shader.Find("Unlit/Texture")??Shader.Find("Sprites/Default"); var m=new Material(s); m.mainTexture=t; return m; }

    public static void Build()
    {
        var log = new System.Text.StringBuilder(); void L(string s){ log.AppendLine(s); Debug.Log("[LOBBY] "+s); }
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        var tex = AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Texture2D/WhirlingF1.png");
        var back = GameObject.CreatePrimitive(PrimitiveType.Quad); back.name="Backdrop"; Object.DestroyImmediate(back.GetComponent<Collider>());
        back.transform.position = Vector3.zero; back.transform.localScale = new Vector3(BackW, BackW, 1f);
        back.GetComponent<Renderer>().sharedMaterial = tex != null ? Unlit(tex) : Lit(Color.gray);
        L("backdrop WhirlingF1 " + (tex != null ? tex.width+"x"+tex.height : "missing"));

        var harry = AddCharacter("Harry", "TequillaSunset.prefab", new Vector3(-2.9f, -2.35f, -1.2f), 1.12f, L);
        var garte = AddCharacter("Garte", "Garte.prefab", new Vector3(1.65f, 0.45f, -1.2f), 1.05f, L);
        var kim = AddCharacter("Kim", "Kim.prefab", new Vector3(-1.15f, -1.05f, -1.2f), 1.02f, L);
        var lena = AddCharacter("Lena", "Lena.prefab", new Vector3(3.65f, -2.05f, -1.2f), 1.0f, L);

        var ctrl = new GameObject("WhirlingLobbyController").AddComponent<WhirlingLobbyController>();
        ctrl.database = AssetDatabase.LoadAssetAtPath<PixelCrushers.DialogueSystem.DialogueDatabase>("Assets/Dialogue Databases/Disco Elysium.asset");
        ctrl.harry = harry != null ? harry.transform : null;
        ctrl.garte = garte != null ? garte.transform : null;
        ctrl.kim = kim != null ? kim.transform : null;
        ctrl.lena = lena != null ? lena.transform : null;

        var light = new GameObject("LobbyKeyLight").AddComponent<Light>();
        light.type = LightType.Directional; light.intensity = 0.9f; light.color = new Color(1f,0.94f,0.84f); light.transform.rotation = Quaternion.Euler(45f,-20f,0f);

        string outPath="Assets/_IntroReal/WhirlingLobbyReal.unity";
        EditorSceneManager.SaveScene(scene,outPath); L("saved "+outPath);
        var list = new List<EditorBuildSettingsScene>(); foreach(var s in EditorBuildSettings.scenes) if(s.path!=outPath) list.Add(s); list.Add(new EditorBuildSettingsScene(outPath,true)); EditorBuildSettings.scenes=list.ToArray();
        File.WriteAllText(Path.Combine(Directory.GetParent(Application.dataPath).FullName,"lobby_scene_result.txt"),log.ToString());
    }

    static GameObject AddCharacter(string label, string prefabName, Vector3 pos, float scale, System.Action<string> log)
    {
        var prefab=AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject/"+prefabName);
        GameObject go = prefab!=null ? (GameObject)PrefabUtility.InstantiatePrefab(prefab) : GameObject.CreatePrimitive(PrimitiveType.Capsule);
        if(go==null) return null;
        go.name=label; go.transform.position=pos; go.transform.localScale=Vector3.one*scale; go.transform.rotation=Quaternion.Euler(0f,180f,0f);
        DisableUnsafe(go); Brighten(go,1.12f); log(label+" prefab="+prefabName); return go;
    }

    static void DisableUnsafe(GameObject root)
    {
        foreach(var cloth in root.GetComponentsInChildren<Cloth>(true)) cloth.enabled=false;
        foreach(var animator in root.GetComponentsInChildren<Animator>(true)){ animator.avatar=null; animator.runtimeAnimatorController=null; animator.enabled=false; }
    }

    static void Brighten(GameObject root,float f)
    {
        foreach(var r in root.GetComponentsInChildren<Renderer>(true))
        {
            if(r==null||r.sharedMaterial==null) continue;
            var m=new Material(r.sharedMaterial); if(m.HasProperty("_Color")) m.color=m.color*f; r.sharedMaterial=m;
        }
    }

    public static void ValidateVisual()
    {
        EditorSceneManager.OpenScene("Assets/_IntroReal/WhirlingLobbyReal.unity", OpenSceneMode.Single);
        var cam=Object.FindAnyObjectByType<Camera>(); if(cam==null){ var g=new GameObject("LobbyValidationCamera"); cam=g.AddComponent<Camera>(); }
        cam.clearFlags=CameraClearFlags.SolidColor; cam.backgroundColor=Color.black; cam.orthographic=true; cam.orthographicSize=6.7f; cam.transform.position=new Vector3(0,0,-18); cam.transform.rotation=Quaternion.identity;
        int w=1280,h=720; var rt=new RenderTexture(w,h,24); cam.targetTexture=rt; cam.Render(); RenderTexture.active=rt; var img=new Texture2D(w,h,TextureFormat.RGB24,false); img.ReadPixels(new Rect(0,0,w,h),0,0); img.Apply(); cam.targetTexture=null; RenderTexture.active=null;
        var px=img.GetPixels(); float lum=0,mag=0; foreach(var c in px){lum+=(c.r+c.g+c.b)/3f; if(c.r>0.6f&&c.b>0.6f&&c.g<0.3f)mag++;} lum/=px.Length; mag/=px.Length;
        string root=Directory.GetParent(Application.dataPath).FullName; File.WriteAllBytes(Path.Combine(root,"lobby_visual_validation.png"),img.EncodeToPNG()); File.WriteAllText(Path.Combine(root,"lobby_visual_validation.txt"),"avgLum="+lum.ToString("0.000")+"\nmagentaFrac="+mag.ToString("0.0000")); Object.DestroyImmediate(rt); Object.DestroyImmediate(img);
    }
}
