using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RootWorldController : MonoBehaviour
{
    public DialogueDatabase database;
    public TextAsset customDialogueJson;
    public Transform player;
    public Transform kim;
    public Transform klaasje;
    public RuntimeAnimatorController playerController;
    public Camera worldCamera;
    public bool preferCustomDialogue;
    public Texture2D kimPortrait;
    public Texture2D klaasjePortrait;
    public Texture2D worldMapTexture;

    CharacterController _controller;
    Animator _animator;
    bool _animHasForward;
    float _animForward;
    bool _hasWalkTarget;
    Vector3 _walkTarget;
    Vector3 _lastMove = Vector3.forward;
    readonly Dictionary<int, string> _actorNames = new Dictionary<int, string>();
    readonly HashSet<int> _playerActors = new HashSet<int>();
    readonly List<DialogueEntry> _choices = new List<DialogueEntry>();
    readonly List<CustomChoice> _visibleCustomChoices = new List<CustomChoice>();
    readonly Dictionary<string, CustomConversation> _customConversations = new Dictionary<string, CustomConversation>();
    DialogueEntry _activeEntry;
    Conversation _activeConversation;
    CustomConversation _activeCustomConversation;
    CustomNode _activeCustomNode;
    RootWorldTalkTarget _pendingTalkTarget;
    RootWorldTalkTarget _activeTalkTarget;
    bool _dialogueOpen;
    bool _mapOpen;
    bool _databaseReady;
    string _speaker = "";
    string _line = "";
    string _hint = "Click the floor to walk. Hold Shift to run. Click Kim or Klaasje to talk. Press M for the world map.";
    Texture2D _darkTexture;
    Texture2D _panelTexture;
    Texture2D _redTexture;
    Texture2D _goldTexture;
    GUIStyle _hintStyle;
    GUIStyle _panelStyle;
    GUIStyle _speakerStyle;
    GUIStyle _lineStyle;
    GUIStyle _choiceStyle;
    GUIStyle _smallStyle;

    const float WalkSpeed = 3.2f;
    const float RunSpeed = 5.6f;
    const float ArriveDistance = 0.18f;
    const float TalkDistance = 2.25f;

    [System.Serializable]
    class CustomDialogueBook
    {
        public CustomConversation[] conversations;
    }

    [System.Serializable]
    class CustomConversation
    {
        public string targetKey;
        public CustomNode[] nodes;
    }

    [System.Serializable]
    class CustomNode
    {
        public string id;
        public string speaker;
        public string text;
        public CustomChoice[] choices;
    }

    [System.Serializable]
    class CustomChoice
    {
        public string text;
        public string next;
        public string flag;
        public string requiresFlag;
        public string blockedByFlag;
        public string unlockLocation;
        public string setsObjective;
        public string checkSkill;
        public int checkDifficulty;
        public string successNext;
        public string failureNext;
        public string successFlag;
        public string failureFlag;
    }

    void Start()
    {
        SetupPlayer();
        SetupCamera();
        BuildGuiStyles();
        LoadCustomDialogue();
        EnsureDatabaseReady();
        RestoredGameState.UnlockLocation("root");
        RestoredGameState.UnlockLocation("room");
        RestoredGameState.UnlockLocation("lobby");
        RegisterVisit("root_world");
    }

    void SetupPlayer()
    {
        if (player == null) return;
        player.gameObject.tag = "Player";
        _controller = player.GetComponent<CharacterController>();
        if (_controller == null) _controller = player.gameObject.AddComponent<CharacterController>();
        _controller.height = 1.85f;
        _controller.radius = 0.34f;
        _controller.center = new Vector3(0f, 0.92f, 0f);

        foreach (var cloth in player.GetComponentsInChildren<Cloth>(true)) cloth.enabled = false;
        _animator = player.GetComponent<Animator>();
        if (_animator == null) _animator = player.gameObject.AddComponent<Animator>();
        _animator.avatar = null;
        _animator.applyRootMotion = false;
        _animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        if (playerController != null) _animator.runtimeAnimatorController = playerController;
        _animator.enabled = _animator.runtimeAnimatorController != null;
        _animHasForward = false;
        if (_animator.enabled)
        {
            foreach (var parameter in _animator.parameters)
            {
                if (parameter.name == "Forward" && parameter.type == AnimatorControllerParameterType.Float)
                {
                    _animHasForward = true;
                    break;
                }
            }
            if (_animHasForward) _animator.Play("Player Movement", 0, 0f);
        }
    }

    void SetupCamera()
    {
        if (worldCamera == null) worldCamera = Camera.main;
        if (worldCamera == null)
        {
            var cameraObject = new GameObject("RootWorldCamera");
            worldCamera = cameraObject.AddComponent<Camera>();
            cameraObject.AddComponent<AudioListener>();
        }
        worldCamera.tag = "MainCamera";
        worldCamera.orthographic = true;
        worldCamera.orthographicSize = 5.9f;
        worldCamera.nearClipPlane = 0.05f;
        worldCamera.farClipPlane = 120f;
        worldCamera.clearFlags = CameraClearFlags.SolidColor;
        worldCamera.backgroundColor = new Color(0.025f, 0.026f, 0.027f);
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = new Color(0.74f, 0.70f, 0.62f);
    }

    void BuildGuiStyles()
    {
        _darkTexture = Solid(new Color(0.010f, 0.010f, 0.012f, 0.88f));
        _panelTexture = Solid(new Color(0.025f, 0.022f, 0.020f, 0.92f));
        _redTexture = Solid(new Color(0.34f, 0.035f, 0.025f, 0.94f));
        _goldTexture = Solid(new Color(0.74f, 0.58f, 0.30f, 0.92f));

        _hintStyle = new GUIStyle(GUI.skin.label) { fontSize = 18, wordWrap = true, normal = { textColor = new Color(0.88f, 0.82f, 0.68f) } };
        _panelStyle = new GUIStyle(GUI.skin.box) { normal = { background = _panelTexture, textColor = new Color(0.84f, 0.72f, 0.48f) } };
        _speakerStyle = new GUIStyle(GUI.skin.label) { fontSize = 18, fontStyle = FontStyle.Bold, normal = { textColor = new Color(0.86f, 0.64f, 0.38f) } };
        _lineStyle = new GUIStyle(GUI.skin.label) { fontSize = 19, wordWrap = true, richText = true, normal = { textColor = new Color(0.92f, 0.90f, 0.82f) } };
        _choiceStyle = new GUIStyle(GUI.skin.button) { fontSize = 16, alignment = TextAnchor.MiddleLeft, wordWrap = true, normal = { background = _redTexture, textColor = new Color(0.98f, 0.90f, 0.82f) }, hover = { background = _goldTexture, textColor = Color.black } };
        _smallStyle = new GUIStyle(GUI.skin.label) { fontSize = 14, wordWrap = true, normal = { textColor = new Color(0.70f, 0.66f, 0.56f) } };
    }

    Texture2D Solid(Color color)
    {
        var tex = new Texture2D(1, 1, TextureFormat.RGBA32, false);
        tex.hideFlags = HideFlags.HideAndDontSave;
        tex.SetPixel(0, 0, color);
        tex.Apply();
        return tex;
    }

    void LoadCustomDialogue()
    {
        _customConversations.Clear();
        if (customDialogueJson == null || string.IsNullOrEmpty(customDialogueJson.text)) return;
        var book = JsonUtility.FromJson<CustomDialogueBook>(customDialogueJson.text);
        if (book == null || book.conversations == null) return;
        foreach (var conversation in book.conversations)
        {
            if (conversation == null || string.IsNullOrEmpty(conversation.targetKey)) continue;
            _customConversations[conversation.targetKey.ToLowerInvariant()] = conversation;
        }
    }

    void Update()
    {
        if (worldCamera == null || player == null) return;
        if (Input.GetKeyDown(KeyCode.M)) _mapOpen = !_mapOpen;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_dialogueOpen) CloseDialogue();
            else if (_mapOpen) _mapOpen = false;
        }

        if (_dialogueOpen)
        {
            UpdateDialogueInput();
            UpdateCamera();
            UpdateAnimator(0f);
            return;
        }

        ReadClick();
        UpdateMovement();
        UpdateCamera();
        UpdateNearbyPrompt();
    }

    void ReadClick()
    {
        if (!Input.GetMouseButtonDown(0) || _mapOpen) return;
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) return;
        Ray ray = worldCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 200f, ~0, QueryTriggerInteraction.Ignore))
        {
            var talkTarget = hit.collider.GetComponentInParent<RootWorldTalkTarget>();
            if (talkTarget != null)
            {
                _pendingTalkTarget = talkTarget;
                _walkTarget = TalkApproachPoint(talkTarget.transform);
                _hasWalkTarget = true;
                return;
            }
            _pendingTalkTarget = null;
            _walkTarget = hit.point;
            _walkTarget.y = player.position.y;
            _hasWalkTarget = true;
        }
    }

    Vector3 TalkApproachPoint(Transform target)
    {
        Vector3 direction = player.position - target.position;
        direction.y = 0f;
        if (direction.sqrMagnitude < 0.01f) direction = -target.forward;
        return target.position + direction.normalized * 1.35f;
    }

    void UpdateMovement()
    {
        Vector3 input = ReadMoveInput();
        bool running = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        if (input.sqrMagnitude > 0.001f)
        {
            _hasWalkTarget = false;
            _pendingTalkTarget = null;
        }
        else if (_hasWalkTarget)
        {
            Vector3 toTarget = _walkTarget - player.position;
            toTarget.y = 0f;
            if (toTarget.magnitude <= ArriveDistance)
            {
                _hasWalkTarget = false;
                input = Vector3.zero;
                if (_pendingTalkTarget != null && IsCloseEnoughToTalk(_pendingTalkTarget)) StartConversation(_pendingTalkTarget);
                _pendingTalkTarget = null;
            }
            else input = toTarget.normalized;
        }

        if (input.sqrMagnitude > 0.001f)
        {
            input.Normalize();
            _lastMove = input;
            float speed = running ? RunSpeed : WalkSpeed;
            if (_controller != null) _controller.Move(input * speed * Time.deltaTime);
            else player.position += input * speed * Time.deltaTime;
            player.rotation = Quaternion.Slerp(player.rotation, Quaternion.LookRotation(input, Vector3.up), Time.deltaTime * 10f);
        }
        UpdateAnimator(input.sqrMagnitude > 0.001f ? (running ? 2f : 1f) : 0f);
    }

    Vector3 ReadMoveInput()
    {
        Vector3 forward = Vector3.ProjectOnPlane(worldCamera.transform.forward, Vector3.up).normalized;
        Vector3 right = Vector3.ProjectOnPlane(worldCamera.transform.right, Vector3.up).normalized;
        Vector3 input = Vector3.zero;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) input += forward;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) input -= forward;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) input += right;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) input -= right;
        return Vector3.ClampMagnitude(input, 1f);
    }

    void UpdateCamera()
    {
        Vector3 focus = player.position + Vector3.up * 1.2f;
        worldCamera.transform.position = Vector3.Lerp(worldCamera.transform.position, focus + new Vector3(0f, 9.2f, -9.4f), Time.deltaTime * 6f);
        worldCamera.transform.rotation = Quaternion.Slerp(worldCamera.transform.rotation, Quaternion.Euler(47f, 0f, 0f), Time.deltaTime * 8f);
    }

    void UpdateAnimator(float targetForward)
    {
        if (_animator == null || !_animator.enabled || !_animHasForward) return;
        _animForward = Mathf.MoveTowards(_animForward, targetForward, Time.deltaTime * 5f);
        _animator.SetFloat("Forward", _animForward);
    }

    void UpdateNearbyPrompt()
    {
        RootWorldTalkTarget nearest = null;
        float best = TalkDistance;
        foreach (var target in FindObjectsByType<RootWorldTalkTarget>(FindObjectsInactive.Exclude))
        {
            float distance = Vector3.Distance(player.position, target.transform.position);
            if (distance < best)
            {
                best = distance;
                nearest = target;
            }
        }
        if (nearest != null)
        {
            _hint = "Click " + DisplayName(nearest) + " or press E to talk. Hold Shift to run. Press M for the world map.";
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) StartConversation(nearest);
        }
        else _hint = "Click the floor to walk. Hold Shift to run. Click Kim or Klaasje to talk. Press M for the world map.";
    }

    bool IsCloseEnoughToTalk(RootWorldTalkTarget target)
    {
        return target != null && Vector3.Distance(player.position, target.transform.position) <= TalkDistance + 0.5f;
    }

    void StartConversation(RootWorldTalkTarget target)
    {
        if (target == null) return;
        _activeTalkTarget = target;
        _dialogueOpen = true;
        _mapOpen = false;
        _choices.Clear();
        _activeEntry = null;
        _activeConversation = null;
        _activeCustomConversation = null;
        _activeCustomNode = null;
        RegisterVisit("talk_" + Key(target));

        _activeCustomConversation = FindCustomConversation(target);
        if (!preferCustomDialogue)
            _activeConversation = FindDatabaseConversation(target);

        if (_activeConversation != null && _activeConversation.dialogueEntries != null && _activeConversation.dialogueEntries.Count > 0)
        {
            DialogueEntry start = null;
            foreach (var entry in _activeConversation.dialogueEntries)
            {
                if (entry.id == 0 || entry.isRoot)
                {
                    start = entry;
                    break;
                }
            }
            FollowDialogue(start ?? _activeConversation.dialogueEntries[0]);
            return;
        }

        if (_activeCustomConversation != null)
        {
            ShowCustomNode("start");
            return;
        }

        _speaker = DisplayName(target);
        _line = "They are ready to talk, but no conversation binding was found yet.";
    }

    Conversation FindDatabaseConversation(RootWorldTalkTarget target)
    {
        EnsureDatabaseReady();
        if (database == null) return null;
        string key = Key(target);
        string display = DisplayName(target).ToLowerInvariant();
        Conversation best = null;
        int bestScore = 0;
        foreach (var conversation in database.conversations)
        {
            string title = (Field(conversation.fields, "Title") ?? "").ToLowerInvariant();
            int score = 0;
            if (title.Contains(key)) score += 10;
            if (!string.IsNullOrEmpty(display) && title.Contains(display)) score += 10;
            if (key == "kim" && title.Contains("kitsuragi")) score += 8;
            if (key == "klaasje" && title.Contains("oranje")) score += 4;
            if (title.Contains("whirling")) score += 2;
            if (title.Contains("balcony") || title.Contains("roof")) score += key == "klaasje" ? 3 : 0;
            if (score > bestScore)
            {
                bestScore = score;
                best = conversation;
            }
        }
        return bestScore >= 8 ? best : null;
    }

    CustomConversation FindCustomConversation(RootWorldTalkTarget target)
    {
        if (target == null) return null;
        _customConversations.TryGetValue(Key(target), out var conversation);
        return conversation;
    }

    void EnsureDatabaseReady()
    {
        if (_databaseReady || database == null) return;
        _databaseReady = true;
        _actorNames.Clear();
        _playerActors.Clear();
        foreach (var actor in database.actors)
        {
            string name = Field(actor.fields, "Name");
            _actorNames[actor.id] = string.IsNullOrEmpty(name) ? "Actor " + actor.id : name;
            string isPlayer = Field(actor.fields, "IsPlayer");
            if (!string.IsNullOrEmpty(isPlayer) && isPlayer.Trim().Equals("True", System.StringComparison.OrdinalIgnoreCase)) _playerActors.Add(actor.id);
        }
    }

    void UpdateDialogueInput()
    {
        for (int i = 0; i < _choices.Count && i < 9; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ChooseDialogue(_choices[i]);
                return;
            }
        }
        if (_activeCustomNode != null && _activeCustomNode.choices != null)
        {
            for (int i = 0; i < _visibleCustomChoices.Count && i < 9; i++)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                {
                    ChooseCustom(_visibleCustomChoices[i]);
                    return;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.E))
        {
            if (_activeEntry != null) FollowDialogue(_activeEntry);
            else CloseDialogue();
        }
    }

    void FollowDialogue(DialogueEntry from)
    {
        if (from == null)
        {
            CloseDialogue();
            return;
        }
        ApplyScript(Field(from.fields, "userScript"));
        var next = ResolveLinks(from);
        _choices.Clear();
        DialogueEntry line = null;
        foreach (var entry in next)
        {
            if (_playerActors.Contains(ActorId(entry))) _choices.Add(entry);
            else if (line == null) line = entry;
        }
        if (_choices.Count > 0)
        {
            _speaker = "YOU";
            _line = "Choose.";
            _activeEntry = null;
            return;
        }
        if (line != null)
        {
            ShowDialogueLine(line);
            return;
        }
        CloseDialogue();
    }

    List<DialogueEntry> ResolveLinks(DialogueEntry from)
    {
        var list = new List<DialogueEntry>();
        if (from == null || from.outgoingLinks == null || _activeConversation == null) return list;
        foreach (var link in from.outgoingLinks)
        {
            if (link.destinationConversationID != _activeConversation.id) continue;
            foreach (var entry in _activeConversation.dialogueEntries)
            {
                if (entry.id == link.destinationDialogueID)
                {
                    list.Add(entry);
                    break;
                }
            }
        }
        return list;
    }

    void ShowDialogueLine(DialogueEntry entry)
    {
        _activeEntry = entry;
        _actorNames.TryGetValue(ActorId(entry), out _speaker);
        if (string.IsNullOrEmpty(_speaker)) _speaker = DisplayName(_activeTalkTarget);
        _line = Clean(Field(entry.fields, "Dialogue Text"));
        if (string.IsNullOrEmpty(_line)) FollowDialogue(entry);
    }

    void ChooseDialogue(DialogueEntry entry)
    {
        _choices.Clear();
        _speaker = "YOU";
        _line = Clean(Field(entry.fields, "Dialogue Text"));
        ApplyScript(Field(entry.fields, "userScript"));
        PlayerPrefs.SetInt("rootworld.choice." + Key(_activeTalkTarget) + "." + entry.id, 1);
        PlayerPrefs.Save();
        RestoredGameState.SetFlag("choice." + Key(_activeTalkTarget) + "." + entry.id);
        Remember("Choice: " + Key(_activeTalkTarget) + " " + entry.id);
        _activeEntry = entry;
    }

    void ShowCustomNode(string nodeId)
    {
        if (_activeCustomConversation == null || _activeCustomConversation.nodes == null)
        {
            CloseDialogue();
            return;
        }
        foreach (var node in _activeCustomConversation.nodes)
        {
            if (node != null && node.id == nodeId)
            {
                _activeCustomNode = node;
                _speaker = string.IsNullOrEmpty(node.speaker) ? DisplayName(_activeTalkTarget) : node.speaker;
                _line = node.text ?? "";
                RebuildVisibleCustomChoices();
                return;
            }
        }
        CloseDialogue();
    }

    void RebuildVisibleCustomChoices()
    {
        _visibleCustomChoices.Clear();
        if (_activeCustomNode == null || _activeCustomNode.choices == null) return;
        foreach (var choice in _activeCustomNode.choices)
        {
            if (choice == null) continue;
            if (!string.IsNullOrEmpty(choice.requiresFlag) && !RestoredGameState.HasFlag(choice.requiresFlag)) continue;
            if (!string.IsNullOrEmpty(choice.blockedByFlag) && RestoredGameState.HasFlag(choice.blockedByFlag)) continue;
            _visibleCustomChoices.Add(choice);
        }
    }

    void ChooseCustom(CustomChoice choice)
    {
        if (choice == null) return;
        ApplyCustomChoiceEffects(choice);
        if (choice.checkDifficulty > 0 && !string.IsNullOrEmpty(choice.checkSkill))
        {
            ResolveCustomCheck(choice);
            return;
        }
        ShowCustomNode(choice.next);
    }

    void ApplyCustomChoiceEffects(CustomChoice choice)
    {
        if (!string.IsNullOrEmpty(choice.flag))
        {
            RestoredGameState.SetFlag(choice.flag);
            Remember("Choice: " + choice.flag);
        }
        UnlockLocations(choice.unlockLocation);
        if (!string.IsNullOrEmpty(choice.setsObjective)) RestoredGameState.SetObjective(choice.setsObjective);
    }

    void ResolveCustomCheck(CustomChoice choice)
    {
        int d1 = Random.Range(1, 7);
        int d2 = Random.Range(1, 7);
        int ability = AbilityValueForSkill(choice.checkSkill);
        int total = d1 + d2 + ability;
        bool success = (d1 == 6 && d2 == 6) || total >= choice.checkDifficulty;
        string resultFlag = success ? choice.successFlag : choice.failureFlag;
        if (!string.IsNullOrEmpty(resultFlag)) RestoredGameState.SetFlag(resultFlag);
        string line = choice.checkSkill.ToUpperInvariant() + " " + d1 + "+" + d2 + "+" + ability + " = " + total + " / " + choice.checkDifficulty + " -> " + (success ? "SUCCESS" : "FAILURE");
        Remember(line);
        _speaker = "CHECK";
        _line = line;
        string next = success ? choice.successNext : choice.failureNext;
        ShowCustomNode(string.IsNullOrEmpty(next) ? choice.next : next);
    }

    int AbilityValueForSkill(string skill)
    {
        if (string.IsNullOrEmpty(skill)) return 1;
        string key = skill.ToLowerInvariant();
        if (key.Contains("logic") || key.Contains("encyclopedia") || key.Contains("visual")) return 3;
        if (key.Contains("empathy") || key.Contains("volition") || key.Contains("inland")) return 3;
        if (key.Contains("perception") || key.Contains("reaction") || key.Contains("interfacing")) return 3;
        return 2;
    }

    void CloseDialogue()
    {
        _dialogueOpen = false;
        _choices.Clear();
        _visibleCustomChoices.Clear();
        _activeEntry = null;
        _activeConversation = null;
        _activeCustomConversation = null;
        _activeCustomNode = null;
        _activeTalkTarget = null;
    }

    public void RegisterWorldTrigger(string triggerKey, string displayName)
    {
        string key = string.IsNullOrEmpty(triggerKey) ? "trigger" : triggerKey;
        PlayerPrefs.SetInt("rootworld.trigger." + key, 1);
        PlayerPrefs.Save();
        RestoredGameState.SetFlag("trigger." + key);
        if (key.Contains("balcony")) RestoredGameState.UnlockLocation("balcony");
        string label = string.IsNullOrEmpty(displayName) ? key : displayName;
        Remember("Trigger: " + label);
        _hint = label + " added to the case journal. Press M for the world map.";
    }

    void RegisterVisit(string key)
    {
        RestoredGameState.Increment("visit." + key);
    }

    void Remember(string line)
    {
        RestoredGameState.Remember(line);
    }

    void ApplyScript(string script)
    {
        if (string.IsNullOrEmpty(script)) return;
        int index = script.IndexOf("SetVariableValue(\"", System.StringComparison.Ordinal);
        if (index < 0) index = script.IndexOf("XPTinySetBool(\"", System.StringComparison.Ordinal);
        if (index < 0) return;
        int start = script.IndexOf('"', index) + 1;
        int end = script.IndexOf('"', start);
        if (start <= 0 || end <= start) return;
        string key = script.Substring(start, end - start);
        PlayerPrefs.SetInt("dialogue." + key, 1);
        PlayerPrefs.Save();
        RestoredGameState.SetFlag("dialogue." + key);
        Remember("Dialogue flag: " + key);
    }

    void OnGUI()
    {
        DrawHint();
        if (_mapOpen) DrawWorldMap();
        if (_dialogueOpen) DrawDialogue();
    }

    void DrawHint()
    {
        var rect = new Rect(24, Screen.height - 74, Screen.width - 48, 46);
        GUI.DrawTexture(rect, _darkTexture, ScaleMode.StretchToFill);
        GUI.Label(new Rect(rect.x + 16, rect.y + 12, rect.width - 32, 24), _hint, _hintStyle);
    }

    void DrawWorldMap()
    {
        var rect = new Rect(24, 54, 520, 500);
        GUI.Box(rect, "", _panelStyle);
        if (worldMapTexture != null) GUI.DrawTexture(new Rect(rect.x + 18, rect.y + 18, rect.width - 36, 228), worldMapTexture, ScaleMode.ScaleToFit, true);
        GUI.Label(new Rect(rect.x + 18, rect.y + 256, rect.width - 36, 42), "Objective: " + RestoredGameState.CurrentObjective(), _smallStyle);
        DrawMapButton(new Rect(rect.x + 18, rect.y + 308, rect.width - 36, 32), "ROOM 1", "room", "RoomReal");
        DrawMapButton(new Rect(rect.x + 18, rect.y + 346, rect.width - 36, 32), "WHIRLING-IN-RAGS", "lobby", "WhirlingLobbyReal");
        DrawMapButton(new Rect(rect.x + 18, rect.y + 384, rect.width - 36, 32), "KLAASJE / BALCONY", "balcony", "KlaasjeBalconyReal");
        GUI.Label(new Rect(rect.x + 18, rect.y + 426, rect.width - 36, 22), "RECENT STATE", _speakerStyle);
        for (int i = 0; i < RestoredGameState.JournalCapacity; i++)
        {
            string line = RestoredGameState.JournalLine(i);
            if (!string.IsNullOrEmpty(line)) GUI.Label(new Rect(rect.x + 18, rect.y + 452 + i * 18, rect.width - 36, 18), "- " + line, _smallStyle);
        }
    }

    void DrawMapButton(Rect rect, string label, string locationKey, string sceneName)
    {
        bool unlocked = RestoredGameState.IsLocationUnlocked(locationKey);
        GUI.enabled = unlocked;
        if (GUI.Button(rect, unlocked ? label : label + " (LOCKED)", _choiceStyle)) LoadSceneIfAvailable(sceneName);
        GUI.enabled = true;
    }

    void DrawDialogue()
    {
        float width = Mathf.Min(660f, Screen.width * 0.46f);
        var rect = new Rect(Screen.width - width - 28, 86, width, Screen.height - 172);
        GUI.Box(rect, "", _panelStyle);
        Texture2D portrait = ActivePortrait();
        if (portrait != null) GUI.DrawTexture(new Rect(rect.x + 22, rect.y + 24, 96, 96), portrait, ScaleMode.ScaleToFit, true);
        float textX = portrait != null ? rect.x + 136 : rect.x + 24;
        GUI.Label(new Rect(textX, rect.y + 24, rect.width - (textX - rect.x) - 24, 26), (_speaker ?? "").ToUpperInvariant(), _speakerStyle);
        GUI.Label(new Rect(textX, rect.y + 58, rect.width - (textX - rect.x) - 24, 144), _line ?? "", _lineStyle);
        if (_choices.Count > 0)
        {
            for (int i = 0; i < _choices.Count && i < 9; i++)
            {
                string text = (i + 1) + ". " + Clean(Field(_choices[i].fields, "Dialogue Text"));
                if (GUI.Button(new Rect(rect.x + 24, rect.y + 222 + i * 42, rect.width - 48, 34), text, _choiceStyle)) ChooseDialogue(_choices[i]);
            }
        }
        else if (_activeCustomNode != null && _visibleCustomChoices.Count > 0)
        {
            for (int i = 0; i < _visibleCustomChoices.Count && i < 9; i++)
            {
                string text = (i + 1) + ". " + _visibleCustomChoices[i].text;
                if (GUI.Button(new Rect(rect.x + 24, rect.y + 222 + i * 42, rect.width - 48, 34), text, _choiceStyle)) ChooseCustom(_visibleCustomChoices[i]);
            }
        }
        else GUI.Label(new Rect(rect.x + 24, rect.yMax - 46, rect.width - 48, 24), "E / Space / Enter continues. Esc closes.", _smallStyle);
    }

    Texture2D ActivePortrait()
    {
        string key = Key(_activeTalkTarget);
        if (key == "kim") return kimPortrait;
        if (key == "klaasje") return klaasjePortrait;
        return null;
    }

    void LoadSceneIfAvailable(string sceneName)
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName)) SceneManager.LoadScene(sceneName);
        else _hint = sceneName + " is not in build settings yet.";
    }

    void UnlockLocations(string unlockLocation)
    {
        if (string.IsNullOrEmpty(unlockLocation)) return;
        foreach (var raw in unlockLocation.Split(','))
        {
            string key = raw.Trim();
            if (key.Length == 0) continue;
            RestoredGameState.UnlockLocation(key);
            Remember("Unlocked location: " + key);
        }
    }

    static string Field(List<Field> fields, string title)
    {
        if (fields == null) return null;
        foreach (var field in fields) if (field != null && field.title == title) return field.value;
        return null;
    }

    static int ActorId(DialogueEntry entry)
    {
        int.TryParse(Field(entry.fields, "Actor"), out int actorId);
        return actorId;
    }

    static string Clean(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        while (true)
        {
            int start = text.IndexOf('[');
            int end = start >= 0 ? text.IndexOf(']', start) : -1;
            if (start < 0 || end < 0) break;
            text = text.Remove(start, end - start + 1);
        }
        while (true)
        {
            int start = text.IndexOf('<');
            int end = start >= 0 ? text.IndexOf('>', start) : -1;
            if (start < 0 || end < 0) break;
            text = text.Remove(start, end - start + 1);
        }
        return text.Trim();
    }

    static string Key(RootWorldTalkTarget target)
    {
        if (target == null || string.IsNullOrEmpty(target.targetKey)) return "target";
        return target.targetKey.ToLowerInvariant();
    }

    static string DisplayName(RootWorldTalkTarget target)
    {
        if (target == null) return "Unknown";
        return string.IsNullOrEmpty(target.displayName) ? target.name : target.displayName;
    }
}