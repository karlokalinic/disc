// FlowRuntimeBootstrap — guarantees the restored menu/creator starts even if a manually-created
// scene MonoBehaviour binding fails in the player. This is glue only; FlowController still loads
// real exported UI/portrait assets and continues into the real intro/room scenes.
using UnityEngine;

public static class FlowRuntimeBootstrap
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Boot()
    {
        if (Object.FindAnyObjectByType<RestoredFlowController>() != null) return;
        var go = new GameObject("FlowRuntimeBootstrap");
        Object.DontDestroyOnLoad(go);
        go.AddComponent<RestoredFlowController>();
        Debug.Log("[FLOWBOOT] Created FlowController runtime bootstrap");
    }
}
