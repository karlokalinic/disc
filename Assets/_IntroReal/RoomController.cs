// RoomController — 2.5D waking-up room. Fixed orthographic camera frames the REAL painted room
// backdrop (WhirlingF2.png); the REAL 3D Harry mesh moves across it. Head bubble over Harry, and
// the door stays LOCKED until he picks up his trousers (the keys jingle in the pocket).
// Only the controller logic is authored; room, figure and props are the game's own assets.
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using PixelCrushers.DialogueSystem;

public class RoomController : MonoBehaviour
{
    public DialogueDatabase database;

    Transform _harry, _pants, _door, _tie, _shoe, _bottle;
    Camera _cam;
    Animator _harryAnimator;
    Canvas _bubbleCanvas;
    TextMeshProUGUI _bubble, _banner, _skillName, _skillRoll, _skillResult, _skillHint, _inventoryText, _cinematicCaption;
    Image _skillPortrait, _skillPanel, _cinematicFade;
    AudioSource _sfx;
    SkinnedMeshRenderer[] _wearables;
    readonly Dictionary<string, Sprite> _portraits = new Dictionary<string, Sprite>();
    readonly Dictionary<string, Sprite> _inventoryIcons = new Dictionary<string, Sprite>();
    readonly List<string> _inventory = new List<string>();
    readonly List<Image> _inventorySlots = new List<Image>();
    readonly List<Hotspot> _hotspots = new List<Hotspot>();
    AssetBundle _portraitBundle;
    AssetBundle _inventoryBundle;

    bool _hasPants, _hasShoe, _hasTie, _unlocked, _cinematic;
    bool _hasClickTarget, _animHasForward;
    float _harryTop = 2.4f;
    float _harryScaleBase = 1f;
    float _skillPanelUntil;
    float _cinematicStart;
    float _bannerUntil;
    float _animForward;
    Vector3 _standPos;
    Vector3 _bottleStartPos;
    Vector3 _bottleEndPos;
    Vector3 _lastMove = Vector3.right;
    Vector3 _clickTarget;
    SkillSpec _mirrorCheck;
    string _hotspotPrompt = "";

    // movement box in the plane of the backdrop (half extents)
    const float HalfX = 5.95f, MinY = -4.6f, MaxY = 5.15f, Z = -1.2f, Speed = 2.65f;
    const float ClickArriveDistance = 0.08f;

    readonly string[] _abilities = { "INT", "PSY", "FYS", "MOT" };
    readonly Color[] _abilityColors = {
        new Color(0.70f,0.48f,0.78f), new Color(0.48f,0.62f,0.88f), new Color(0.82f,0.36f,0.28f), new Color(0.88f,0.70f,0.32f)
    };

    struct SkillSpec
    {
        public string name, portraitKey;
        public int ability, difficulty;
        public Color color;
        public string sourceNote;
        public SkillSpec(string name, string portraitKey, int ability, int difficulty, Color color)
        { this.name = name; this.portraitKey = portraitKey; this.ability = ability; this.difficulty = difficulty; this.color = color; this.sourceNote = ""; }
    }

    class Hotspot
    {
        public string label, action;
        public Vector2 pos;
        public float radius;
        public SkillSpec check;
        public System.Action success;
        public System.Func<bool> visible;
        public Hotspot(string label, Vector2 pos, float radius, SkillSpec check, string action, System.Action success = null, System.Func<bool> visible = null)
        { this.label = label; this.pos = pos; this.radius = radius; this.check = check; this.action = action; this.success = success; this.visible = visible; }
    }

    void Start()
    {
        _harry = FindT("Harry");
        _pants = FindT("PantsItem");
        _door  = FindT("RoomDoor");
        _tie = FindT("CeilingTie");
        _shoe = FindT("ThrownShoe");
        _bottle = FindT("Room_WhiskeyBottle");
        _harryAnimator = _harry != null ? _harry.GetComponent<Animator>() : null;
        ConfigureHarryAnimator();
        _harryScaleBase = _harry != null ? _harry.localScale.x : 1f;
        _wearables = _harry != null ? _harry.GetComponentsInChildren<SkinnedMeshRenderer>(true) : new SkinnedMeshRenderer[0];
        LoadSkillPortraits();
        LoadInventoryIcons();
        _mirrorCheck = FindSourceWhiteCheck("whirling.mirror_subdued_expression", new SkillSpec("ELECTROCHEMISTRY", "portrait_electrochemistry", 2, 6, _abilityColors[2]));
        BuildHotspots();
        BuildCamera();
        BuildUI();
        _sfx = gameObject.AddComponent<AudioSource>();
        StartGetUpCinematic();
    }

    void OnDestroy()
    {
        _portraitBundle = null;
        _inventoryBundle = null;
    }

    Transform FindT(string n){ var g=GameObject.Find(n); return g!=null?g.transform:null; }

