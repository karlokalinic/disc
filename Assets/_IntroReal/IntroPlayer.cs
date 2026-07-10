// IntroPlayer — plays the REAL opening conversation (conv 8 "WHIRLING / DREAM1") from the recovered
// Dialogue Database with the game's REAL voice-over, REAL portraits and a Disco-style right-hand
// dialogue box (vertical scrolling log, white narration, red choices). It contains NO authored
// dialogue/art — every line, clip and image is read live from the user's own extracted files.
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;
using PixelCrushers.DialogueSystem;

public class IntroPlayer : MonoBehaviour
{
    public DialogueDatabase database;
    public int conversationId = 8;   // WHIRLING / DREAM1

    static readonly Color White   = new Color(0.96f, 0.94f, 0.87f);
    static readonly Color Cream    = new Color(0.86f, 0.82f, 0.72f);
    static readonly Color ChoiceRed = new Color(0.86f, 0.30f, 0.22f);
    static readonly Color PanelBg   = new Color(0.05f, 0.05f, 0.06f, 0.86f);

    Conversation _conv;
    HashSet<int> _playerActors = new HashSet<int>();
    Dictionary<int,string> _actorName = new Dictionary<int,string>();
    Dictionary<int,string> _actorPortrait = new Dictionary<int,string>();
    string _playerPortraitName;
    readonly Dictionary<string,AudioClip> _vo = new Dictionary<string,AudioClip>();
    readonly Dictionary<string,Sprite> _portraits = new Dictionary<string,Sprite>();
    readonly List<AssetBundle> _bundles = new List<AssetBundle>();

    Canvas _canvas;
    Image _portrait, _fade;
    TextMeshProUGUI _speakerLabel, _hint;
    ScrollRect _scroll;
    RectTransform _logContent, _choices;
    AudioSource _audio;
    System.Action _continue;
    int _steps;

    IEnumerator Start()
    {
        BuildUI();
        _audio = gameObject.AddComponent<AudioSource>();
        if (database == null) { _hint.text = "No dialogue database assigned."; yield break; }

        foreach (var a in database.actors)
        {
            _actorName[a.id] = Field(a.fields, "Name");
            string pn = ExtractPortrait(Field(a.fields, "Pictures"));
            if (pn != null) _actorPortrait[a.id] = pn;
            var ip = Field(a.fields, "IsPlayer");
            if (ip != null && ip.Trim().Equals("True", System.StringComparison.OrdinalIgnoreCase))
            { _playerActors.Add(a.id); if (pn != null) _playerPortraitName = pn; }
        }
        foreach (var c in database.conversations) if (c.id == conversationId) { _conv = c; break; }
        if (_conv == null) { _hint.text = "Opening conversation not found."; yield break; }
        string convTitle = Field(_conv.fields, "Title");

        _hint.text = "loading voice-over…";
        yield return null;
        LoadPortraits();
        LoadVO(convTitle);
        _hint.text = "";

        // fade up from black
        yield return Fade(1f, 0f, 1.2f);

        DialogueEntry start = null;
        foreach (var e in _conv.dialogueEntries) if (e.id == 0) { start = e; break; }
        if (start == null) start = _conv.dialogueEntries[0];
        Follow(start);
    }

    // ---- traversal ----
    void Follow(DialogueEntry from)
    {
        if (++_steps > 5000) { End(); return; }
        var next = Resolve(from);
        var npc = new List<DialogueEntry>(); var pc = new List<DialogueEntry>();
        foreach (var e in next) { if (IsPlayer(e)) pc.Add(e); else npc.Add(e); }
        if (pc.Count > 0) ShowResponses(pc);
        else if (npc.Count > 0) ShowLine(npc[0]);
        else End();
    }

    List<DialogueEntry> Resolve(DialogueEntry from)
    {
        var list = new List<DialogueEntry>();
        if (from.outgoingLinks == null) return list;
        foreach (var lk in from.outgoingLinks)
        {
            if (lk.destinationConversationID != _conv.id) continue;
            foreach (var e in _conv.dialogueEntries) if (e.id == lk.destinationDialogueID) { list.Add(e); break; }
        }
        return list;
    }

