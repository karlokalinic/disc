// ShowcaseController — drives the 3DShowcase gallery scene: a cinematic museum turntable of the
// real Disco Elysium characters and 3D objects (full meshes/materials/textures). It orbits a
// camera around the focused exhibit, slowly turntable-rotates every exhibit, adds a gentle idle
// sway so figures feel alive, and lets the player walk the gallery with the keyboard/mouse.
// All content is the game's own extracted assets; this file is only presentation glue.
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowcaseController : MonoBehaviour
{
    [System.Serializable]
    public class Exhibit
    {
        public Transform pedestal;   // the rotating turntable root
        public Transform model;      // the character/object under the pedestal
        public string label = "";
        public string subtitle = "";
        public float baseY;          // model local Y for idle sway
    }

    public List<Exhibit> exhibits = new List<Exhibit>();
    public Camera cam;
    public Light keyLight;

    [Header("Camera")]
    public float orbitDistance = 3.2f;
    public float orbitHeight = 1.15f;
    public float turntableSpeed = 12f;     // deg/sec exhibits spin
    public float focusLerp = 4f;

    int _focus = 0;
    float _yaw = 0f;
    float _pitch = 8f;
    float _dist = 3.2f;
    Vector3 _camVel;
    float _time;

    void Start()
    {
        if (cam == null) cam = Camera.main;
        _dist = orbitDistance;
        if (exhibits.Count > 0) _yaw = 0f;
    }

    void Update()
    {
        _time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("BootBlank");
            return;
        }

        // turntable + idle sway for every exhibit
        foreach (var e in exhibits)
        {
            if (e.pedestal != null)
                e.pedestal.Rotate(0f, turntableSpeed * Time.deltaTime, 0f, Space.World);
            if (e.model != null)
            {
                float sway = Mathf.Sin(_time * 1.3f + e.baseY) * 0.012f;
                var lp = e.model.localPosition; lp.y = e.baseY + sway; e.model.localPosition = lp;
            }
        }

        if (exhibits.Count == 0 || cam == null) return;

        // focus navigation
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.E))
            _focus = (_focus + 1) % exhibits.Count;
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Q))
            _focus = (_focus - 1 + exhibits.Count) % exhibits.Count;
        for (int i = 0; i < 9 && i < exhibits.Count; i++)
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) _focus = i;

        // mouse drag to look, scroll to zoom
        if (Input.GetMouseButton(0))
        {
            _yaw += Input.GetAxis("Mouse X") * 3f;
            _pitch = Mathf.Clamp(_pitch - Input.GetAxis("Mouse Y") * 2f, -10f, 45f);
        }
        else
        {
            _yaw += Time.deltaTime * 6f; // slow drift
        }
        _dist = Mathf.Clamp(_dist - Input.mouseScrollDelta.y * 0.4f, 1.4f, 6f);

        var target = exhibits[Mathf.Clamp(_focus, 0, exhibits.Count - 1)];
        Vector3 pivot = FocusPivot(target);

        Quaternion rot = Quaternion.Euler(_pitch, _yaw, 0f);
        Vector3 want = pivot + rot * new Vector3(0f, 0f, -_dist) + Vector3.up * orbitHeight;
        cam.transform.position = Vector3.SmoothDamp(cam.transform.position, want, ref _camVel, 1f / Mathf.Max(0.1f, focusLerp));
        cam.transform.rotation = Quaternion.Slerp(cam.transform.rotation,
            Quaternion.LookRotation((pivot + Vector3.up * orbitHeight) - cam.transform.position), Time.deltaTime * focusLerp);

        if (keyLight != null)
            keyLight.transform.rotation = Quaternion.Slerp(keyLight.transform.rotation,
                Quaternion.Euler(38f, _yaw + 30f, 0f), Time.deltaTime * 2f);
    }

    Vector3 FocusPivot(Exhibit e)
    {
        if (e == null || e.pedestal == null) return Vector3.zero;
        // aim at the visual centre of the exhibit's renderers
        var rends = e.pedestal.GetComponentsInChildren<Renderer>();
        if (rends.Length == 0) return e.pedestal.position + Vector3.up * 0.9f;
        Bounds b = rends[0].bounds;
        for (int i = 1; i < rends.Length; i++) b.Encapsulate(rends[i].bounds);
        return new Vector3(e.pedestal.position.x, b.center.y, e.pedestal.position.z);
    }

    GUIStyle _title, _name, _sub, _hint;
    void OnGUI()
    {
        if (exhibits.Count == 0) return;
        if (_title == null)
        {
            _title = new GUIStyle(GUI.skin.label){ fontSize = 30, fontStyle = FontStyle.Bold, normal = { textColor = new Color(0.92f,0.86f,0.62f) } };
            _name  = new GUIStyle(GUI.skin.label){ fontSize = 40, fontStyle = FontStyle.Bold, normal = { textColor = Color.white } };
            _sub   = new GUIStyle(GUI.skin.label){ fontSize = 20, normal = { textColor = new Color(0.8f,0.8f,0.8f) } };
            _hint  = new GUIStyle(GUI.skin.label){ fontSize = 16, normal = { textColor = new Color(0.7f,0.7f,0.7f) } };
        }
        var e = exhibits[Mathf.Clamp(_focus, 0, exhibits.Count - 1)];
        GUI.Label(new Rect(40, 30, 900, 44), "DISCO ELYSIUM — 3D SHOWCASE", _title);
        GUI.Label(new Rect(40, Screen.height - 150, 1200, 60), e.label, _name);
        GUI.Label(new Rect(40, Screen.height - 92, 1200, 34), e.subtitle, _sub);
        GUI.Label(new Rect(40, Screen.height - 44, 1400, 28),
            "[<-/->] or [A/D] cycle exhibits   [1-9] jump   drag mouse to orbit   scroll to zoom   [ESC] menu   " +
            (_focus + 1) + " / " + exhibits.Count, _hint);
    }
}