    void BuildCamera()
    {
        var camGO = new GameObject("RoomCam");
        _cam = camGO.AddComponent<Camera>();
        camGO.AddComponent<AudioListener>();
        camGO.tag = "MainCamera";
        foreach (var c in FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None)) if (c != _cam) c.enabled = false;
        _cam.orthographic = true; _cam.orthographicSize = 6.6f;
        _cam.transform.position = new Vector3(0, 0, -18);
        _cam.transform.rotation = Quaternion.identity;
        _cam.nearClipPlane = 0.01f; _cam.farClipPlane = 60f;
        _cam.clearFlags = CameraClearFlags.SolidColor; _cam.backgroundColor = Color.black;
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Flat;
        RenderSettings.ambientLight = new Color(0.75f,0.72f,0.68f);
    }

    void BuildUI()
    {
        // world-space bubble over Harry's head
        var go = new GameObject("Bubble", typeof(Canvas));
        _bubbleCanvas = go.GetComponent<Canvas>(); _bubbleCanvas.renderMode = RenderMode.WorldSpace;
        var rt=(RectTransform)go.transform; rt.sizeDelta=new Vector2(360,110); rt.localScale=Vector3.one*0.006f;
        var bg=new GameObject("bg", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        bg.transform.SetParent(go.transform,false); bg.GetComponent<Image>().color=new Color(0.03f,0.03f,0.04f,0.86f);
        var brt=(RectTransform)bg.transform; brt.anchorMin=Vector2.zero; brt.anchorMax=Vector2.one; brt.offsetMin=Vector2.zero; brt.offsetMax=Vector2.zero;
        _bubble=NewText(go.transform,30); _bubble.alignment=TextAlignmentOptions.Center; _bubble.color=new Color(0.96f,0.94f,0.87f);
        var trt=_bubble.rectTransform; trt.anchorMin=Vector2.zero; trt.anchorMax=Vector2.one; trt.offsetMin=new Vector2(12,8); trt.offsetMax=new Vector2(-12,-8);
        _bubbleCanvas.gameObject.SetActive(false);

        var scr=new GameObject("Banner", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
        var bc=scr.GetComponent<Canvas>(); bc.renderMode=RenderMode.ScreenSpaceOverlay; bc.sortingOrder=200;
        var sca=scr.GetComponent<CanvasScaler>(); sca.uiScaleMode=CanvasScaler.ScaleMode.ScaleWithScreenSize; sca.referenceResolution=new Vector2(1920,1080);
        var strip=new GameObject("strip", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        strip.transform.SetParent(scr.transform,false);
        strip.GetComponent<Image>().color=new Color(0.02f,0.02f,0.025f,0.42f);
        var srt=(RectTransform)strip.transform; srt.anchorMin=new Vector2(0,0); srt.anchorMax=new Vector2(1,0); srt.offsetMin=new Vector2(0,18); srt.offsetMax=new Vector2(0,74);
        _banner=NewText(scr.transform,24); _banner.alignment=TextAlignmentOptions.Bottom; _banner.color=new Color(0.86f,0.82f,0.72f);
        var rr=_banner.rectTransform; rr.anchorMin=new Vector2(0,0); rr.anchorMax=new Vector2(1,0); rr.offsetMin=new Vector2(56,28); rr.offsetMax=new Vector2(-56,70);

        var invBg = new GameObject("InventoryStrip", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        invBg.transform.SetParent(scr.transform, false);
        invBg.GetComponent<Image>().color = new Color(0.018f,0.016f,0.013f,0.46f);
        var ir = (RectTransform)invBg.transform; ir.anchorMin = new Vector2(0,1); ir.anchorMax = new Vector2(1,1); ir.offsetMin = new Vector2(0,-46); ir.offsetMax = new Vector2(0,0);
        _inventoryText = NewText(invBg.transform, 18); _inventoryText.alignment = TextAlignmentOptions.Left; _inventoryText.color = new Color(0.88f,0.84f,0.68f);
        var itr = _inventoryText.rectTransform; itr.anchorMin = Vector2.zero; itr.anchorMax = Vector2.one; itr.offsetMin = new Vector2(390,6); itr.offsetMax = new Vector2(-32,-6);
        Text(invBg.transform, "INVENTORY", 18, new Color(0.62f,0.55f,0.40f), new Vector2(24, -34), new Vector2(166, -8), TextAlignmentOptions.Left);
        for (int i = 0; i < 8; i++)
        {
            var slot = new GameObject("InvSlot" + i, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
            slot.transform.SetParent(invBg.transform, false);
            var img = slot.GetComponent<Image>(); img.color = new Color(0.08f,0.07f,0.055f,0.82f); img.preserveAspect = true;
            var sr = (RectTransform)slot.transform; sr.anchorMin = new Vector2(0,1); sr.anchorMax = new Vector2(0,1); sr.sizeDelta = new Vector2(30,30); sr.anchoredPosition = new Vector2(176 + i * 28, -25);
            _inventorySlots.Add(img);
        }
        RefreshInventoryUI();

        BuildSkillPanel(scr.transform);

        _cinematicFade = new GameObject("CinematicFade", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image)).GetComponent<Image>();
        _cinematicFade.transform.SetParent(scr.transform, false); _cinematicFade.color = new Color(0,0,0,1f); _cinematicFade.raycastTarget = false;
        Stretch((RectTransform)_cinematicFade.transform);
        _cinematicCaption = NewText(scr.transform, 28); _cinematicCaption.alignment = TextAlignmentOptions.Center; _cinematicCaption.color = new Color(0.92f,0.88f,0.74f);
        var cr = _cinematicCaption.rectTransform; cr.anchorMin = new Vector2(0,0); cr.anchorMax = new Vector2(1,0); cr.offsetMin = new Vector2(140,136); cr.offsetMax = new Vector2(-140,210);
    }

    void BuildSkillPanel(Transform parent)
    {
        var panel = new GameObject("SkillResultPanel", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        panel.transform.SetParent(parent, false);
        _skillPanel = panel.GetComponent<Image>();
        _skillPanel.color = new Color(0.015f, 0.013f, 0.011f, 0.92f);
        var prt = (RectTransform)panel.transform;
        prt.anchorMin = new Vector2(1, 0.5f); prt.anchorMax = new Vector2(1, 0.5f);
        prt.sizeDelta = new Vector2(560, 340); prt.anchoredPosition = new Vector2(-320, 110);

        var portraitGO = new GameObject("Portrait", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        portraitGO.transform.SetParent(panel.transform, false);
        _skillPortrait = portraitGO.GetComponent<Image>(); _skillPortrait.preserveAspect = true;
        var irt = (RectTransform)portraitGO.transform; irt.anchorMin = new Vector2(0, 1); irt.anchorMax = new Vector2(0, 1);
        irt.sizeDelta = new Vector2(150, 150); irt.anchoredPosition = new Vector2(88, -88);

        _skillName = NewText(panel.transform, 31); _skillName.alignment = TextAlignmentOptions.Left;
        var nr = _skillName.rectTransform; nr.anchorMin = new Vector2(0,1); nr.anchorMax = new Vector2(1,1); nr.offsetMin = new Vector2(180, -86); nr.offsetMax = new Vector2(-28, -24);
        _skillRoll = NewText(panel.transform, 22); _skillRoll.alignment = TextAlignmentOptions.Left; _skillRoll.color = new Color(0.83f,0.79f,0.66f);
        var rr = _skillRoll.rectTransform; rr.anchorMin = new Vector2(0,1); rr.anchorMax = new Vector2(1,1); rr.offsetMin = new Vector2(180, -135); rr.offsetMax = new Vector2(-28, -92);
        _skillResult = NewText(panel.transform, 32); _skillResult.alignment = TextAlignmentOptions.Left; _skillResult.fontStyle = FontStyles.Bold;
        var sr = _skillResult.rectTransform; sr.anchorMin = new Vector2(0,1); sr.anchorMax = new Vector2(1,1); sr.offsetMin = new Vector2(28, -214); sr.offsetMax = new Vector2(-28, -148);
        _skillHint = NewText(panel.transform, 21); _skillHint.alignment = TextAlignmentOptions.Left; _skillHint.color = new Color(0.82f,0.80f,0.73f);
        var hr = _skillHint.rectTransform; hr.anchorMin = new Vector2(0,0); hr.anchorMax = new Vector2(1,0); hr.offsetMin = new Vector2(28, 28); hr.offsetMax = new Vector2(-28, 120);
        panel.SetActive(false);
    }

    static TextMeshProUGUI NewText(Transform p, float size)
    {
        var g=new GameObject("t", typeof(RectTransform), typeof(CanvasRenderer)); g.transform.SetParent(p,false);
        var t=g.AddComponent<TextMeshProUGUI>(); t.fontSize=size; t.richText=true; t.textWrappingMode=TextWrappingModes.Normal;
        if(TMP_Settings.defaultFontAsset!=null)t.font=TMP_Settings.defaultFontAsset; return t;
    }

    TextMeshProUGUI Text(Transform p, string s, float size, Color c, Vector2 a, Vector2 b, TextAlignmentOptions al)
    {
        var t = NewText(p, size); t.text = s; t.color = c; t.alignment = al;
        var r = t.rectTransform; r.anchorMin = new Vector2(0, 1); r.anchorMax = new Vector2(0, 1); r.offsetMin = a; r.offsetMax = b;
        return t;
    }

    static void Stretch(RectTransform r)
    {
        r.anchorMin = Vector2.zero; r.anchorMax = Vector2.one; r.offsetMin = Vector2.zero; r.offsetMax = Vector2.zero;
    }

    void Update()
    {
        if (_harry == null || _cam == null) return;

        if (_cinematic)
        {
            UpdateGetUpCinematic();
            return;
        }

        if (_skillPanel != null && _skillPanel.gameObject.activeSelf && Time.time > _skillPanelUntil)
            _skillPanel.gameObject.SetActive(false);
        if (_banner != null && !string.IsNullOrEmpty(_banner.text) && Time.time > _bannerUntil)
            _banner.text = "";

        ReadClickTarget();

        // move Harry across the painted floor (screen plane)
        Vector3 p = _harry.position;
        Vector3 moveDir = ReadMoveInput();
        bool hasKeyboardMove = moveDir.sqrMagnitude > 0.0001f;
        if (hasKeyboardMove)
        {
            _hasClickTarget = false;
            moveDir = Vector3.ClampMagnitude(moveDir, 1f);
        }
        else if (_hasClickTarget)
        {
            Vector3 toTarget = _clickTarget - p;
            toTarget.z = 0f;
            float distance = toTarget.magnitude;
            if (distance <= ClickArriveDistance)
            {
                _hasClickTarget = false;
                moveDir = Vector3.zero;
            }
            else
            {
                moveDir = toTarget / distance;
                moveDir *= Mathf.Clamp01(distance / Mathf.Max(ClickArriveDistance, Speed * Time.deltaTime));
            }
        }

        Vector3 mv = Vector3.ClampMagnitude(moveDir, 1f) * Speed * Time.deltaTime;
        p += mv;
        p = ClampRoomPosition(p);
        _harry.position = p;
        // subtle depth scale: further up the room = a touch smaller
        float depth = Mathf.InverseLerp(MinY, MaxY, p.y);
        _harry.localScale = Vector3.one * _harryScaleBase * Mathf.Lerp(1f, 0.75f, depth);
        bool isMoving = mv.sqrMagnitude > 0.00001f;
        if (isMoving)
        {
            _lastMove = mv.normalized;
            float lean = Mathf.Clamp(-_lastMove.x * 4f, -4f, 4f);
            _harry.rotation = Quaternion.Slerp(_harry.rotation, Quaternion.Euler(0f, 180f, lean), Time.deltaTime * 8f);
        }
        UpdateHarryAnimator(isMoving ? (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? 2f : 1f) : 0f);

        // bubble over head
        if (_bubbleCanvas.gameObject.activeSelf)
            _bubbleCanvas.transform.position = _harry.position + new Vector3(0, 2.0f, -0.3f);

        // pants pickup
        if (!_hasPants && _pants != null)
        {
            if (Vector2.Distance(new Vector2(p.x,p.y), new Vector2(_pants.position.x,_pants.position.y)) < 1.5f)
            {
                ShowBubble("Trousers   [E / Space]");
                if (InteractPressed())
                {
                    var check = new SkillSpec("INTERFACING", "portrait_interfacing", 3, 8, _abilityColors[3]);
                    ShowSkillCheck(check, "Search the pockets", PickUpPants);
                }
            }
            else HideBubbleIf("Trousers   [E / Space]");
        }
        // locked door
        if (_door != null && !_unlocked)
        {
            if (Vector2.Distance(new Vector2(p.x,p.y), new Vector2(_door.position.x,_door.position.y)) < 1.7f)
            {
                ShowBubble("Locked door   [E / Space]");
                if (InteractPressed())
                    ShowSkillCheck(new SkillSpec("VOLITION", "portrait_volition", 1, 9, _abilityColors[1]), "Leave the room", null);
            }
            else HideBubbleIf("Locked door   [E / Space]");
        }
        else if (_door != null && _unlocked)
        {
            if (Vector2.Distance(new Vector2(p.x,p.y), new Vector2(_door.position.x,_door.position.y)) < 1.7f)
            {
                ShowBubble("Hallway / balcony   [E / Space]");
                if (InteractPressed()) SceneManager.LoadScene("KlaasjeBalconyReal");
            }
            else HideBubbleIf("Hallway / balcony   [E / Space]");
        }

        if (_tie != null && Vector2.Distance(new Vector2(p.x,p.y), new Vector2(_tie.position.x,_tie.position.y)) < 1.8f)
        {
            ShowBubble("Necktie   [E / Space]");
            if (InteractPressed())
                ShowSkillCheck(new SkillSpec("INLAND EMPIRE", "portrait_inland-empire", 1, 10, _abilityColors[1]), "Assess the tie", () => { _hasTie = true; AddInventory("Necktie"); if (_tie != null) _tie.gameObject.SetActive(false); });
        }
        else HideBubbleIf("Necktie   [E / Space]");

        if (!_hasShoe && _shoe != null && _shoe.gameObject.activeSelf && Vector2.Distance(new Vector2(p.x,p.y), new Vector2(_shoe.position.x,_shoe.position.y)) < 1.5f)
        {
            ShowBubble("Shoe   [E / Space]");
            if (InteractPressed())
            {
                var check = new SkillSpec("PERCEPTION", "portrait_perception", 3, 7, _abilityColors[3]);
                ShowSkillCheck(check, "Recover the shoe", () => { _hasShoe = true; AddInventory("Shoe"); _shoe.gameObject.SetActive(false); ShowBubble("Shoe recovered."); });
            }
        }
        else HideBubbleIf("Shoe   [E / Space]");

        Vector2 mirror = new Vector2(5.05f, 5.00f);
        if (Vector2.Distance(new Vector2(p.x, p.y), mirror) < 1.55f)
        {
            ShowBubble("Bathroom mirror   [E / Space]");
            if (InteractPressed()) ShowSkillCheck(_mirrorCheck, "Source white check", null);
        }
        else HideBubbleIf("Bathroom mirror   [E / Space]");

        TryRoomHotspots(new Vector2(p.x, p.y));
    }

    Vector3 ReadMoveInput()
    {
        float x = 0f, y = 0f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) x -= 1f;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) x += 1f;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) y -= 1f;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) y += 1f;
        if (Mathf.Abs(x) < 0.01f) x = Input.GetAxisRaw("Horizontal");
        if (Mathf.Abs(y) < 0.01f) y = Input.GetAxisRaw("Vertical");
        return new Vector3(x, y, 0f);
    }

    bool InteractPressed()
    {
        return Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return);
    }

    void StartGetUpCinematic()
    {
        if (_harry == null) return;
        _cinematic = true;
        _cinematicStart = Time.time;
        _standPos = new Vector3(-3.25f, -2.05f, Z);
        _harry.position = new Vector3(-4.0f, -3.15f, Z);
        _harry.rotation = Quaternion.Euler(0f, 180f, 78f);
        _harry.localScale = Vector3.one * _harryScaleBase * 1.05f;
        if (_harryAnimator != null && _harryAnimator.enabled) _harryAnimator.Play("Get Up From Bed", 0, 0f);
        if (_bottle != null)
        {
            _bottleEndPos = _bottle.position;
            _bottleStartPos = new Vector3(-4.34f, -3.35f, Z - 0.02f);
            _bottle.position = _bottleStartPos;
            _bottle.rotation = Quaternion.Euler(0f, 0f, -72f);
        }
        Banner("");
        if (_bubbleCanvas != null) _bubbleCanvas.gameObject.SetActive(false);
    }

    void UpdateGetUpCinematic()
    {
        float t = Time.time - _cinematicStart;
        float k = Mathf.SmoothStep(0f, 1f, Mathf.Clamp01(t / 4.2f));
        _harry.position = Vector3.Lerp(new Vector3(-4.0f, -3.15f, Z), _standPos, k);
        _harry.rotation = Quaternion.Slerp(Quaternion.Euler(0f, 180f, 78f), Quaternion.Euler(0f, 180f, 0f), k);
        _harry.localScale = Vector3.one * _harryScaleBase * Mathf.Lerp(1.05f, 1f, k);
        if (_bottle != null)
        {
            float bk = Mathf.SmoothStep(0f, 1f, Mathf.Clamp01(t / 2.4f));
            _bottle.position = Vector3.Lerp(_bottleStartPos, _bottleEndPos, bk);
            _bottle.Rotate(0f, 0f, -240f * Time.deltaTime, Space.Self);
        }
        if (_cinematicFade != null) _cinematicFade.color = new Color(0f, 0f, 0f, Mathf.Clamp01(1f - t / 1.5f));
        if (_cinematicCaption != null) _cinematicCaption.text = t < 3.8f ? "" : "WASD / arrows to move. E / Space to inspect.";
        if (t >= 4.8f || InteractPressed())
        {
            _cinematic = false;
            if (_harryAnimator != null && _harryAnimator.enabled) _harryAnimator.Play("Player Movement", 0, 0f);
            if (_cinematicFade != null) _cinematicFade.gameObject.SetActive(false);
            if (_cinematicCaption != null) _cinematicCaption.text = "";
            Banner("Room 1. Left-click to walk. WASD/arrows also move. Use E or Space near objects.");
        }
    }

    void ConfigureHarryAnimator()
    {
        if (_harryAnimator == null) return;
        _harryAnimator.applyRootMotion = false;
        _harryAnimator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        _harryAnimator.updateMode = AnimatorUpdateMode.Normal;
        _harryAnimator.enabled = _harryAnimator.runtimeAnimatorController != null;
        _animHasForward = false;
        if (_harryAnimator.runtimeAnimatorController == null) return;

        foreach (var p in _harryAnimator.parameters)
        {
            if (p.name == "Forward" && p.type == AnimatorControllerParameterType.Float)
            {
                _animHasForward = true;
                break;
            }
        }
        if (_animHasForward) _harryAnimator.Play("Player Movement", 0, 0f);
    }

    void ReadClickTarget()
    {
        if (_cam == null || !Input.GetMouseButtonDown(0)) return;
        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject()) return;

        float distance = Z - _cam.transform.position.z;
        Vector3 world = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance));
        world.z = Z;
        _clickTarget = ClampRoomPosition(world);
        _hasClickTarget = true;
    }

    Vector3 ClampRoomPosition(Vector3 p)
    {
        p.x = Mathf.Clamp(p.x, -HalfX, HalfX);
        p.y = Mathf.Clamp(p.y, MinY + _harryTop * 0.5f, MaxY);
        p.z = Z;
        return p;
    }

    void UpdateHarryAnimator(float targetForward)
    {
        if (_harryAnimator == null || !_harryAnimator.enabled || !_animHasForward) return;
        _animForward = Mathf.MoveTowards(_animForward, targetForward, Time.deltaTime * 6f);
        _harryAnimator.SetFloat("Forward", _animForward);
    }

    void BuildHotspots()
    {
        _hotspots.Clear();
        _hotspots.Add(SourceHotspot("Bathtub", new Vector2(-0.1f, 3.15f), 1.0f, new SkillSpec("PERCEPTION", "portrait_perception", 3, 8, _abilityColors[3]), "Inspect the bath", "Props whirling f2/clickable_whirling2nd_bath"));
        _hotspots.Add(SourceHotspot("Broken window", new Vector2(-3.85f, -3.18f), 1.25f, new SkillSpec("VISUAL CALCULUS", "portrait_visual-calculus_rank1", 0, 8, _abilityColors[0]), "Inspect the broken window", "Props whirling f2/clickable_whirling2nd_broken_window"));
        _hotspots.Add(SourceHotspot("Tape player", new Vector2(3.15f, -1.85f), 1.05f, new SkillSpec("INTERFACING", "portrait_interfacing", 3, 7, _abilityColors[3]), "Examine the tape player", "Props whirling f2/clickable_whirling2nd_tapeplayer"));
        _hotspots.Add(SourceHotspot("Tape reels", new Vector2(2.3f, -1.2f), 0.95f, new SkillSpec("ENCYCLOPEDIA", "portrait_encyclopedia", 0, 7, _abilityColors[0]), "Inspect the reels", "Props whirling f2/tapereels"));
        _hotspots.Add(SourceHotspot("Radio", new Vector2(2.45f, -2.6f), 1.05f, new SkillSpec("INTERFACING", "portrait_interfacing", 3, 8, _abilityColors[3]), "Inspect the radio", "Props whirling f2/Int_Radio_Whirling"));
        _hotspots.Add(SourceHotspot("Empty bottles", new Vector2(1.5f, -3.85f), 1.0f, new SkillSpec("ELECTROCHEMISTRY", "portrait_electrochemistry", 2, 8, _abilityColors[2]), "Count the empties", "Props whirling f2/Empty bottles whirling-2"));
        _hotspots.Add(SourceHotspot("Medical supplies", new Vector2(4.25f, -2.25f), 0.9f, new SkillSpec("ENDURANCE", "portrait_endurance", 2, 7, _abilityColors[2]), "Check medical supplies", "Props whirling f2/int-medical-supplies"));
        _hotspots.Add(SourceHotspot("Bed mess", new Vector2(-4.0f, -3.35f), 1.15f, new SkillSpec("INLAND EMPIRE", "portrait_inland-empire", 1, 8, _abilityColors[1]), "Inspect the bed", "Props whirling f2/clickable_whirling2nd_tequila_bed_messy"));
        _hotspots.Add(SourceHotspot("Left-side couch", new Vector2(-5.25f, -1.60f), 1.35f, new SkillSpec("ENDURANCE", "portrait_endurance", 2, 7, _abilityColors[2]), "Inspect the far-left couch", "WhirlingF2 painted left couch/bed area"));
        _hotspots.Add(SourceHotspot("Shelves", new Vector2(3.3f, 0.7f), 1.0f, new SkillSpec("COMPOSURE", "portrait_composure", 3, 7, _abilityColors[3]), "Inspect the shelves", "Props whirling f2/clickable_whirling2nd_shelves"));
        _hotspots.Add(SourceHotspot("Faucet", new Vector2(-0.85f, 2.1f), 0.95f, new SkillSpec("INTERFACING", "portrait_interfacing", 3, 10, _abilityColors[3]), "Inspect the faucet", "Props whirling f2/Faucet FX Manager"));
    }

    Hotspot SourceHotspot(string label, Vector2 pos, float radius, SkillSpec check, string action, string source)
    {
        check.sourceNote = "Source object: " + source;
        return new Hotspot(label, pos, radius, check, action);
    }

    void TryRoomHotspots(Vector2 player)
    {
        foreach (var h in _hotspots)
        {
            if (h.visible != null && !h.visible()) continue;
            if (Vector2.Distance(player, h.pos) > h.radius) continue;
            string prompt = h.label + "   [E / Space]";
            _hotspotPrompt = prompt;
            ShowBubble(prompt);
            if (InteractPressed()) ShowSkillCheck(h.check, h.action, h.success);
            return;
        }
        if (!string.IsNullOrEmpty(_hotspotPrompt)) HideBubbleIf(_hotspotPrompt);
    }

    void PickUpPants()
    {
        _hasPants = true; _unlocked = true;
        if (_pants != null) _pants.gameObject.SetActive(false);
        AddInventory("Trousers");
        AddInventory("Room key");
        foreach (var smr in _wearables)
        {
            string n = smr.name.ToLowerInvariant();
            if (n.Contains("tequila_pants") || n.Contains("shoes")) smr.gameObject.SetActive(true);
        }
        if (_door != null) _door.gameObject.SetActive(false);
        var clip = Resources.Load<AudioClip>("keys"); if (clip != null) _sfx.PlayOneShot(clip);
        ShowBubble("*jingle* — the keys are in the pocket. The door is unlocked.");
        Banner("Trousers on. Keys in your pocket. The door will open now.");
    }

    void LoadSkillPortraits()
    {
        string aa = Path.Combine(Application.streamingAssetsPath, "aa/StandaloneWindows64");
        if (!Directory.Exists(aa)) return;
        var files = Directory.GetFiles(aa, "portraits*.bundle");
        if (files.Length == 0) return;
        _portraitBundle = RecoveredRuntimeServices.LoadBundleCached(files[0]);
        if (_portraitBundle == null) return;
        foreach (var tex in _portraitBundle.LoadAllAssets<Texture2D>())
            _portraits[tex.name.ToLowerInvariant()] = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
    }

    void LoadInventoryIcons()
    {
        string aa = Path.Combine(Application.streamingAssetsPath, "aa/StandaloneWindows64");
        if (!Directory.Exists(aa)) return;
        var files = Directory.GetFiles(aa, "*invetory*icons*.bundle");
        if (files.Length == 0) files = Directory.GetFiles(aa, "*inventory*icons*.bundle");
        if (files.Length == 0) return;
        _inventoryBundle = RecoveredRuntimeServices.LoadBundleCached(files[0]);
        if (_inventoryBundle == null) return;
        foreach (var tex in _inventoryBundle.LoadAllAssets<Texture2D>())
            _inventoryIcons[tex.name.ToLowerInvariant()] = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
    }

    void AddInventory(string item)
    {
        if (string.IsNullOrEmpty(item) || _inventory.Contains(item)) return;
        _inventory.Add(item);
        RefreshInventoryUI();
    }

    void RefreshInventoryUI()
    {
        if (_inventoryText != null) _inventoryText.text = _inventory.Count == 0 ? "empty" : string.Join("   |   ", _inventory.ToArray());
        for (int i = 0; i < _inventorySlots.Count; i++)
        {
            var slot = _inventorySlots[i];
            if (i >= _inventory.Count) { slot.sprite = null; slot.color = new Color(0.08f,0.07f,0.055f,0.82f); continue; }
            slot.sprite = FindInventorySprite(_inventory[i]);
            slot.color = slot.sprite != null ? Color.white : new Color(0.20f,0.16f,0.11f,0.92f);
        }
    }

    Sprite FindInventorySprite(string item)
    {
        string key = item.ToLowerInvariant().Replace(" ", "-");
        foreach (var kv in _inventoryIcons)
            if (kv.Key.Contains(key) || key.Contains(kv.Key)) return kv.Value;
        if (item == "Trousers") foreach (var kv in _inventoryIcons) if (kv.Key.Contains("pants") || kv.Key.Contains("trousers")) return kv.Value;
        if (item == "Room key") foreach (var kv in _inventoryIcons) if (kv.Key.Contains("key")) return kv.Value;
        if (item == "Shoe") foreach (var kv in _inventoryIcons) if (kv.Key.Contains("shoe")) return kv.Value;
        if (item == "Necktie") foreach (var kv in _inventoryIcons) if (kv.Key.Contains("tie") || kv.Key.Contains("neck")) return kv.Value;
        return null;
    }

    int AbilityValue(int ability)
    {
        int value = PlayerPrefs.GetInt(_abilities[Mathf.Clamp(ability, 0, 3)], 1);
        return Mathf.Clamp(value, 1, 6);
    }

    int SkillValue(SkillSpec spec)
    {
        int value = AbilityValue(spec.ability);
        string signature = PlayerPrefs.GetString("signatureSkill", "");
        if (!string.IsNullOrEmpty(signature) && string.Equals(signature.Replace("/", " "), spec.name, System.StringComparison.OrdinalIgnoreCase))
            value += 1;
        return value;
    }

    void ShowSkillCheck(SkillSpec spec, string action, System.Action onSuccess)
    {
        int d1 = Random.Range(1, 7);
        int d2 = Random.Range(1, 7);
        int skill = SkillValue(spec);
        int total = d1 + d2 + skill;
        bool critFail = d1 == 1 && d2 == 1;
        bool critSuccess = d1 == 6 && d2 == 6;
        bool success = critSuccess || (!critFail && total >= spec.difficulty);

        if (_skillPanel != null)
        {
            _skillPanel.gameObject.SetActive(true);
            _skillPanel.color = success ? new Color(0.025f, 0.07f, 0.045f, 0.94f) : new Color(0.08f, 0.025f, 0.018f, 0.94f);
            _skillName.text = spec.name;
            _skillName.color = spec.color;
            _skillRoll.text = action + "  |  " + d1 + " + " + d2 + " + " + skill + " = " + total + " / " + spec.difficulty;
            _skillResult.text = success ? (critSuccess ? "CRITICAL SUCCESS" : "SUCCESS") : (critFail ? "CRITICAL FAILURE" : "FAILURE");
            _skillResult.color = success ? new Color(0.74f, 0.93f, 0.65f) : new Color(0.95f, 0.42f, 0.32f);
            string note = string.IsNullOrEmpty(spec.sourceNote) ? "" : "\n" + spec.sourceNote;
            _skillHint.text = (success ? "Check passed. The interaction resolves." : "Check failed. Improve the relevant faculty or try another interaction.") + note;
            _skillPortrait.sprite = null;
            if (_portraits.TryGetValue(spec.portraitKey.ToLowerInvariant(), out var sp)) _skillPortrait.sprite = sp;
            _skillPortrait.color = sp != null ? Color.white : new Color(spec.color.r, spec.color.g, spec.color.b, 0.4f);
            _skillPanelUntil = Time.time + 4.5f;
        }

        if (success && onSuccess != null) onSuccess();
        if (!success) Banner(spec.name + " check failed. Roll " + total + " / " + spec.difficulty + ".");
    }

    SkillSpec FindSourceWhiteCheck(string flagName, SkillSpec fallback)
    {
        if (database == null) return fallback;

        var skillByArticy = new Dictionary<string, SkillSpec>();
        foreach (var actor in database.actors)
        {
            string articy = DbField(actor.fields, "Articy Id");
            string name = DbField(actor.fields, "Name");
            if (string.IsNullOrEmpty(articy) || string.IsNullOrEmpty(name)) continue;
            string portrait = ExtractPortraitKey(DbField(actor.fields, "Pictures"));
            int ability = AbilityForSkill(name);
            Color color = _abilityColors[Mathf.Clamp(ability, 0, 3)];
            skillByArticy[articy] = new SkillSpec(name.ToUpperInvariant(), portrait, ability, fallback.difficulty, color);
        }

        foreach (var conversation in database.conversations)
        foreach (var entry in conversation.dialogueEntries)
        {
            if (DbField(entry.fields, "FlagName") != flagName) continue;

            var spec = fallback;
            string skillId = DbField(entry.fields, "SkillType");
            if (!string.IsNullOrEmpty(skillId) && skillByArticy.TryGetValue(skillId, out var mapped)) spec = mapped;
            if (int.TryParse(DbField(entry.fields, "DifficultyWhite"), out int diff)) spec.difficulty = diff;

            var notes = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                string mod = DbField(entry.fields, "modifier" + i);
                string tip = DbField(entry.fields, "tooltip" + i);
                if (!string.IsNullOrEmpty(mod) && !string.IsNullOrEmpty(tip)) notes.Add(mod + " " + tip);
            }
            spec.sourceNote = "Source: " + flagName + (notes.Count > 0 ? " | DB modifiers: " + string.Join("; ", notes.ToArray()) : "");
            return spec;
        }

        return fallback;
    }

    int AbilityForSkill(string skill)
    {
        skill = (skill ?? "").ToLowerInvariant();
        if (skill == "logic" || skill == "encyclopedia" || skill == "rhetoric" || skill == "drama" || skill == "conceptualization" || skill == "visual calculus") return 0;
        if (skill == "volition" || skill == "inland empire" || skill == "empathy" || skill == "authority" || skill == "esprit de corps" || skill == "suggestion") return 1;
        if (skill == "endurance" || skill == "pain threshold" || skill == "physical instrument" || skill == "electrochemistry" || skill == "shivers" || skill == "half light") return 2;
        return 3;
    }

    static string DbField(List<Field> fields, string title)
    {
        if (fields == null) return null;
        foreach (var field in fields) if (field != null && field.title == title) return field.value;
        return null;
    }

    static string ExtractPortraitKey(string value)
    {
        if (string.IsNullOrEmpty(value)) return null;
        int start = value.IndexOf("portrait_", System.StringComparison.OrdinalIgnoreCase);
        if (start < 0) return null;
        int end = value.IndexOf('.', start);
        if (end < 0) end = value.IndexOf(']', start);
        if (end < 0) end = value.Length;
        return value.Substring(start, end - start).ToLowerInvariant();
    }

    string _bubbleText="";
    void ShowBubble(string s){ _bubbleText=s; if(string.IsNullOrEmpty(s)){_bubbleCanvas.gameObject.SetActive(false);return;} _bubble.text=s; _bubbleCanvas.gameObject.SetActive(true); _bubbleCanvas.transform.rotation=Quaternion.identity; }
    void HideBubbleIf(string s){ if(_bubbleText==s){ _bubbleCanvas.gameObject.SetActive(false); _bubbleText=""; } }
    void Banner(string s){ if(_banner!=null){_banner.text=s; _bannerUntil=Time.time+5f;} }
}