    void ShowLine(DialogueEntry e)
    {
        int aid = ActorId(e);
        string an = _actorName.ContainsKey(aid) ? _actorName[aid] : "";
        string text = Field(e.fields, "Dialogue Text");
        if (string.IsNullOrEmpty(StripTags(text))) { Follow(e); return; }

        SetPortraitFor(aid, text);
        _speakerLabel.text = an.ToUpper(); _speakerLabel.color = VoiceColor(an);
        AddLog(an, VoiceColor(an), CleanInline(text), White);
        ClearChoices();
        AudioClip clip = LookupVO(an, e.id);
        if (clip != null) { _audio.Stop(); _audio.clip = clip; _audio.Play(); }
        _hint.text = "▼  click / space";
        _continue = () => Follow(e);
    }

    void ShowResponses(List<DialogueEntry> pc)
    {
        if (pc.Count == 1 && string.IsNullOrEmpty(StripTags(Field(pc[0].fields, "Dialogue Text")))) { Follow(pc[0]); return; }
        _continue = null; _hint.text = "choose a reply";
        // Harry is unknown to himself during the opening dream; don't show his portrait here.
        SetPortraitByName(null);
        _speakerLabel.text = "YOU"; _speakerLabel.color = ChoiceRed;
        ClearChoices();
        for (int i = 0; i < pc.Count && i < 16; i++)
        {
            var e = pc[i];
            string label = (i + 1) + ".  " + CleanInline(Field(e.fields, "Dialogue Text"));
            var ee = e;
            MakeChoice(label, () => { ClearChoices(); ShowChosen(ee); });
        }
    }

    void ShowChosen(DialogueEntry chosen)
    {
        // Harry is unknown to himself during the opening dream; don't show his portrait here.
        SetPortraitByName(null);
        _speakerLabel.text = "YOU"; _speakerLabel.color = ChoiceRed;
        AddLog("YOU", ChoiceRed, CleanInline(Field(chosen.fields, "Dialogue Text")), ChoiceRed);
        AudioClip clip = LookupVO("You", chosen.id);
        if (clip != null) { _audio.Stop(); _audio.clip = clip; _audio.Play(); }
        _hint.text = "▼  click / space";
        _continue = () => Follow(chosen);
    }

    void End()
    {
        ClearChoices();
        _hint.text = "";
        _continue = null;
        StartCoroutine(EndSequence());
    }

    IEnumerator EndSequence()
    {
        // the dream ends -> fade to black -> real waking-up room.
        yield return new WaitForSeconds(1.2f);
        yield return Fade(0f, 1f, 2f);
        _speakerLabel.text = ""; _hint.text = "— you wake up —";
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("RoomReal");
    }

