using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using PixelCrushers.DialogueSystem;

public class RecoveredSceneBootstrap : MonoBehaviour
{
    public string sceneTitle;
    public string sourcePrefabs;
    public string previousScene;
    public string nextScene;
    public string indexScene = "RecoveredSceneIndex";
    public GameObject playerPrefab;
    public RuntimeAnimatorController playerController;
    public DialogueDatabase database;

    Camera _camera;
    Bounds _bounds;
    float _speed = 8f;
    bool _ready;
    bool _freeFly;
    Transform _player;
    CharacterController _controller;
    Animator _playerAnimator;
    float _yaw = 35f;
    float _pitch = 24f;
    float _playerY;
    float _animForward;
    string _log = "Recovered source scene loaded.";
    string _check = "";
    float _checkUntil;
    bool _hasWalkTarget;
    bool _animHasForward;
    bool _dbReady;
    bool _dialogueOpen;
    bool _sheetOpen;
    Vector3 _walkTarget;
    Conversation _activeConversation;
    DialogueEntry _activeEntry;
    readonly HashSet<int> _playerActors = new HashSet<int>();
    readonly Dictionary<int, string> _actorNames = new Dictionary<int, string>();
    readonly Dictionary<string, Conversation> _conversationCache = new Dictionary<string, Conversation>();
    readonly Dictionary<string, Conversation> _conversationByExactBinding = new Dictionary<string, Conversation>();
    readonly HashSet<string> _ambiguousConversationBindings = new HashSet<string>();
    readonly Dictionary<string, List<SerializedInteractableBinding>> _interactableBindingsByObject = new Dictionary<string, List<SerializedInteractableBinding>>();
    readonly List<DialogueEntry> _choices = new List<DialogueEntry>();
    readonly List<string> _recentProgress = new List<string>();
    string _dialogueSpeaker = "";
    string _dialogueLine = "";
    bool _conversationBindingIndexReady;
    bool _interactableBindingIndexReady;

    readonly string[] _skills = { "LOGIC", "ENCYCLOPEDIA", "VISUAL CALCULUS", "VOLITION", "INLAND EMPIRE", "ENDURANCE", "ELECTROCHEMISTRY", "PERCEPTION", "REACTION SPEED", "INTERFACING", "COMPOSURE" };

    class SerializedInteractableBinding
    {
        public string objectName;
        public string prefabName;
        public string fieldName;
        public string bindingValue;
        public string conditionString;
    }

    void Start()
    {
        BuildView();
    }

    void BuildView()
    {
        var renderers = FindObjectsByType<Renderer>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        _bounds = UsefulBounds(renderers);

        if (_player == null) BuildPlayer();

        foreach (var cam in FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None)) if (cam != _camera) cam.enabled = false;
        if (_camera == null)
        {
            var camGO = new GameObject("RecoveredSceneCamera");
            _camera = camGO.AddComponent<Camera>();
            camGO.AddComponent<AudioListener>();
            camGO.tag = "MainCamera";
        }
        _camera.enabled = true;
        _camera.nearClipPlane = 0.05f;
        _camera.farClipPlane = Mathf.Max(1000f, _bounds.size.magnitude * 8f);
        _camera.clearFlags = CameraClearFlags.SolidColor;
        _camera.backgroundColor = new Color(0.015f, 0.017f, 0.020f);

        float dist = Mathf.Clamp(_bounds.size.magnitude * 0.72f, 18f, 240f);
        var dir = new Vector3(-0.75f, 0.55f, -0.75f).normalized;
        if (_freeFly)
        {
            _camera.transform.position = _bounds.center - dir * dist;
            _camera.transform.LookAt(_bounds.center);
        }
        _speed = Mathf.Clamp(_bounds.size.magnitude * 0.08f, 5f, 45f);
        BuildSafetyGround();

