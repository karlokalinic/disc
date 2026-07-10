using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class KlaasjeSceneController : MonoBehaviour
{
    public DialogueDatabase database;
    public Transform harry;
    public Transform klaasje;
    public Transform shoe;

    Camera _cam;
    Canvas _bubbleCanvas;
    TMPro.TextMeshProUGUI _bubble;
    string _bubbleText = "";
    bool _hasShoe;
    readonly Dictionary<int, string> _actorNames = new Dictionary<int, string>();
    readonly HashSet<int> _playerActors = new HashSet<int>();
    Conversation _klaasjeConversation;
    DialogueEntry _activeEntry;
    readonly List<DialogueEntry> _choices = new List<DialogueEntry>();
    bool _dialogueOpen;
    string _speaker = "";
    string _line = "";
    float _smokeT;

    const float Speed = 3.2f;
    const float Z = -1.2f;

    void Start()
    {
        BuildCamera();
        BuildBubble();
        LoadDb();
        ShowBubble("Klaasje is outside. E / Space talks. The other shoe is on the balcony.");
    }

    void BuildCamera()
    {
        var camGO = new GameObject("KlaasjeCam");
        _cam = camGO.AddComponent<Camera>();
        camGO.AddComponent<AudioListener>();
        camGO.tag = "MainCamera";
        foreach (var c in FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None)) if (c != _cam) c.enabled = false;
        _cam.orthographic = true;
        _cam.orthographicSize = 6.2f;
        _cam.transform.position = new Vector3(0, 0, -18);
        _cam.transform.rotation = Quaternion.identity;
        _cam.clearFlags = CameraClearFlags.SolidColor;
        _cam.backgroundColor = Color.black;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = new Color(0.70f, 0.68f, 0.62f);
    }

    void BuildBubble()
    {
        var go = new GameObject("KlaasjeBubble", typeof(Canvas));
        _bubbleCanvas = go.GetComponent<Canvas>();
        _bubbleCanvas.renderMode = RenderMode.WorldSpace;
        var rt = (RectTransform)go.transform;
        rt.sizeDelta = new Vector2(420, 120);
        rt.localScale = Vector3.one * 0.006f;
        var bg = new GameObject("bg", typeof(RectTransform), typeof(CanvasRenderer), typeof(UnityEngine.UI.Image));
        bg.transform.SetParent(go.transform, false);
        bg.GetComponent<UnityEngine.UI.Image>().color = new Color(0.03f,0.03f,0.04f,0.86f);
        var br = (RectTransform)bg.transform; br.anchorMin = Vector2.zero; br.anchorMax = Vector2.one; br.offsetMin = Vector2.zero; br.offsetMax = Vector2.zero;
        var textGo = new GameObject("text", typeof(RectTransform), typeof(CanvasRenderer));
        textGo.transform.SetParent(go.transform, false);
        _bubble = textGo.AddComponent<TMPro.TextMeshProUGUI>();
        _bubble.fontSize = 28;
        _bubble.alignment = TMPro.TextAlignmentOptions.Center;
        _bubble.textWrappingMode = TMPro.TextWrappingModes.Normal;
        if (TMPro.TMP_Settings.defaultFontAsset != null) _bubble.font = TMPro.TMP_Settings.defaultFontAsset;
        var tr = _bubble.rectTransform; tr.anchorMin = Vector2.zero; tr.anchorMax = Vector2.one; tr.offsetMin = new Vector2(10,8); tr.offsetMax = new Vector2(-10,-8);
    }

    void LoadDb()
    {
        if (database == null) return;
        foreach (var actor in database.actors)
        {
            _actorNames[actor.id] = Field(actor.fields, "Name") ?? ("Actor " + actor.id);
            var isPlayer = Field(actor.fields, "IsPlayer");
            if (!string.IsNullOrEmpty(isPlayer) && isPlayer.Trim().Equals("True", System.StringComparison.OrdinalIgnoreCase)) _playerActors.Add(actor.id);
        }

        Conversation best = null; int score = 0;
        foreach (var conv in database.conversations)
        {
            var title = Field(conv.fields, "Title") ?? "";
            string t = title.ToLowerInvariant();
            int s = 0;
            if (t.Contains("klaasje")) s += 5;
            if (t.Contains("whirling")) s += 2;
            if (t.Contains("balcony")) s += 2;
            if (t.Contains("morning")) s += 1;
            if (s > score) { score = s; best = conv; }
        }
        _klaasjeConversation = best;
    }

    void Update()
    {
        if (harry == null) return;
        if (_dialogueOpen) { UpdateDialogue(); return; }

        Vector3 p = harry.position;
        Vector3 mv = Vector3.zero;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) mv.x -= 1f;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) mv.x += 1f;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) mv.y -= 1f;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) mv.y += 1f;
        p += Vector3.ClampMagnitude(mv, 1f) * Speed * Time.deltaTime;
        p.x = Mathf.Clamp(p.x, -5.7f, 5.7f);
        p.y = Mathf.Clamp(p.y, -3.55f, -1.55f);
        p.z = Z;
        harry.position = p;

        if (mv.sqrMagnitude > 0.001f) harry.rotation = Quaternion.Slerp(harry.rotation, Quaternion.Euler(0f, 180f, -mv.x * 4f), Time.deltaTime * 8f);

        AnimateSmoke();

        if (klaasje != null && Vector2.Distance(harry.position, klaasje.position) < 1.8f)
        {
            ShowBubble("Klaasje   [E / Space]");
            if (InteractPressed()) StartKlaasjeDialogue();
        }
        else if (Vector2.Distance(harry.position, new Vector3(-4.85f, -2.15f, Z)) < 1.35f)
        {
            ShowBubble("Downstairs lobby   [E / Space]");
            if (InteractPressed()) SceneManager.LoadScene("WhirlingLobbyReal");
        }
        else if (!_hasShoe && shoe != null && Vector2.Distance(harry.position, shoe.position) < 1.4f)
        {
            ShowBubble("Other shoe   [E / Space]");
            if (InteractPressed())
            {
                _hasShoe = true;
                shoe.gameObject.SetActive(false);
                PlayerPrefs.SetInt("recovered.klaasje_balcony.other_shoe", 1);
                PlayerPrefs.Save();
                ShowBubble("The other shoe. Shards of glass, still in the heel.");
            }
        }
        else ShowBubble("WASD move. Klaasje is by the window. The other shoe is near the balcony rail. Esc returns to room.");

        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("RoomReal");
    }

    void AnimateSmoke()
    {
        if (klaasje == null) return;
        _smokeT += Time.deltaTime;
        var smoke = GameObject.Find("KlaasjeSmoke");
        if (smoke != null)
        {
            smoke.transform.position = klaasje.position + new Vector3(0.38f + Mathf.Sin(_smokeT * 2f) * 0.03f, 1.55f + _smokeT % 1.0f * 0.45f, -0.2f);
            var r = smoke.GetComponent<Renderer>();
            if (r != null) r.enabled = Mathf.Sin(_smokeT * 8f) > -0.7f;
        }
    }

    bool InteractPressed() => Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return);

    void StartKlaasjeDialogue()
    {
        if (_klaasjeConversation == null || _klaasjeConversation.dialogueEntries == null || _klaasjeConversation.dialogueEntries.Count == 0)
        {
            _dialogueOpen = true;
            _speaker = "KLAASJE";
            _line = "You must be the police officer from room one.";
            _choices.Clear();
            return;
        }
        _dialogueOpen = true;
        DialogueEntry start = null;
        foreach (var e in _klaasjeConversation.dialogueEntries) if (e.id == 0 || e.isRoot) { start = e; break; }
        if (start == null) start = _klaasjeConversation.dialogueEntries[0];
        Follow(start);
    }

    void UpdateDialogue()
    {
        for (int i = 0; i < _choices.Count && i < 9; i++) if (Input.GetKeyDown(KeyCode.Alpha1 + i)) { Choose(_choices[i]); return; }
        if (_choices.Count == 0 && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)))
        {
            if (_activeEntry != null) Follow(_activeEntry);
            else _dialogueOpen = false;
        }
        if (Input.GetKeyDown(KeyCode.Backspace) || Input.GetKeyDown(KeyCode.Escape)) _dialogueOpen = false;
    }

    void Follow(DialogueEntry from)
    {
        ApplyScript(Field(from.fields, "userScript"));
        var next = Resolve(from);
        _choices.Clear();
        DialogueEntry line = null;
        foreach (var e in next)
        {
            if (_playerActors.Contains(ActorId(e))) _choices.Add(e);
            else if (line == null) line = e;
        }
        if (_choices.Count > 0) { _speaker = "YOU"; _line = "Choose."; _activeEntry = null; return; }
        if (line != null) { ShowLine(line); return; }
        _dialogueOpen = false;
    }

    List<DialogueEntry> Resolve(DialogueEntry from)
    {
        var list = new List<DialogueEntry>();
        if (from.outgoingLinks == null || _klaasjeConversation == null) return list;
        foreach (var l in from.outgoingLinks)
        {
            if (l.destinationConversationID != _klaasjeConversation.id) continue;
            foreach (var e in _klaasjeConversation.dialogueEntries) if (e.id == l.destinationDialogueID) { list.Add(e); break; }
        }
        return list;
    }

    void ShowLine(DialogueEntry e)
    {
        _activeEntry = e;
        _actorNames.TryGetValue(ActorId(e), out _speaker);
        if (string.IsNullOrEmpty(_speaker)) _speaker = "KLAASJE";
        _line = Clean(Field(e.fields, "Dialogue Text"));
        if (string.IsNullOrEmpty(_line)) Follow(e);
    }

    void Choose(DialogueEntry e)
    {
        _choices.Clear();
        _speaker = "YOU";
        _line = Clean(Field(e.fields, "Dialogue Text"));
        ApplyScript(Field(e.fields, "userScript"));
        _activeEntry = e;
    }

    void ApplyScript(string script)
    {
        if (string.IsNullOrEmpty(script)) return;
        int idx = script.IndexOf("SetVariableValue(\"", System.StringComparison.Ordinal);
        if (idx < 0) idx = script.IndexOf("XPTinySetBool(\"", System.StringComparison.Ordinal);
        if (idx < 0) return;
        int start = script.IndexOf('"', idx) + 1;
        int end = script.IndexOf('"', start);
        if (start > 0 && end > start)
        {
            string key = script.Substring(start, end - start);
            PlayerPrefs.SetInt("dialogue." + key, 1);
            PlayerPrefs.Save();
        }
    }

    static string Field(List<Field> fields, string title)
    {
        if (fields == null) return null;
        foreach (var f in fields) if (f != null && f.title == title) return f.value;
        return null;
    }

    static int ActorId(DialogueEntry e) { int.TryParse(Field(e.fields, "Actor"), out int id); return id; }

    static string Clean(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        while (true)
        {
            int a = s.IndexOf('['); int b = a >= 0 ? s.IndexOf(']', a) : -1;
            if (a < 0 || b < 0) break;
            s = s.Remove(a, b - a + 1);
        }
        while (true)
        {
            int a = s.IndexOf('<'); int b = a >= 0 ? s.IndexOf('>', a) : -1;
            if (a < 0 || b < 0) break;
            s = s.Remove(a, b - a + 1);
        }
        return s.Trim();
    }

    void ShowBubble(string s)
    {
        _bubbleText = s;
        if (_bubbleCanvas == null || _bubble == null) return;
        _bubble.text = s;
        Transform anchor = _dialogueOpen && klaasje != null ? klaasje : harry;
        if (anchor != null) _bubbleCanvas.transform.position = anchor.position + new Vector3(0, 2.0f, -0.3f);
        _bubbleCanvas.transform.rotation = Quaternion.identity;
        _bubbleCanvas.gameObject.SetActive(!string.IsNullOrEmpty(s));
    }

    void OnGUI()
    {
        if (!_dialogueOpen) return;
        GUI.Box(new Rect(Screen.width * 0.52f, 120, Screen.width * 0.45f, Screen.height - 240), "");
        GUI.Label(new Rect(Screen.width * 0.54f, 146, Screen.width * 0.39f, 28), (_speaker ?? "").ToUpperInvariant());
        GUI.Label(new Rect(Screen.width * 0.54f, 184, Screen.width * 0.39f, 160), _line ?? "");
        for (int i = 0; i < _choices.Count && i < 9; i++)
        {
            string label = (i + 1) + ". " + Clean(Field(_choices[i].fields, "Dialogue Text"));
            if (GUI.Button(new Rect(Screen.width * 0.54f, 370 + i * 40, Screen.width * 0.39f, 32), label)) Choose(_choices[i]);
        }
        if (_choices.Count == 0) GUI.Label(new Rect(Screen.width * 0.54f, Screen.height - 154, Screen.width * 0.39f, 28), "E / Space / Enter continues. Backspace closes.");
    }
}