    void Update()
    {
        if (_continue != null && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)))
        { var c = _continue; _continue = null; c(); }
    }

    // ---- real-asset loading ----
    string AAPath => Path.Combine(Application.streamingAssetsPath, "aa/StandaloneWindows64");

    void LoadVO(string convTitle)
    {
        if (!Directory.Exists(AAPath)) return;
        var tokens = new HashSet<string>();
        foreach (var e in _conv.dialogueEntries) { int aid = ActorId(e); if (_actorName.ContainsKey(aid)) tokens.Add(BundleToken(_actorName[aid])); }
        string needle = Collapse(convTitle);
        foreach (var bp in Directory.GetFiles(AAPath, "*whirling*.bundle"))
        {
            string bn = Path.GetFileName(bp).ToLower(); bool want = false;
            foreach (var t in tokens) if (t.Length > 2 && bn.Contains(t)) { want = true; break; }
            if (!want) continue;
            AssetBundle ab = null; try { ab = AssetBundle.LoadFromFile(bp); } catch { }
            if (ab == null) continue; _bundles.Add(ab);
            foreach (var n in ab.GetAllAssetNames())
            {
                if (!n.EndsWith(".wav")) continue;
                var m = Regex.Match(Path.GetFileNameWithoutExtension(n), @"^(?<actor>.+?)-(?<conv>.+)-(?<id>\d+)(?:-\d+)?$");
                if (!m.Success || !Collapse(m.Groups["conv"].Value).Contains(needle)) continue;
                string key = m.Groups["actor"].Value.ToLower() + "|" + m.Groups["id"].Value;
                if (_vo.ContainsKey(key)) continue;
                var clip = ab.LoadAsset<AudioClip>(n); if (clip != null) _vo[key] = clip;
            }
        }
    }
    AudioClip LookupVO(string actorName, int id){ return _vo.TryGetValue(actorName.ToLower() + "|" + id, out var c) ? c : null; }

    void LoadPortraits()
    {
        if (!Directory.Exists(AAPath)) return;
        var pf = Directory.GetFiles(AAPath, "portraits*.bundle"); if (pf.Length == 0) return;
        AssetBundle ab = RecoveredRuntimeServices.LoadBundleCached(pf[0]);
        if (ab == null) return;
        foreach (var t in ab.LoadAllAssets<Texture2D>())
            _portraits[t.name.ToLower()] = Sprite.Create(t, new Rect(0, 0, t.width, t.height), new Vector2(0.5f, 0.5f));
    }

    void SetPortraitByName(string pname)
    {
        Sprite sp = null;
        if (!string.IsNullOrEmpty(pname)) _portraits.TryGetValue(StripExt(pname).ToLower(), out sp);
        _portrait.sprite = sp; _portrait.color = sp != null ? Color.white : new Color(1,1,1,0);
    }
    void SetPortraitFor(int actorId, string text)
    {
        string inline = ExtractPortrait(text);
        SetPortraitByName(inline ?? (_actorPortrait.TryGetValue(actorId, out var p) ? p : null));
    }

    // ---- helpers ----
    static string Field(List<Field> f, string t){ if(f==null)return null; foreach(var x in f) if(x!=null&&x.title==t) return x.value; return null; }
    int ActorId(DialogueEntry e){ int.TryParse(Field(e.fields,"Actor"), out int id); return id; }
    bool IsPlayer(DialogueEntry e){ return _playerActors.Contains(ActorId(e)); }
    static string BundleToken(string a){ return string.IsNullOrEmpty(a)?"":Regex.Replace(a.ToLower().Trim()," +","-"); }
    static string StripTags(string s){ return s==null?"":Regex.Replace(s, @"\[.*?\]|<.*?>","").Trim(); }
    static string CleanInline(string s){ return s==null?"":Regex.Replace(s, @"\[[a-zA-Z0-9_.\-]+\.(png|jpg)\]","").Trim(); }
    static string ExtractPortrait(string s){ if(string.IsNullOrEmpty(s))return null; var m=Regex.Match(s, @"\[(portrait_[a-zA-Z0-9_.\-]+\.(?:png|jpg))\]"); return m.Success?m.Groups[1].Value:null; }
    static string StripExt(string s){ int i=s.LastIndexOf('.'); return i>0?s.Substring(0,i):s; }
    static string Collapse(string s){ return s==null?"":Regex.Replace(s.Trim().Replace("/"," "), @"\s+", " ").ToLower(); }
    static Color VoiceColor(string an){ an=an?.ToLower()??""; if(an.Contains("reptilian"))return new Color(0.70f,0.50f,0.80f); if(an.Contains("limbic"))return new Color(0.55f,0.72f,0.90f); if(an.Contains("inland"))return new Color(0.78f,0.60f,0.90f); if(an=="you")return ChoiceRed; return new Color(0.80f,0.72f,0.55f); }
    void OnDestroy(){ foreach(var b in _bundles) if(b!=null) b.Unload(false); }

    // ---- UI ----
    void BuildUI()
    {
        if (FindAnyObjectByType<EventSystem>() == null) new GameObject("EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
        RecoveredRuntimeServices.EnsureSingleEventSystem();
        var cgo = new GameObject("IntroCanvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
        _canvas = cgo.GetComponent<Canvas>(); _canvas.renderMode = RenderMode.ScreenSpaceOverlay; _canvas.sortingOrder = 100;
        var sc = cgo.GetComponent<CanvasScaler>(); sc.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize; sc.referenceResolution = new Vector2(1920,1080); sc.matchWidthOrHeight = 1f;

        var bg = NewImage(cgo.transform, new Color(0.015f,0.015f,0.02f,1)); Stretch(bg.rectTransform);

        // right-hand dialogue panel (~46% width)
        var panel = NewImage(cgo.transform, PanelBg);
        Anchor(panel.rectTransform, new Vector2(0.54f,0), new Vector2(1,1), new Vector2(0,0), new Vector2(0,0));

        _portrait = NewImage(panel.transform, new Color(1,1,1,0));
        var prt = _portrait.rectTransform; prt.anchorMin=new Vector2(0,1); prt.anchorMax=new Vector2(0,1); prt.pivot=new Vector2(0,1);
        prt.anchoredPosition=new Vector2(40,-40); prt.sizeDelta=new Vector2(240,240); _portrait.preserveAspect=true;

        _speakerLabel = NewText(panel.transform, 38, TextAlignmentOptions.TopLeft);
        Anchor(_speakerLabel.rectTransform, new Vector2(0,1), new Vector2(1,1), new Vector2(300,-120), new Vector2(-40,-40));
        _speakerLabel.fontStyle = FontStyles.Bold;

        // scrolling log
        var scrollGO = new GameObject("Log", typeof(RectTransform), typeof(ScrollRect), typeof(Image));
        scrollGO.transform.SetParent(panel.transform,false); scrollGO.GetComponent<Image>().color=new Color(0,0,0,0.001f);
        _scroll = scrollGO.GetComponent<ScrollRect>(); _scroll.horizontal=false; _scroll.vertical=true; _scroll.scrollSensitivity=30;
        Anchor((RectTransform)scrollGO.transform, new Vector2(0,0), new Vector2(1,1), new Vector2(40,300), new Vector2(-40,-300));

        var viewport = new GameObject("Viewport", typeof(RectTransform), typeof(RectMask2D), typeof(Image));
        viewport.transform.SetParent(scrollGO.transform,false); viewport.GetComponent<Image>().color=new Color(0,0,0,0.001f);
        Stretch((RectTransform)viewport.transform); _scroll.viewport=(RectTransform)viewport.transform;

        var content = new GameObject("Content", typeof(RectTransform), typeof(VerticalLayoutGroup), typeof(ContentSizeFitter));
        content.transform.SetParent(viewport.transform,false); _logContent=(RectTransform)content.transform;
        _logContent.anchorMin=new Vector2(0,1); _logContent.anchorMax=new Vector2(1,1); _logContent.pivot=new Vector2(0.5f,1); _logContent.offsetMin=new Vector2(0,0); _logContent.offsetMax=new Vector2(0,0);
        var vlg=content.GetComponent<VerticalLayoutGroup>(); vlg.childControlWidth=true; vlg.childControlHeight=true; vlg.childForceExpandWidth=true; vlg.childForceExpandHeight=false; vlg.spacing=18; vlg.childAlignment=TextAnchor.UpperLeft;
        content.GetComponent<ContentSizeFitter>().verticalFit=ContentSizeFitter.FitMode.PreferredSize;
        _scroll.content=_logContent;

        // choices (bottom)
        var choicesGO = new GameObject("Choices", typeof(RectTransform), typeof(VerticalLayoutGroup), typeof(ContentSizeFitter));
        choicesGO.transform.SetParent(panel.transform,false); _choices=(RectTransform)choicesGO.transform;
        Anchor(_choices, new Vector2(0,0), new Vector2(1,0), new Vector2(40,90), new Vector2(-40,270));
        var cvlg=choicesGO.GetComponent<VerticalLayoutGroup>(); cvlg.childControlWidth=true; cvlg.childControlHeight=true; cvlg.childForceExpandWidth=true; cvlg.childForceExpandHeight=false; cvlg.spacing=8; cvlg.childAlignment=TextAnchor.LowerLeft;
        choicesGO.GetComponent<ContentSizeFitter>().verticalFit=ContentSizeFitter.FitMode.PreferredSize;

        _hint = NewText(panel.transform, 24, TextAlignmentOptions.BottomRight); _hint.color=new Color(0.6f,0.58f,0.5f);
        Anchor(_hint.rectTransform, new Vector2(0,0), new Vector2(1,0), new Vector2(40,40), new Vector2(-40,84));

        _fade = NewImage(cgo.transform, Color.black); Stretch(_fade.rectTransform); _fade.raycastTarget=false;

        var l = new GameObject("DreamLight").AddComponent<Light>(); l.type=LightType.Directional; l.intensity=0.3f; l.color=new Color(0.6f,0.62f,0.8f);
        var cam = new GameObject("IntroCam", typeof(Camera)); var cc=cam.GetComponent<Camera>(); cc.clearFlags=CameraClearFlags.SolidColor; cc.backgroundColor=new Color(0.015f,0.015f,0.02f); cam.tag="MainCamera"; cam.AddComponent<AudioListener>();
    }

    void AddLog(string speaker, Color spColor, string body, Color bodyColor)
    {
        var go = new GameObject("Line", typeof(RectTransform));
        go.transform.SetParent(_logContent, false);
        var t = go.AddComponent<TextMeshProUGUI>();
        t.fontSize = 30; t.richText = true; t.alignment = TextAlignmentOptions.TopLeft; t.textWrappingMode = TextWrappingModes.Normal;
        if (TMP_Settings.defaultFontAsset != null) t.font = TMP_Settings.defaultFontAsset;
        string sp = string.IsNullOrEmpty(speaker) ? "" : "<b><color=#" + Hex(spColor) + ">" + speaker.ToUpper() + "</color></b>  ";
        t.text = sp + "<color=#" + Hex(bodyColor) + ">" + body + "</color>";
        StartCoroutine(ScrollBottom());
    }

    IEnumerator ScrollBottom(){ yield return null; yield return null; Canvas.ForceUpdateCanvases(); if(_scroll!=null) _scroll.verticalNormalizedPosition = 0f; }

    void MakeChoice(string label, System.Action onClick)
    {
        var go = new GameObject("Choice", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Button));
        go.transform.SetParent(_choices, false);
        var img = go.GetComponent<Image>(); img.color = new Color(0.86f,0.30f,0.22f,0.06f);
        var t = NewText(go.transform, 27, TextAlignmentOptions.Left); t.color = ChoiceRed; t.textWrappingMode = TextWrappingModes.Normal; Stretch(t.rectTransform, 10);
        t.text = label;
        var le = go.AddComponent<LayoutElement>(); le.minHeight = 44;
        var btn = go.GetComponent<Button>(); btn.targetGraphic = img;
        var cb = btn.colors; cb.highlightedColor = new Color(0.86f,0.30f,0.22f,0.22f); cb.normalColor = new Color(0.86f,0.30f,0.22f,0.06f); cb.pressedColor = new Color(0.86f,0.30f,0.22f,0.30f); cb.selectedColor = cb.highlightedColor; cb.fadeDuration=0.08f; btn.colors = cb;
        var hv = go.AddComponent<ChoiceHover>(); hv.text = t;
        btn.onClick.AddListener(() => onClick());
    }

    void ClearChoices(){ if(_choices==null)return; for(int i=_choices.childCount-1;i>=0;i--) Destroy(_choices.GetChild(i).gameObject); }

    IEnumerator Fade(float from, float to, float dur)
    {
        float tt = 0; var c = _fade.color;
        while (tt < dur) { tt += Time.deltaTime; c.a = Mathf.Lerp(from, to, tt/dur); _fade.color = c; yield return null; }
        c.a = to; _fade.color = c;
    }

    static string Hex(Color c){ return ColorUtility.ToHtmlStringRGB(c); }
    static Image NewImage(Transform p, Color c){ var g=new GameObject("Img", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image)); g.transform.SetParent(p,false); var im=g.GetComponent<Image>(); im.color=c; return im; }
    static TextMeshProUGUI NewText(Transform p, float size, TextAlignmentOptions al){ var g=new GameObject("Txt", typeof(RectTransform), typeof(CanvasRenderer)); g.transform.SetParent(p,false); var t=g.AddComponent<TextMeshProUGUI>(); t.fontSize=size; t.alignment=al; t.richText=true; t.color=White; if(TMP_Settings.defaultFontAsset!=null)t.font=TMP_Settings.defaultFontAsset; return t; }
    static void Stretch(RectTransform rt, float pad=0){ rt.anchorMin=Vector2.zero; rt.anchorMax=Vector2.one; rt.offsetMin=new Vector2(pad,pad); rt.offsetMax=new Vector2(-pad,-pad); }
    static void Anchor(RectTransform rt, Vector2 mn, Vector2 mx, Vector2 omn, Vector2 omx){ rt.anchorMin=mn; rt.anchorMax=mx; rt.offsetMin=omn; rt.offsetMax=omx; }
}

public class ChoiceHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
    public TMPro.TextMeshProUGUI text;
    static readonly Color Norm = new Color(0.86f,0.30f,0.22f);
    static readonly Color Hi   = new Color(1f,0.55f,0.35f);
    void Set(Color c){ if(text!=null) text.color=c; }
    public void OnPointerEnter(PointerEventData e)=>Set(Hi);
    public void OnPointerExit(PointerEventData e)=>Set(Norm);
    public void OnSelect(BaseEventData e)=>Set(Hi);
    public void OnDeselect(BaseEventData e)=>Set(Norm);
}
