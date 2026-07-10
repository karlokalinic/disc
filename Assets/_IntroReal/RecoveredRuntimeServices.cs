using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;

public static class RecoveredRuntimeServices
{
    static readonly Dictionary<string, AssetBundle> BundlesByPath = new Dictionary<string, AssetBundle>();

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void Install()
    {
        var existing = Object.FindAnyObjectByType<RecoveredRuntimeServicesHost>();
        if (existing != null) return;
        var go = new GameObject("RecoveredRuntimeServices");
        Object.DontDestroyOnLoad(go);
        go.AddComponent<RecoveredRuntimeServicesHost>();
    }

    public static AssetBundle LoadBundleCached(string path)
    {
        if (string.IsNullOrEmpty(path)) return null;
        string full = Path.GetFullPath(path).Replace('\\', '/').ToLowerInvariant();
        if (BundlesByPath.TryGetValue(full, out var cached) && cached != null) return cached;

        string file = Path.GetFileName(path).ToLowerInvariant();
        string withoutExt = Path.GetFileNameWithoutExtension(path).ToLowerInvariant();
        foreach (var loaded in AssetBundle.GetAllLoadedAssetBundles())
        {
            if (loaded == null) continue;
            string loadedName = (loaded.name ?? "").ToLowerInvariant();
            if (loadedName == file || loadedName == withoutExt || file.StartsWith(loadedName) || withoutExt.StartsWith(loadedName))
            {
                BundlesByPath[full] = loaded;
                return loaded;
            }
        }

        AssetBundle bundle = null;
        try { bundle = AssetBundle.LoadFromFile(path); }
        catch { bundle = null; }
        if (bundle != null) BundlesByPath[full] = bundle;
        return bundle;
    }

    public static void EnsureSingleEventSystem()
    {
        var systems = Object.FindObjectsByType<EventSystem>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        EventSystem keeper = EventSystem.current;
        if (keeper == null && systems.Length > 0) keeper = systems[0];
        for (int i = 0; i < systems.Length; i++)
        {
            var es = systems[i];
            if (es == null || es == keeper) continue;
            Object.Destroy(es.gameObject);
        }
    }
}

public class RecoveredRuntimeServicesHost : MonoBehaviour
{
    void Awake()
    {
        RecoveredRuntimeServices.EnsureSingleEventSystem();
    }

    void LateUpdate()
    {
        RecoveredRuntimeServices.EnsureSingleEventSystem();
    }
}
