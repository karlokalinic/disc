using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class WhirlingLobbyController : MonoBehaviour
{
    public DialogueDatabase database;
    public Transform harry;
    public Transform kim;
    public Transform garte;
    public Transform lena;

    Camera _cam;
    Canvas _bubbleCanvas;
    TMPro.TextMeshProUGUI _bubble;
    readonly Dictionary<int, string> _actorNames = new Dictionary<int, string>();
    readonly HashSet<int> _playerActors = new HashSet<int>();
    Conversation _conversation;
    DialogueEntry _activeEntry;
    readonly List<DialogueEntry> _choices = new List<DialogueEntry>();
    bool _dialogueOpen;
    string _speaker = "";
    string _line = "";
    Transform _dialogueTarget;

    const float Speed = 3.35f;
    const float Z = -1.2f;

    void Start()
    {
        BuildCamera();
        BuildBubble();
        LoadDb();
        ShowBubble("Whirling-in-Rags. Talk to Garte, Kim, or Lena. Esc returns upstairs.", harry);
    }

    void BuildCamera()
    {
        var camGO = new GameObject("LobbyCam");
        _cam = camGO.AddComponent<Camera>();
        camGO.AddComponent<AudioListener>();
        camGO.tag = "MainCamera";
        foreach (var c in FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None)) if (c != _cam) c.enabled = false;
        _cam.orthographic = true;
        _cam.orthographicSize = 6.7f;
        _cam.transform.position = new Vector3(0f, 0f, -18f);
        _cam.transform.rotation = Quaternion.identity;
        _cam.clearFlags = CameraClearFlags.SolidColor;
        _cam.backgroundColor = Color.black;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = new Color(0.72f,0.68f,0.60f);
    }

    void BuildBubble()
    {
        var go = new GameObject("LobbyBubble", typeof(Canvas));
        _bubbleCanvas = go.GetComponent<Canvas>();
        _bubbleCanvas.renderMode = RenderMode.WorldSpace;
        var rt = (RectTransform)go.transform; rt.sizeDelta = new Vector2(460, 122); rt.localScale = Vector3.one * 0.006f;
        var bg = new GameObject("bg", typeof(RectTransform), typeof(CanvasRenderer), typeof(UnityEngine.UI.Image));
        bg.transform.SetParent(go.transform, false); bg.GetComponent<UnityEngine.UI.Image>().color = new Color(0.03f,0.03f,0.04f,0.86f);
        var br = (RectTransform)bg.transform; br.anchorMin = Vector2.zero; br.anchorMax = Vector2.one; br.offsetMin = Vector2.zero; br.offsetMax = Vector2.zero;
        var textGo = new GameObject("text", typeof(RectTransform), typeof(CanvasRenderer));
        textGo.transform.SetParent(go.transform, false);
        _bubble = textGo.AddComponent<TMPro.TextMeshProUGUI>();
        _bubble.fontSize = 28; _bubble.alignment = TMPro.TextAlignmentOptions.Center; _bubble.textWrappingMode = TMPro.TextWrappingModes.Normal;
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
        p.x = Mathf.Clamp(p.x, -5.8f, 5.8f); p.y = Mathf.Clamp(p.y, -4.55f, 4.55f); p.z = Z;
        harry.position = p;
        if (mv.sqrMagnitude > 0.001f) harry.rotation = Quaternion.Slerp(harry.rotation, Quaternion.Euler(0f, 180f, -mv.x * 4f), Time.deltaTime * 8f);

        Transform target = null; string label = "";
        if (garte != null && Vector2.Distance(harry.position, garte.position) < 1.6f) { target = garte; label = "Garte / barman"; }
        else if (kim != null && Vector2.Distance(harry.position, kim.position) < 1.6f) { target = kim; label = "Kim Kitsuragi"; }
        else if (lena != null && Vector2.Distance(harry.position, lena.position) < 1.6f) { target = lena; label = "Lena"; }

        if (target != null)
        {
            ShowBubble(label + "   [E / Space]", target);
            if (InteractPressed()) StartConversation(label, target);
        }
        else ShowBubble("Lobby downstairs. Garte is at the bar, Kim waits nearby, Lena is by the wheelchair table. Esc upstairs.", harry);

        if (Input.GetKeyDown(KeyCode.Escape)) SceneManager.LoadScene("KlaasjeBalconyReal");
    }

    bool InteractPressed() => Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return);

    void StartConversation(string label, Transform target)
    {
        _dialogueTarget = target;
        _conversation = FindConversation(label);
        _dialogueOpen = true;
        _choices.Clear();
        if (_conversation == null || _conversation.dialogueEntries == null || _conversation.dialogueEntries.Count == 0)
        {
            _speaker = label.ToUpperInvariant();
            _line = label.Contains("Garte") ? "The cafeteria manager eyes you from behind the counter." : label.Contains("Kim") ? "The lieutenant adjusts his glasses and waits." : "The woman in the wheelchair looks up with patient concern.";
            _activeEntry = null;
            return;
        }
        DialogueEntry start = null;
        foreach (var e in _conversation.dialogueEntries) if (e.id == 0 || e.isRoot) { start = e; break; }
        if (start == null) start = _conversation.dialogueEntries[0];
        Follow(start);
    }

    Conversation FindConversation(string label)
    {
        if (database == null) return null;
        string a = label.ToLowerInvariant();
        Conversation best = null; int bestScore = 0;
        foreach (var conv in database.conversations)
        {
            string title = (Field(conv.fields, "Title") ?? "").ToLowerInvariant();
            int s = 0;
            if (a.Contains("garte") && title.Contains("garte")) s += 8;
            if (a.Contains("kim") && title.Contains("kim")) s += 8;
            if (a.Contains("lena") && title.Contains("lena")) s += 8;
            if (title.Contains("whirling")) s += 2;
            if (s > bestScore) { bestScore = s; best = conv; }
        }
        return bestScore >= 8 ? best : null;
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
        var next = Resolve(from); _choices.Clear(); DialogueEntry line = null;
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
        if (from.outgoingLinks == null || _conversation == null) return list;
        foreach (var l in from.outgoingLinks)
        {
            if (l.destinationConversationID != _conversation.id) continue;
            foreach (var e in _conversation.dialogueEntries) if (e.id == l.destinationDialogueID) { list.Add(e); break; }
        }
        return list;
    }

    void ShowLine(DialogueEntry e)
    {
        _activeEntry = e; _actorNames.TryGetValue(ActorId(e), out _speaker); if (string.IsNullOrEmpty(_speaker)) _speaker = "SOURCE";
        _line = Clean(Field(e.fields, "Dialogue Text")); if (string.IsNullOrEmpty(_line)) Follow(e);
    }

    void Choose(DialogueEntry e)
    {
        _choices.Clear(); _speaker = "YOU"; _line = Clean(Field(e.fields, "Dialogue Text")); ApplyScript(Field(e.fields, "userScript")); _activeEntry = e;
    }

    void ApplyScript(string script)
    {
        if (string.IsNullOrEmpty(script)) return;
        int idx = script.IndexOf("SetVariableValue(\"", System.StringComparison.Ordinal); if (idx < 0) idx = script.IndexOf("XPTinySetBool(\"", System.StringComparison.Ordinal); if (idx < 0) return;
        int start = script.IndexOf('"', idx) + 1; int end = script.IndexOf('"', start);
        if (start > 0 && end > start) { PlayerPrefs.SetInt("dialogue." + script.Substring(start, end - start), 1); PlayerPrefs.Save(); }
    }

    static string Field(List<Field> fields, string title) { if (fields == null) return null; foreach (var f in fields) if (f != null && f.title == title) return f.value; return null; }
    static int ActorId(DialogueEntry e) { int.TryParse(Field(e.fields, "Actor"), out int id); return id; }
    static string Clean(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        while (true) { int a = s.IndexOf('['); int b = a >= 0 ? s.IndexOf(']', a) : -1; if (a < 0 || b < 0) break; s = s.Remove(a, b - a + 1); }
        while (true) { int a = s.IndexOf('<'); int b = a >= 0 ? s.IndexOf('>', a) : -1; if (a < 0 || b < 0) break; s = s.Remove(a, b - a + 1); }
        return s.Trim();
    }

    void ShowBubble(string s, Transform anchor)
    {
        if (_bubbleCanvas == null || _bubble == null) return;
        _bubble.text = s;
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
