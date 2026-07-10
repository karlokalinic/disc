using UnityEngine;

public class RootWorldTrigger : MonoBehaviour
{
    public RootWorldController controller;
    public string triggerKey;
    public string displayName;
    public bool oneShot = true;

    bool _fired;

    void OnTriggerEnter(Collider other)
    {
        if (_fired && oneShot) return;
        if (!other.CompareTag("Player")) return;
        if (controller == null) controller = FindAnyObjectByType<RootWorldController>();
        if (controller == null) return;
        _fired = true;
        controller.RegisterWorldTrigger(triggerKey, displayName);
    }
}