        if (FindAnyObjectByType<Light>() == null)
        {
            var light = new GameObject("RecoveredSceneSun").AddComponent<Light>();
            light.type = LightType.Directional;
            light.intensity = 1.05f;
            light.color = new Color(1f, 0.94f, 0.84f);
            light.transform.rotation = Quaternion.Euler(50f, -35f, 0f);
        }

        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = new Color(0.72f, 0.70f, 0.66f);
        _ready = true;
    }

    Bounds UsefulBounds(Renderer[] renderers)
    {
        if (renderers == null || renderers.Length == 0) return new Bounds(Vector3.zero, Vector3.one * 10f);

        Bounds all = renderers[0].bounds;
        for (int i = 1; i < renderers.Length; i++) all.Encapsulate(renderers[i].bounds);
        float maxUsefulSize = Mathf.Max(40f, all.size.magnitude * 0.35f);

        bool found = false;
        Bounds useful = new Bounds(all.center, Vector3.one);
        foreach (var renderer in renderers)
        {
            if (renderer == null || !renderer.enabled) continue;
            string n = renderer.name.ToLowerInvariant();
            if (n.Contains("blob shadow") || n.Contains("fog") || n.Contains("unseen")) continue;
            if (renderer.bounds.size.magnitude > maxUsefulSize) continue;
            if (!found) { useful = renderer.bounds; found = true; }
            else useful.Encapsulate(renderer.bounds);
        }

        return found ? useful : all;
    }

    void BuildPlayer()
    {
        GameObject go = null;
        if (playerPrefab != null) go = Instantiate(playerPrefab);
        if (go == null)
        {
            go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            go.name = "HarryFallback";
            var mr = go.GetComponent<Renderer>();
            if (mr != null) mr.material.color = new Color(0.23f, 0.34f, 0.24f);
        }

        go.name = "Harry_OpenWorld";
        ConfigurePlayerAnimator(go);
        _player = go.transform;
        _controller = go.GetComponent<CharacterController>();
        if (_controller == null) _controller = go.AddComponent<CharacterController>();
        _controller.height = 1.85f;
        _controller.radius = 0.34f;
        _controller.center = new Vector3(0f, 0.92f, 0f);

        Vector3 spawn = _bounds.center;
        spawn.y = _bounds.min.y + 0.95f;
        _player.position = spawn;
        _player.rotation = Quaternion.Euler(0f, 180f, 0f);
        float targetHeight = 1.85f;
        var renderers = go.GetComponentsInChildren<Renderer>(true);
        if (renderers.Length > 0)
        {
            Bounds pb = renderers[0].bounds;
            for (int i = 1; i < renderers.Length; i++) pb.Encapsulate(renderers[i].bounds);
            float scale = Mathf.Clamp(targetHeight / Mathf.Max(0.01f, pb.size.y), 0.25f, 3f);
            _player.localScale *= scale;
        }
        _playerY = spawn.y;
    }

    void ConfigurePlayerAnimator(GameObject go)
    {
        foreach (var cloth in go.GetComponentsInChildren<Cloth>(true)) cloth.enabled = false;
        _playerAnimator = go.GetComponent<Animator>();
        if (_playerAnimator == null) return;

        _playerAnimator.avatar = null;
        _playerAnimator.applyRootMotion = false;
        _playerAnimator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        if (playerController != null) _playerAnimator.runtimeAnimatorController = playerController;

        _playerAnimator.enabled = _playerAnimator.runtimeAnimatorController != null;
        _animHasForward = false;
        if (!_playerAnimator.enabled) return;

        foreach (var p in _playerAnimator.parameters)
        {
            if (p.name == "Forward" && p.type == AnimatorControllerParameterType.Float)
            {
                _animHasForward = true;
                break;
            }
        }
        if (_animHasForward) _playerAnimator.Play("Player Movement", 0, 0f);
    }

    void BuildSafetyGround()
    {
        if (GameObject.Find("RecoveredSafetyGround") != null) return;
        var ground = new GameObject("RecoveredSafetyGround");
        var box = ground.AddComponent<BoxCollider>();
        float size = Mathf.Max(_bounds.size.x, _bounds.size.z, 40f);
        ground.transform.position = new Vector3(_bounds.center.x, _bounds.min.y - 0.08f, _bounds.center.z);
        box.size = new Vector3(size * 1.8f, 0.12f, size * 1.8f);
    }

    void Update()
    {
        if (!_ready || _camera == null) return;

        if (Input.GetKeyDown(KeyCode.Escape) && !string.IsNullOrEmpty(indexScene)) SceneManager.LoadScene(indexScene);
        if (Input.GetKeyDown(KeyCode.PageDown) && !string.IsNullOrEmpty(nextScene)) SceneManager.LoadScene(nextScene);
        if (Input.GetKeyDown(KeyCode.PageUp) && !string.IsNullOrEmpty(previousScene)) SceneManager.LoadScene(previousScene);
        if (Input.GetKeyDown(KeyCode.R)) BuildView();
        if (Input.GetKeyDown(KeyCode.F)) _freeFly = !_freeFly;
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.Tab)) _sheetOpen = !_sheetOpen;
        if (_dialogueOpen)
        {
            UpdateDialogueInput();
            UpdateWalkingPlayer();
            return;
        }
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) InspectNearestSourceObject();

        if (_freeFly) UpdateFreeCamera();
        else UpdateWalkingPlayer();
    }

    void UpdateFreeCamera()
    {
        float moveSpeed = _speed * (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? 3f : 1f);
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) move += _camera.transform.forward;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) move -= _camera.transform.forward;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) move -= _camera.transform.right;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) move += _camera.transform.right;
        if (Input.GetKey(KeyCode.Q)) move -= Vector3.up;
        if (Input.GetKey(KeyCode.E)) move += Vector3.up;
        if (move.sqrMagnitude > 0.001f) _camera.transform.position += move.normalized * moveSpeed * Time.deltaTime;

        if (Input.GetMouseButton(1))
        {
            float yaw = Input.GetAxis("Mouse X") * 3.5f;
            float pitch = -Input.GetAxis("Mouse Y") * 2.4f;
            _camera.transform.Rotate(Vector3.up, yaw, Space.World);
            _camera.transform.Rotate(Vector3.right, pitch, Space.Self);
        }
    }

    void UpdateWalkingPlayer()
    {
        if (_player == null || _controller == null) return;
        if (Input.GetMouseButton(1))
        {
            _yaw += Input.GetAxis("Mouse X") * 3.5f;
            _pitch = Mathf.Clamp(_pitch - Input.GetAxis("Mouse Y") * 2.2f, 8f, 62f);
        }
        ReadWalkTarget();

        Vector3 forward = Quaternion.Euler(0f, _yaw, 0f) * Vector3.forward;
        Vector3 right = Quaternion.Euler(0f, _yaw, 0f) * Vector3.right;
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) move += forward;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) move -= forward;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) move -= right;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) move += right;
        float speed = Mathf.Clamp(_bounds.size.magnitude * 0.035f, 2.5f, 9f) * (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? 1.8f : 1f);
        if (move.sqrMagnitude > 0.001f) _hasWalkTarget = false;
        else if (_hasWalkTarget)
        {
            Vector3 toTarget = _walkTarget - _player.position;
            toTarget.y = 0f;
            float distance = toTarget.magnitude;
            if (distance <= 0.18f)
            {
                _hasWalkTarget = false;
                move = Vector3.zero;
            }
            else
            {
                move = toTarget / distance;
            }
        }

        if (move.sqrMagnitude > 0.001f)
        {
            move.Normalize();
            _controller.Move(move * speed * Time.deltaTime);
            _player.position = new Vector3(_player.position.x, _playerY, _player.position.z);
            _player.rotation = Quaternion.Slerp(_player.rotation, Quaternion.LookRotation(move, Vector3.up), Time.deltaTime * 8f);
        }
        UpdatePlayerAnimator(move.sqrMagnitude > 0.001f ? (speed > 6f ? 2f : 1f) : 0f);

        Vector3 focus = _player.position + Vector3.up * 1.2f;
        Quaternion orbit = Quaternion.Euler(_pitch, _yaw, 0f);
        float dist = Mathf.Clamp(_bounds.size.magnitude * 0.055f, 5f, 14f);
        _camera.transform.position = focus - orbit * Vector3.forward * dist;
        _camera.transform.LookAt(focus);
    }

    void ReadWalkTarget()
    {
        if (_camera == null || !Input.GetMouseButtonDown(0)) return;
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) return;

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Max(1000f, _bounds.size.magnitude * 8f)))
        {
            if (_player == null || !hit.transform.IsChildOf(_player))
            {
                _walkTarget = new Vector3(hit.point.x, _playerY, hit.point.z);
                _hasWalkTarget = true;
                return;
            }
        }

        var floor = new Plane(Vector3.up, new Vector3(0f, _playerY, 0f));
        if (floor.Raycast(ray, out float enter))
        {
            Vector3 p = ray.GetPoint(enter);
            _walkTarget = new Vector3(p.x, _playerY, p.z);
            _hasWalkTarget = true;
        }
    }

    void UpdatePlayerAnimator(float targetForward)
    {
        if (_playerAnimator == null || !_playerAnimator.enabled || !_animHasForward) return;
        _animForward = Mathf.MoveTowards(_animForward, targetForward, Time.deltaTime * 6f);
        _playerAnimator.SetFloat("Forward", _animForward);
    }

    void InspectNearestSourceObject()
    {
        if (_player == null) return;
        Renderer best = null;
        float bestDist = Mathf.Max(5f, _bounds.size.magnitude * 0.035f);
        foreach (var r in FindObjectsByType<Renderer>(FindObjectsInactive.Exclude, FindObjectsSortMode.None))
        {
            if (r.transform.IsChildOf(_player)) continue;
            if (r.name.Contains("Shadow") || r.name.Contains("Safety")) continue;
            float d = Vector3.Distance(_player.position, r.bounds.center);
            if (d < bestDist) { bestDist = d; best = r; }
        }
        if (best == null)
        {
            _log = "No source object close enough to inspect.";
            _check = "";
            return;
        }

        string source = CleanName(SourceName(best.transform));
        if (TryStartSourceConversation(source)) return;

        int hash = Mathf.Abs((SceneManager.GetActiveScene().name + source).GetHashCode());
        string skill = _skills[hash % _skills.Length];
        int ability = AbilityValueForSkill(skill);
        int d1 = Random.Range(1, 7), d2 = Random.Range(1, 7);
        int difficulty = 7 + (hash % 6);
        int total = d1 + d2 + ability;
        bool critFail = d1 == 1 && d2 == 1;
        bool critSuccess = d1 == 6 && d2 == 6;
        bool success = critSuccess || (!critFail && total >= difficulty);
        string flag = "recovered." + SceneManager.GetActiveScene().name + "." + source.Replace(" ", "_");
        PlayerPrefs.SetInt(flag, success ? 1 : -1);
        PlayerPrefs.Save();
        RememberProgress(flag + " = " + (success ? "SUCCESS" : "FAILURE"));

        _log = (success ? "Recorded consequence: " : "Recorded failed check: ") + flag;
        _check = source + " | " + skill + " " + d1 + "+" + d2 + "+" + ability + " = " + total + " / " + difficulty + " -> " + (success ? "SUCCESS" : "FAILURE");
        _checkUntil = Time.time + 6f;
    }

    bool TryStartSourceConversation(string source)
    {
        EnsureDatabaseReady();
        if (database == null) return false;
        var conv = FindConversationForSource(source);
        if (conv == null || conv.dialogueEntries == null || conv.dialogueEntries.Count == 0) return false;

        _activeConversation = conv;
        _dialogueOpen = true;
        _choices.Clear();
        _dialogueSpeaker = "";
        _dialogueLine = "";
        _log = "Dialogue: " + Field(conv.fields, "Title");

        DialogueEntry start = null;
        foreach (var e in conv.dialogueEntries) if (e.id == 0 || e.isRoot) { start = e; break; }
        if (start == null) start = conv.dialogueEntries[0];
        FollowDialogue(start);
        return true;
    }

    void EnsureDatabaseReady()
    {
        if (_dbReady || database == null) return;
        _dbReady = true;
        _playerActors.Clear();
        _actorNames.Clear();
        foreach (var actor in database.actors)
        {
            string name = Field(actor.fields, "Name");
            _actorNames[actor.id] = string.IsNullOrEmpty(name) ? ("Actor " + actor.id) : name;
            string isPlayer = Field(actor.fields, "IsPlayer");
            if (!string.IsNullOrEmpty(isPlayer) && isPlayer.Trim().Equals("True", System.StringComparison.OrdinalIgnoreCase)) _playerActors.Add(actor.id);
        }
    }

    Conversation FindConversationForSource(string source)
    {
        string key = CleanToken(source);
        Conversation exact = FindExactConversationForSource(source);
        if (exact != null) return exact;

        if (_conversationCache.TryGetValue(key, out var cached)) return cached;

        Conversation best = null;
        int bestScore = 0;
        string[] sourceTokens = Tokens(source + " " + sceneTitle + " " + SceneManager.GetActiveScene().name);
        foreach (var conv in database.conversations)
        {
            string title = Field(conv.fields, "Title");
            if (string.IsNullOrEmpty(title)) continue;
            string foldedTitle = CleanToken(title);
            int score = 0;
            foreach (var token in sourceTokens)
            {
                if (token.Length < 3) continue;
                if (foldedTitle.Contains(token)) score += token.Length >= 7 ? 3 : 1;
            }
            if (score > bestScore)
            {
                bestScore = score;
                best = conv;
            }
        }

        if (bestScore < 4) best = null;
        _conversationCache[key] = best;
        return best;
    }

    Conversation FindExactConversationForSource(string source)
    {
        EnsureConversationBindingIndex();
        EnsureInteractableBindingIndex();

        string sourceKey = CleanToken(source);
        if (string.IsNullOrEmpty(sourceKey)) return null;
        if (!_interactableBindingsByObject.TryGetValue(sourceKey, out var bindings)) return null;

        Conversation best = null;
        int bestScore = int.MinValue;
        bool ambiguous = false;
        foreach (var binding in bindings)
        {
            if (binding == null || !ConditionPasses(binding.conditionString)) continue;
            Conversation conv = ConversationForSerializedBinding(binding.bindingValue);
            if (conv == null) continue;

            int score = ExactBindingScore(binding);
            if (score > bestScore)
            {
                best = conv;
                bestScore = score;
                ambiguous = false;
            }
            else if (score == bestScore && best != conv)
            {
                ambiguous = true;
            }
        }

        return ambiguous ? null : best;
    }

    int ExactBindingScore(SerializedInteractableBinding binding)
    {
        int score = 100;
        if (!string.IsNullOrEmpty(sourcePrefabs) && !string.IsNullOrEmpty(binding.prefabName) &&
            sourcePrefabs.IndexOf(binding.prefabName, System.StringComparison.OrdinalIgnoreCase) >= 0)
        {
            score += 40;
        }
        if (!string.IsNullOrEmpty(sceneTitle) && !string.IsNullOrEmpty(binding.prefabName))
        {
            string prefabKey = CleanToken(binding.prefabName);
            foreach (var token in Tokens(sceneTitle))
                if (token.Length >= 4 && prefabKey.Contains(token)) score += 2;
        }
        if (!string.IsNullOrEmpty(binding.conditionString)) score += 1;
        return score;
    }

    void EnsureConversationBindingIndex()
    {
        if (_conversationBindingIndexReady) return;
        _conversationBindingIndexReady = true;
        _conversationByExactBinding.Clear();
        _ambiguousConversationBindings.Clear();
        if (database == null) return;

        foreach (var conv in database.conversations)
        {
            if (conv == null) continue;
            AddConversationBinding("title", Field(conv.fields, "Title"), conv);
            string conversationArticyId = Field(conv.fields, "Articy Id");
            AddConversationBinding("articy", conversationArticyId, conv);
            AddConversationBinding("id", conversationArticyId, conv);

            if (conv.dialogueEntries == null) continue;
            foreach (var entry in conv.dialogueEntries)
            {
                if (entry == null) continue;
                string entryArticyId = Field(entry.fields, "Articy Id");
                string inputId = Field(entry.fields, "InputId");
                string outputId = Field(entry.fields, "OutputId");
                AddConversationBinding("articy", entryArticyId, conv);
                AddConversationBinding("input", inputId, conv);
                AddConversationBinding("output", outputId, conv);
                AddConversationBinding("id", entryArticyId, conv);
                AddConversationBinding("id", inputId, conv);
                AddConversationBinding("id", outputId, conv);
            }
        }
    }

    void AddConversationBinding(string prefix, string value, Conversation conversation)
    {
        string normalized = prefix == "title" ? CleanToken(value) : NormalizeBindingValue(value);
        if (string.IsNullOrEmpty(normalized) || conversation == null) return;

        string key = prefix + "|" + normalized;
        if (_ambiguousConversationBindings.Contains(key)) return;

        if (_conversationByExactBinding.TryGetValue(key, out var existing))
        {
            if (existing != conversation)
            {
                _conversationByExactBinding.Remove(key);
                _ambiguousConversationBindings.Add(key);
            }
            return;
        }

        _conversationByExactBinding[key] = conversation;
    }

    Conversation ConversationForSerializedBinding(string value)
    {
        string normalized = NormalizeBindingValue(value);
        if (string.IsNullOrEmpty(normalized)) return null;

        Conversation conv;
        string titleKey = "title|" + CleanToken(value);
        if (!_ambiguousConversationBindings.Contains(titleKey) && _conversationByExactBinding.TryGetValue(titleKey, out conv)) return conv;

        if (TryExactConversation("articy", normalized, out conv)) return conv;
        if (TryExactConversation("input", normalized, out conv)) return conv;
        if (TryExactConversation("output", normalized, out conv)) return conv;
        if (TryExactConversation("id", normalized, out conv)) return conv;
        return null;
    }

    bool TryExactConversation(string prefix, string normalizedValue, out Conversation conversation)
    {
        string key = prefix + "|" + normalizedValue;
        if (!_ambiguousConversationBindings.Contains(key) && _conversationByExactBinding.TryGetValue(key, out conversation)) return true;
        conversation = null;
        return false;
    }

    void EnsureInteractableBindingIndex()
    {
        if (_interactableBindingIndexReady) return;
        _interactableBindingIndexReady = true;
        _interactableBindingsByObject.Clear();

        string dir = Path.Combine(Application.dataPath, "GameObject");
        if (!Directory.Exists(dir)) return;

        string[] paths;
        try { paths = Directory.GetFiles(dir, "Interactable*.prefab", SearchOption.TopDirectoryOnly); }
        catch { return; }
        System.Array.Sort(paths);

        foreach (var path in paths) ParseInteractablePrefab(path);
    }

    void ParseInteractablePrefab(string path)
    {
        string[] lines;
        try { lines = File.ReadAllLines(path); }
        catch { return; }

        var gameObjectNames = new Dictionary<string, string>();
        string blockType = null;
        string blockId = null;

        foreach (var line in lines)
        {
            string nextType;
            string nextId;
            if (TryStartYamlBlock(line, out nextType, out nextId))
            {
                blockType = nextType;
                blockId = nextId;
                continue;
            }
            if (blockType == "1" && line.StartsWith("  m_Name:", System.StringComparison.Ordinal))
            {
                gameObjectNames[blockId] = CleanName(UnquoteYamlScalar(ValueAfterColon(line)));
            }
        }

        bool inMono = false;
        string monoGameObject = null;
        string condition = null;
        var bindingFields = new List<string>();
        var bindingValues = new List<string>();
        string prefabName = Path.GetFileName(path);

        for (int i = 0; i <= lines.Length; i++)
        {
            if (i == lines.Length)
            {
                FlushSerializedInteractable(prefabName, monoGameObject, condition, bindingFields, bindingValues, gameObjectNames);
                break;
            }

            string line = lines[i];
            string type;
            string id;
            if (TryStartYamlBlock(line, out type, out id))
            {
                FlushSerializedInteractable(prefabName, monoGameObject, condition, bindingFields, bindingValues, gameObjectNames);
                inMono = type == "114";
                monoGameObject = null;
                condition = null;
                bindingFields.Clear();
                bindingValues.Clear();
                continue;
            }

            if (!inMono) continue;
            string trimmed = line.TrimStart();
            if (trimmed.StartsWith("m_GameObject:", System.StringComparison.Ordinal))
            {
                monoGameObject = ExtractFileId(trimmed);
                continue;
            }

            string fieldName;
            string fieldValue;
            if (!TryGetYamlScalar(trimmed, out fieldName, out fieldValue)) continue;
            if (IsInteractableConditionField(fieldName))
            {
                condition = fieldValue;
                continue;
            }
            if (IsInteractableBindingField(fieldName))
            {
                AddSerializedBindingValue(fieldName, fieldValue, bindingFields, bindingValues);
                continue;
            }

            string hexId = ExtractHexId(fieldValue);
            if (!string.IsNullOrEmpty(hexId)) AddSerializedBindingValue(fieldName, hexId, bindingFields, bindingValues);
        }
    }

    void FlushSerializedInteractable(string prefabName, string gameObjectId, string condition, List<string> fields, List<string> values, Dictionary<string, string> gameObjectNames)
    {
        if (string.IsNullOrEmpty(gameObjectId) || values.Count == 0) return;
        if (!gameObjectNames.TryGetValue(gameObjectId, out var objectName)) return;

        string objectKey = CleanToken(objectName);
        if (string.IsNullOrEmpty(objectKey)) return;
        if (!_interactableBindingsByObject.TryGetValue(objectKey, out var list))
        {
            list = new List<SerializedInteractableBinding>();
            _interactableBindingsByObject[objectKey] = list;
        }

        var seen = new HashSet<string>();
        for (int i = 0; i < values.Count; i++)
        {
            string value = values[i];
            string unique = NormalizeBindingValue(value);
            if (string.IsNullOrEmpty(unique) || !seen.Add(fields[i] + "|" + unique)) continue;
            list.Add(new SerializedInteractableBinding
            {
                objectName = objectName,
                prefabName = prefabName,
                fieldName = fields[i],
                bindingValue = value,
                conditionString = condition
            });
        }
    }

    static bool TryStartYamlBlock(string line, out string type, out string id)
    {
        type = null;
        id = null;
        if (string.IsNullOrEmpty(line) || !line.StartsWith("--- !u!", System.StringComparison.Ordinal)) return false;

        int typeStart = line.IndexOf("!u!", System.StringComparison.Ordinal) + 3;
        int typeEnd = line.IndexOf(' ', typeStart);
        if (typeEnd < 0) return false;
        int idStart = line.IndexOf('&', typeEnd);
        if (idStart < 0) return false;

        type = line.Substring(typeStart, typeEnd - typeStart);
        id = line.Substring(idStart + 1).Trim();
        return true;
    }

    static bool TryGetYamlScalar(string trimmedLine, out string fieldName, out string value)
    {
        fieldName = null;
        value = null;
        if (string.IsNullOrEmpty(trimmedLine)) return false;
        int colon = trimmedLine.IndexOf(':');
        if (colon <= 0) return false;

        fieldName = trimmedLine.Substring(0, colon).Trim();
        value = UnquoteYamlScalar(trimmedLine.Substring(colon + 1).Trim());
        return true;
    }

    static string ValueAfterColon(string line)
    {
        int colon = line.IndexOf(':');
        return colon >= 0 ? line.Substring(colon + 1).Trim() : "";
    }

    static string ExtractFileId(string line)
    {
        const string marker = "fileID:";
        int start = line.IndexOf(marker, System.StringComparison.Ordinal);
        if (start < 0) return null;
        start += marker.Length;
        while (start < line.Length && char.IsWhiteSpace(line[start])) start++;
        int end = start;
        while (end < line.Length && (char.IsDigit(line[end]) || line[end] == '-')) end++;
        return end > start ? line.Substring(start, end - start) : null;
    }

    static void AddSerializedBindingValue(string fieldName, string value, List<string> fields, List<string> values)
    {
        value = NormalizeBindingValue(value);
        if (string.IsNullOrEmpty(value) || value == "{}") return;
        fields.Add(fieldName);
        values.Add(value);
    }

    static bool IsInteractableConditionField(string fieldName)
    {
        return CleanFieldName(fieldName) == "conditionstring";
    }

    static bool IsInteractableBindingField(string fieldName)
    {
        string key = CleanFieldName(fieldName);
        return key == "conversation" ||
            key == "overrideconversation" ||
            key == "conversationifnoentity" ||
            key == "articyid" ||
            key == "inputid" ||
            key == "outputid";
    }

    static string CleanFieldName(string fieldName)
    {
        if (string.IsNullOrEmpty(fieldName)) return "";
        fieldName = fieldName.Trim().ToLowerInvariant();
        char[] chars = fieldName.ToCharArray();
        int write = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLetterOrDigit(chars[i])) chars[write++] = chars[i];
        }
        return new string(chars, 0, write);
    }

    static string ExtractHexId(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        int idx = value.IndexOf("0x", System.StringComparison.OrdinalIgnoreCase);
        if (idx < 0 || idx + 18 > value.Length) return null;
        for (int i = idx + 2; i < idx + 18; i++)
            if (!IsHex(value[i])) return null;
        return value.Substring(idx, 18);
    }

    static bool IsHex(char c)
    {
        return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
    }

    static string NormalizeBindingValue(string value)
    {
        if (string.IsNullOrEmpty(value)) return "";
        value = UnquoteYamlScalar(value).Trim();
        return value.ToLowerInvariant();
    }

    static string UnquoteYamlScalar(string value)
    {
        if (string.IsNullOrEmpty(value)) return "";
        value = value.Trim();
        if (value.Length >= 2 && value[0] == '"' && value[value.Length - 1] == '"')
        {
            value = value.Substring(1, value.Length - 2);
            value = value.Replace("\\\"", "\"").Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
        }
        return value;
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

        if (_choices.Count == 0 && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)))
        {
            if (_activeEntry != null) FollowDialogue(_activeEntry);
            else CloseDialogue();
        }

        if (Input.GetKeyDown(KeyCode.Backspace)) CloseDialogue();
    }

    void FollowDialogue(DialogueEntry from)
    {
        if (_activeConversation == null || from == null) { CloseDialogue(); return; }
        ApplyScript(Field(from.fields, "userScript"));
        var next = ResolveDialogue(from);
        _choices.Clear();
        DialogueEntry line = null;
        foreach (var e in next)
        {
            if (!ConditionPasses(e.conditionsString)) continue;
            if (IsPlayer(e)) _choices.Add(e);
            else if (line == null) line = e;
        }

        if (_choices.Count > 0)
        {
            _activeEntry = null;
            _dialogueSpeaker = "YOU";
            _dialogueLine = "Choose a reply.";
            return;
        }

        if (line != null)
        {
            ShowDialogueLine(line);
            return;
        }

        CloseDialogue();
    }

    List<DialogueEntry> ResolveDialogue(DialogueEntry from)
    {
        var list = new List<DialogueEntry>();
        if (from.outgoingLinks == null || _activeConversation == null) return list;
        foreach (var link in from.outgoingLinks)
        {
            if (link.destinationConversationID != _activeConversation.id) continue;
            foreach (var entry in _activeConversation.dialogueEntries)
            {
                if (entry.id == link.destinationDialogueID) { list.Add(entry); break; }
            }
        }
        return list;
    }

    void ShowDialogueLine(DialogueEntry entry)
    {
        _activeEntry = entry;
        int actorId = ActorId(entry);
        _actorNames.TryGetValue(actorId, out _dialogueSpeaker);
        if (string.IsNullOrEmpty(_dialogueSpeaker)) _dialogueSpeaker = "SOURCE";
        _dialogueLine = CleanDialogue(Field(entry.fields, "Dialogue Text"));
        if (string.IsNullOrEmpty(_dialogueLine)) FollowDialogue(entry);
    }

    void ChooseDialogue(DialogueEntry entry)
    {
        _choices.Clear();
        _dialogueSpeaker = "YOU";
        _dialogueLine = CleanDialogue(Field(entry.fields, "Dialogue Text"));
        ApplyScript(Field(entry.fields, "userScript"));
        _activeEntry = entry;
        _check = "Selected: " + _dialogueLine;
        _checkUntil = Time.time + 4f;
    }

    void CloseDialogue()
    {
        _dialogueOpen = false;
        _activeConversation = null;
        _activeEntry = null;
        _choices.Clear();
        _dialogueSpeaker = "";
        _dialogueLine = "";
    }

    bool IsPlayer(DialogueEntry entry)
    {
        return _playerActors.Contains(ActorId(entry));
    }

    int ActorId(DialogueEntry entry)
    {
        int.TryParse(Field(entry.fields, "Actor"), out int id);
        return id;
    }

    bool ConditionPasses(string condition)
    {
        if (string.IsNullOrWhiteSpace(condition)) return true;
        int idx = 0;
        while ((idx = condition.IndexOf("Variable[\"", idx, System.StringComparison.Ordinal)) >= 0)
        {
            int start = idx + 10;
            int end = condition.IndexOf("\"]", start, System.StringComparison.Ordinal);
            if (end < 0) break;
            string varName = condition.Substring(start, end - start);
            bool value = PlayerPrefs.GetInt("dialogue." + varName, 0) != 0;
            string tail = condition.Substring(end, Mathf.Min(24, condition.Length - end)).ToLowerInvariant();
            bool wantsFalse = tail.Contains("false") || condition.LastIndexOf('!', idx, Mathf.Min(idx, 4)) >= 0;
            if (wantsFalse ? value : !value) return false;
            idx = end + 2;
        }
        return true;
    }

    void ApplyScript(string script)
    {
        if (string.IsNullOrEmpty(script)) return;
        ApplySetVariable(script, "SetVariableValue(\"");
        ApplySetVariable(script, "XPTinySetBool(\"");
    }

    void ApplySetVariable(string script, string marker)
    {
        int idx = 0;
        while ((idx = script.IndexOf(marker, idx, System.StringComparison.Ordinal)) >= 0)
        {
            int start = idx + marker.Length;
            int end = script.IndexOf('"', start);
            if (end < 0) break;
            string varName = script.Substring(start, end - start);
            bool value = true;
            int close = script.IndexOf(')', end);
            if (close > end)
            {
                string args = script.Substring(end, close - end).ToLowerInvariant();
                if (args.Contains("false")) value = false;
            }
            PlayerPrefs.SetInt("dialogue." + varName, value ? 1 : 0);
            PlayerPrefs.Save();
            RememberProgress("dialogue." + varName + " = " + value);
            _log = "Dialogue variable set: " + varName + " = " + value;
            idx = end + 1;
        }
    }

    void RememberProgress(string entry)
    {
        if (string.IsNullOrEmpty(entry)) return;
        _recentProgress.Remove(entry);
        _recentProgress.Insert(0, entry);
        while (_recentProgress.Count > 12) _recentProgress.RemoveAt(_recentProgress.Count - 1);
    }

    static string Field(List<Field> fields, string title)
    {
        if (fields == null) return null;
        foreach (var field in fields) if (field != null && field.title == title) return field.value;
        return null;
    }

    static string CleanDialogue(string text)
    {
        if (string.IsNullOrEmpty(text)) return "";
        while (true)
        {
            int a = text.IndexOf('[');
            int b = a >= 0 ? text.IndexOf(']', a) : -1;
            if (a < 0 || b < 0) break;
            text = text.Remove(a, b - a + 1);
        }
        while (true)
        {
            int a = text.IndexOf('<');
            int b = a >= 0 ? text.IndexOf('>', a) : -1;
            if (a < 0 || b < 0) break;
            text = text.Remove(a, b - a + 1);
        }
        return text.Trim();
    }

    static string CleanToken(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        s = s.ToLowerInvariant();
        char[] chars = s.ToCharArray();
        for (int i = 0; i < chars.Length; i++) if (!char.IsLetterOrDigit(chars[i])) chars[i] = ' ';
        s = new string(chars);
        while (s.Contains("  ")) s = s.Replace("  ", " ");
        return s.Trim();
    }

    static string[] Tokens(string s)
    {
        string cleaned = CleanToken(s);
        var raw = cleaned.Split(' ');
        var list = new List<string>();
        foreach (var token in raw)
        {
            if (token.Length < 3) continue;
            if (token == "the" || token == "and" || token == "props" || token == "prefab" || token == "clickable" || token == "recovered") continue;
            list.Add(token);
        }
        return list.ToArray();
    }

    string SourceName(Transform t)
    {
        Transform cur = t;
        for (int i = 0; i < 4 && cur != null; i++, cur = cur.parent)
        {
            if (!cur.name.StartsWith("GameObject") && !cur.name.StartsWith("Recovered") && !cur.name.StartsWith("Blob Shadow")) return cur.name;
        }
        return t.name;
    }

    static string CleanName(string s)
    {
        if (string.IsNullOrEmpty(s)) return "Unknown";
        s = s.Replace("(Clone)", "").Replace("_", " ").Replace("-", " ").Trim();
        while (s.Contains("  ")) s = s.Replace("  ", " ");
        return s;
    }

    int AbilityValueForSkill(string skill)
    {
        int faculty = (skill == "LOGIC" || skill == "ENCYCLOPEDIA" || skill == "VISUAL CALCULUS") ? PlayerPrefs.GetInt("INT", 1) :
            (skill == "VOLITION" || skill == "INLAND EMPIRE") ? PlayerPrefs.GetInt("PSY", 1) :
            (skill == "ENDURANCE" || skill == "ELECTROCHEMISTRY") ? PlayerPrefs.GetInt("FYS", 1) : PlayerPrefs.GetInt("MOT", 1);
        if (PlayerPrefs.GetString("signatureSkill", "").ToUpperInvariant().Replace("/", " ") == skill) faculty += 1;
        return Mathf.Clamp(faculty, 1, 7);
    }

    void OnGUI()
    {
        GUI.color = Color.white;
        GUI.Box(new Rect(18, 18, 720, 126), "");
        GUI.Label(new Rect(34, 30, 680, 28), string.IsNullOrEmpty(sceneTitle) ? SceneManager.GetActiveScene().name : sceneTitle);
        GUI.Label(new Rect(34, 58, 680, 26), (_freeFly ? "FLY" : "WALK") + "  |  C sheet  |  F toggle  |  LMB walk  |  RMB look  |  WASD move  |  E/Space inspect/check  |  PgUp/PgDn  |  Esc index");
        GUI.Label(new Rect(34, 86, 680, 46), "Source prefabs: " + sourcePrefabs);
        GUI.Box(new Rect(18, Screen.height - 118, Screen.width - 36, 92), "");
        GUI.Label(new Rect(34, Screen.height - 104, Screen.width - 68, 28), _log);
        if (!string.IsNullOrEmpty(_check) && Time.time < _checkUntil) GUI.Label(new Rect(34, Screen.height - 72, Screen.width - 68, 32), _check);

        if (_dialogueOpen)
        {
            GUI.Box(new Rect(Screen.width * 0.52f, 150, Screen.width * 0.45f, Screen.height - 300), "");
            GUI.Label(new Rect(Screen.width * 0.54f, 174, Screen.width * 0.41f, 30), _dialogueSpeaker.ToUpperInvariant());
            GUI.Label(new Rect(Screen.width * 0.54f, 212, Screen.width * 0.41f, 180), _dialogueLine);
            if (_choices.Count > 0)
            {
                for (int i = 0; i < _choices.Count && i < 9; i++)
                {
                    string label = (i + 1) + ". " + CleanDialogue(Field(_choices[i].fields, "Dialogue Text"));
                    if (GUI.Button(new Rect(Screen.width * 0.54f, 410 + i * 42, Screen.width * 0.39f, 34), label)) ChooseDialogue(_choices[i]);
                }
            }
            else GUI.Label(new Rect(Screen.width * 0.54f, Screen.height - 184, Screen.width * 0.39f, 32), "E / Space / Enter to continue. Backspace closes.");
        }

        if (_sheetOpen) DrawRecoveredSheet();
    }

    void DrawRecoveredSheet()
    {
        float w = 440f;
        GUI.Box(new Rect(18, 160, w, Screen.height - 310), "CHARACTER / PROGRESS");
        GUI.Label(new Rect(36, 194, w - 40, 28), "INT " + PlayerPrefs.GetInt("INT", 1) + "   PSY " + PlayerPrefs.GetInt("PSY", 1) + "   FYS " + PlayerPrefs.GetInt("FYS", 1) + "   MOT " + PlayerPrefs.GetInt("MOT", 1));
        GUI.Label(new Rect(36, 222, w - 40, 28), "Signature: " + PlayerPrefs.GetString("signatureSkill", "none"));
        GUI.Label(new Rect(36, 256, w - 40, 24), "Skills");
        string[] rows = {
            "INT: Logic, Encyclopedia, Rhetoric, Drama, Conceptualization, Visual Calculus",
            "PSY: Volition, Inland Empire, Empathy, Authority, Esprit de Corps, Suggestion",
            "FYS: Endurance, Pain Threshold, Physical Instrument, Electrochemistry, Shivers, Half Light",
            "MOT: Hand/Eye Coordination, Perception, Reaction Speed, Savoir Faire, Interfacing, Composure"
        };
        for (int i = 0; i < rows.Length; i++) GUI.Label(new Rect(36, 282 + i * 44, w - 52, 42), rows[i]);
        GUI.Label(new Rect(36, 474, w - 40, 24), "Recent consequences / scripts");
        if (_recentProgress.Count == 0) GUI.Label(new Rect(36, 502, w - 52, 28), "No recovered-scene checks or scripts recorded yet.");
        for (int i = 0; i < _recentProgress.Count; i++) GUI.Label(new Rect(36, 502 + i * 24, w - 52, 24), _recentProgress[i]);
    }
}
