// FlowController — restored front-end glue: main menu -> archetype/abilities -> signature skill -> real intro.
// Uses the recovered Disco ability/skill rules (4 faculties, 24 skills, 8 point pool, signature +1)
// and then loads IntroReal, which plays the real DB/VO opening.
using System.Collections.Generic;
using System.IO;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class RestoredFlowController : MonoBehaviour
{
    [Header("Real exported UI art")]
    public Texture2D menuBgTexture;
    public Texture2D logoTexture;
    public Texture2D titleBgTexture;
    public Texture2D archetypeBgTexture;
    public Texture2D loadingTexture;
    public Texture2D loadingCircleTexture;

    enum Screen { Loading, Menu, Archetype, Abilities, Signature }
    readonly string[] abilities = { "INTELLECT", "PSYCHE", "PHYSIQUE", "MOTORICS" };
    readonly string[][] skills = {
        new[]{"Logic","Encyclopedia","Rhetoric","Drama","Conceptualization","Visual Calculus"},
        new[]{"Volition","Inland Empire","Empathy","Authority","Esprit de Corps","Suggestion"},
        new[]{"Endurance","Pain Threshold","Physical Instrument","Electrochemistry","Shivers","Half Light"},
        new[]{"Hand/Eye Coordination","Perception","Reaction Speed","Savoir Faire","Interfacing","Composure"}
    };
    readonly Color[] abilityColors = {
        new Color(0.70f,0.48f,0.78f), new Color(0.48f,0.62f,0.88f), new Color(0.82f,0.36f,0.28f), new Color(0.88f,0.70f,0.32f)
    };

    Canvas _canvas;
    RectTransform _root;
    Screen _screen;
    readonly Dictionary<string, Sprite> _portraits = new Dictionary<string, Sprite>();
    readonly Dictionary<string, Texture2D> _uiTextures = new Dictionary<string, Texture2D>();
    readonly List<AssetBundle> _bundles = new List<AssetBundle>();
    int[] pts = { 1, 1, 1, 1 };
    int signatureA = 1, signatureS = 1;

    const int Pool = 8;
    int Spent => (pts[0]-1)+(pts[1]-1)+(pts[2]-1)+(pts[3]-1);
    int Remain => Pool - Spent;

    bool _initialized;

    void Awake() { Initialize(); SceneManager.sceneLoaded += OnSceneLoaded; }
    void OnEnable() { Initialize(); }
    void Start() { Initialize(); }

    void OnSceneLoaded(Scene sc, LoadSceneMode mode)
    {
        // returning to the boot scene re-opens the main menu (the persistent controller survives
        // scene loads but its canvas is destroyed with the previous scene).
        if (sc.name == "BootBlank")
        {
            if (_canvas == null) BuildCanvas();
            Show(Screen.Menu);
        }
    }

    void Initialize()
    {
        if (_initialized) return;
        _initialized = true;
        if (FindAnyObjectByType<EventSystem>() == null)
            new GameObject("EventSystem", typeof(EventSystem), typeof(StandaloneInputModule));
        RecoveredRuntimeServices.EnsureSingleEventSystem();
        LoadUISprites();
        Debug.Log("[FLOWUI] RestoredFlow drawing loading screen; texture cache="+_uiTextures.Count);
        BuildCanvas();
        Show(Screen.Loading);
        StartCoroutine(LoadPortraitsThenMenu());
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        foreach (var b in _bundles) if (b != null) b.Unload(false);
    }

    void LoadPortraits()
    {
        string aa = Path.Combine(Application.streamingAssetsPath, "aa/StandaloneWindows64");
        if (!Directory.Exists(aa)) return;
        var files = Directory.GetFiles(aa, "portraits*.bundle");
        if (files.Length == 0) return;
        AssetBundle ab = RecoveredRuntimeServices.LoadBundleCached(files[0]);
        if (ab == null) return;
        foreach (var tex in ab.LoadAllAssets<Texture2D>())
            _portraits[tex.name.ToLowerInvariant()] = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
    }

    void BuildCanvas()
    {
        var go = new GameObject("FlowCanvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
        _canvas = go.GetComponent<Canvas>(); _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        var sc = go.GetComponent<CanvasScaler>(); sc.uiScaleMode=CanvasScaler.ScaleMode.ScaleWithScreenSize; sc.referenceResolution=new Vector2(1920,1080); sc.matchWidthOrHeight=1f;
        _root = new GameObject("Root", typeof(RectTransform)).GetComponent<RectTransform>(); _root.SetParent(go.transform,false); Stretch(_root);
    }

    void Show(Screen s)
    {
        _screen = s;
        for(int i=_root.childCount-1;i>=0;i--) Destroy(_root.GetChild(i).gameObject);
        Img(_root, new Color(0.035f,0.032f,0.028f));
        if(s==Screen.Loading) Loading(); else if(s==Screen.Menu) Menu(); else if(s==Screen.Archetype) Archetype(); else if(s==Screen.Abilities) Abilities(); else Signature();
    }

    IEnumerator LoadPortraitsThenMenu()
    {
        yield return null;
        LoadPortraits();
        yield return new WaitForSeconds(1.2f);
        if (_screen == Screen.Loading) Show(Screen.Menu);
    }

    void Update()
    {
        if (_screen == Screen.Menu)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.N)) Show(Screen.Archetype);
            if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        }
        else if (_screen == Screen.Archetype)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) { ApplyArchetype(0); Show(Screen.Abilities); }
            if (Input.GetKeyDown(KeyCode.Alpha2)) { ApplyArchetype(1); Show(Screen.Abilities); }
            if (Input.GetKeyDown(KeyCode.Alpha3)) { ApplyArchetype(2); Show(Screen.Abilities); }
            if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Return)) { ApplyArchetype(3); Show(Screen.Abilities); }
            if (Input.GetKeyDown(KeyCode.Escape)) Show(Screen.Menu);
        }
        else if (_screen == Screen.Abilities)
        {
            if (Input.GetKeyDown(KeyCode.Return)) Show(Screen.Signature);
            if (Input.GetKeyDown(KeyCode.Escape)) Show(Screen.Archetype);
        }
        else if (_screen == Screen.Signature)
        {
            if (Input.GetKeyDown(KeyCode.Return)) Begin();
            if (Input.GetKeyDown(KeyCode.Escape)) Show(Screen.Abilities);
        }
    }

    void Loading()
    {
        SpriteImage(_root, "loading", Vector2.zero, Vector2.zero, true);
        SpriteImage(_root, "loadingCircle", new Vector2(860,-650), new Vector2(1060,-450), false);
        Text(_root,"LOADING",34,new Color(0.95f,0.91f,0.78f),new Vector2(840,-835),new Vector2(1080,-780),TextAlignmentOptions.Center);
    }

    void Menu()
    {
        SpriteImage(_root, "menuBg", Vector2.zero, Vector2.zero, true);
        var side = Img(_root, new Color(0.015f, 0.013f, 0.012f, 0.78f));
        AnchorSmart(side.rectTransform, _root, new Vector2(0, -1080), new Vector2(260, 0));
        var amber = Img(_root, new Color(0.62f, 0.23f, 0.08f, 0.48f));
        AnchorSmart(amber.rectTransform, _root, new Vector2(0, -1080), new Vector2(8, 0));

        MenuButton("NEW GAME", new Vector2(18, -356), new Vector2(190, -328), () => Show(Screen.Archetype));
        MenuButton("LOAD GAME", new Vector2(18, -390), new Vector2(190, -362), () => { });
        MenuButton("OPTIONS", new Vector2(18, -424), new Vector2(190, -396), () => { });
        MenuButton("3D SHOWCASE", new Vector2(18, -458), new Vector2(244, -430), () => SceneManager.LoadScene("3DShowcase"));
        MenuButton("RECOVERED SCENES", new Vector2(18, -492), new Vector2(244, -464), () => SceneManager.LoadScene("RecoveredSceneIndex"));
        MenuButton("QUIT", new Vector2(18, -526), new Vector2(190, -498), () => Application.Quit());

        SpriteImage(_root, "logo", new Vector2(860, -1005), new Vector2(1760, -820), false);
    }

    void Archetype()
    {
        SpriteImage(_root, "archetypeBg", Vector2.zero, Vector2.zero, true);
        var wash = Img(_root, new Color(0.82f,0.90f,0.92f,0.26f));
        Stretch(wash.rectTransform);
        var titlePlate = Img(_root, new Color(0.96f,0.95f,0.90f,0.96f));
        AnchorSmart(titlePlate.rectTransform,_root,new Vector2(0,-64),new Vector2(430,-4));
        Text(_root,"SELECT ARCHETYPE",42,Color.black,new Vector2(6,-58),new Vector2(418,-4),TextAlignmentOptions.Left);
        string[] names={"THINKER","SENSITIVE","PHYSICAL","CUSTOM"};
        string[] archKeys={"archLogician","archSensitive","archPredator","archCustom"};
        string[] desc={"Extremely intelligent. Very bad with people. Knows interesting facts.","Very psychological. A magnetic personality, but unstable. Might begin to lose his mind.","Extremely physical. Interacts with the world through his body. Gets things done, but dumb as a rock.","Create your own character."};
        int[][] vals={ new[]{4,3,2,3}, new[]{3,4,2,3}, new[]{2,3,4,3}, new[]{1,1,1,1} };
        int[][] sigs={ new[]{0,1}, new[]{1,1}, new[]{2,2}, new[]{0,0} };
        for(int i=0;i<4;i++)
        {
            int idx=i; var x=42+i*454;
            var panel=Panel(new Vector2(x,-890),new Vector2(x+360,-82));
            panel.GetComponent<Image>().color = new Color(0.90f,0.92f,0.88f,0.92f);
            SpriteImage(panel,archKeys[i],new Vector2(36,-420),new Vector2(-36,-36),false);
            var titleBg=Img(panel,new Color(0.02f,0.018f,0.015f,0.98f));
            AnchorSmart(titleBg.rectTransform,panel,new Vector2(36,-496),new Vector2(-36,-420));
            Text(panel,names[i],35,Color.white,new Vector2(36,-487),new Vector2(-36,-429),TextAlignmentOptions.Center);
            Text(panel,desc[i],13,Color.black,new Vector2(44,-550),new Vector2(-44,-502),TextAlignmentOptions.Center);
            string stat=$"{vals[i][0]}   {vals[i][1]}   {vals[i][2]}   {vals[i][3]}";
            Text(panel,stat,34,Color.black,new Vector2(38,-626),new Vector2(-38,-562),TextAlignmentOptions.Center);
            Text(panel,"INT    PSY    FYS    MOT",16,Color.black,new Vector2(34,-655),new Vector2(-34,-622),TextAlignmentOptions.Center);
            Text(panel,"+"+skills[sigs[i][0]][sigs[i][1]].ToUpper(),15,Color.black,new Vector2(34,-696),new Vector2(-34,-664),TextAlignmentOptions.Center);
            Button(panel,"SELECT",22,new Vector2(70,-770),new Vector2(-70,-710),()=>{ ApplyArchetype(idx); Show(Screen.Abilities); });
        }
        Button(_root,"< BACK",26,new Vector2(0,-1078),new Vector2(220,-1015),()=>Show(Screen.Menu));
    }

    void ApplyArchetype(int idx)
    {
        int[][] vals={ new[]{4,3,2,3}, new[]{3,4,2,3}, new[]{2,3,4,3}, new[]{1,1,1,1} };
        int[][] sigs={ new[]{0,1}, new[]{1,1}, new[]{2,2}, new[]{0,0} };
        for(int a=0;a<4;a++) pts[a]=vals[idx][a];
        signatureA=sigs[idx][0]; signatureS=sigs[idx][1];
    }

    void Abilities()
    {
        SpriteImage(_root, "archetypeBg", Vector2.zero, Vector2.zero, true);
        Header("SET YOUR FACULTIES", $"POINTS LEFT: {Remain}");
        for(int i=0;i<4;i++)
        {
            int a=i; float y=-270-i*155;
            Text(_root,abilities[i],32,abilityColors[i],new Vector2(180,y-45),new Vector2(600,y),TextAlignmentOptions.Left);
            Text(_root,pts[i].ToString(),52,Color.white,new Vector2(700,y-70),new Vector2(800,y),TextAlignmentOptions.Center);
            Button(_root,"-",34,new Vector2(830,y-68),new Vector2(900,y-8),()=>{ if(pts[a]>1){pts[a]--;Show(Screen.Abilities);} });
            Button(_root,"+",34,new Vector2(915,y-68),new Vector2(985,y-8),()=>{ if(pts[a]<6 && Remain>0){pts[a]++;Show(Screen.Abilities);} });
            for (int s=0; s<6; s++) SkillMini(_root, i, s, new Vector2(1020+s*126,y-96), new Vector2(1130+s*126,y+14));
        }
        Button(_root,"BACK",26,new Vector2(140,-1010),new Vector2(330,-950),()=>Show(Screen.Archetype));
        Button(_root,"SIGNATURE SKILL",28,new Vector2(1420,-1010),new Vector2(1780,-950),()=>Show(Screen.Signature));
    }

    void Signature()
    {
        SpriteImage(_root, "archetypeBg", Vector2.zero, Vector2.zero, true);
        Header("SIGNATURE SKILL", "One voice rises louder. It receives +1.");
        int k=0;
        for(int a=0;a<4;a++) for(int s=0;s<6;s++)
        {
            int aa=a, ss=s; float x=145+(k%6)*285; float y=-250-(k/6)*165; k++;
            SkillSignatureCard(aa, ss, new Vector2(x,y-145), new Vector2(x+250,y));
        }
        Button(_root,"BACK",26,new Vector2(140,-1010),new Vector2(330,-950),()=>Show(Screen.Abilities));
        Button(_root,"BEGIN",34,new Vector2(1500,-1010),new Vector2(1780,-950),Begin);
    }

    void LoadUISprites()
    {
        // Menu.png is a shader/mask texture and appears posterized if shown raw; use the real full-color mural.
        if (menuBgTexture == null) menuBgTexture = Resources.Load<Texture2D>("FlowUI/no-truce-loading-screen-wide");
        if (logoTexture == null) logoTexture = Resources.Load<Texture2D>("FlowUI/discoelys");
        if (titleBgTexture == null) titleBgTexture = Resources.Load<Texture2D>("FlowUI/title-bg");
        if (archetypeBgTexture == null) archetypeBgTexture = Resources.Load<Texture2D>("FlowUI/Archetype Background Tmp");
        if (loadingTexture == null) loadingTexture = Resources.Load<Texture2D>("FlowUI/no-truce-loading-screen-wide");
        if (loadingCircleTexture == null) loadingCircleTexture = Resources.Load<Texture2D>("FlowUI/LoadingCircle");
        Debug.Log("[FLOWUI] refs menu="+TexInfo(menuBgTexture)+" logo="+TexInfo(logoTexture)+" archetype="+TexInfo(archetypeBgTexture)+" loading="+TexInfo(loadingTexture)+" circle="+TexInfo(loadingCircleTexture));
        AddUITexture("menuBg", menuBgTexture);
        AddUITexture("logo", logoTexture);
        AddUITexture("titleBg", titleBgTexture);
        AddUITexture("archetypeBg", archetypeBgTexture);
        AddUITexture("loading", loadingTexture);
        AddUITexture("loadingCircle", loadingCircleTexture);
        AddUITexture("archLogician", Resources.Load<Texture2D>("FlowUI/arch_logician"));
        AddUITexture("archSensitive", Resources.Load<Texture2D>("FlowUI/arch_sensitive"));
        AddUITexture("archPredator", Resources.Load<Texture2D>("FlowUI/arch_predator"));
        AddUITexture("archCustom", Resources.Load<Texture2D>("FlowUI/Single Sensitive"));
        AddUITexture("archBackpanel", Resources.Load<Texture2D>("FlowUI/arche_backpanel"));
    }

    void AddUITexture(string key, Texture2D tex)
    {
        if (tex == null) return;
        _uiTextures[key] = tex;
    }

    string TexInfo(Texture2D t){ return t==null?"NULL":(t.name+" "+t.width+"x"+t.height); }

    RawImage SpriteImage(Transform p, string key, Vector2 min, Vector2 max, bool stretch)
    {
        var go = new GameObject("RawUI", typeof(RectTransform), typeof(CanvasRenderer), typeof(RawImage));
        go.transform.SetParent(p, false);
        var img = go.GetComponent<RawImage>();
        if (_uiTextures.TryGetValue(key, out var tex)) { img.texture = tex; img.color = Color.white; }
        else img.color = new Color(0.02f,0.02f,0.02f,1f);
        if (stretch) Stretch((RectTransform)go.transform);
        else AnchorSmart((RectTransform)go.transform, p, min, max);
        return img;
    }

    void Begin()
    {
        PlayerPrefs.SetString("signatureSkill", skills[signatureA][signatureS]);
        PlayerPrefs.SetInt("INT", pts[0]); PlayerPrefs.SetInt("PSY", pts[1]); PlayerPrefs.SetInt("FYS", pts[2]); PlayerPrefs.SetInt("MOT", pts[3]);
        SceneManager.LoadScene("IntroReal");
    }

    string SkillKey(int a, int s)
    {
        string[][] keys = {
            new[]{"logic","encyclopedia","rhetoric","drama_rank1","conceptualization_rank1","visual-calculus_rank1"},
            new[]{"volition","inland-empire","empathy","authority","esprit-de-corps","suggestion"},
            new[]{"endurance","pain-threshold","physical-instrument","electrochemistry","shivers","half-light"},
            new[]{"he_coordination","perception","reaction","savoir-faire","interfacing","composure"}
        };
        return "portrait_" + keys[a][s];
    }

    Sprite SkillSprite(int a, int s)
    {
        _portraits.TryGetValue(SkillKey(a,s).ToLowerInvariant(), out var sp);
        return sp;
    }

    Image SkillPortrait(Transform p, int a, int s, Vector2 min, Vector2 max)
    {
        var go = new GameObject("SkillPortrait", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        go.transform.SetParent(p, false);
        var img = go.GetComponent<Image>();
        img.sprite = SkillSprite(a,s);
        img.color = img.sprite != null ? Color.white : new Color(abilityColors[a].r, abilityColors[a].g, abilityColors[a].b, 0.35f);
        img.preserveAspect = true;
        AnchorSmart((RectTransform)go.transform, p, min, max);
        return img;
    }

    void SkillMini(Transform p, int a, int s, Vector2 min, Vector2 max)
    {
        var bg = Img(p, new Color(0.055f,0.050f,0.045f,0.92f));
        AnchorSmart(bg.rectTransform, p, min, max);
        SkillPortrait(bg.transform, a, s, new Vector2(4,-72), new Vector2(-4,-4));
        Text(bg.transform, skills[a][s], 12, Color.white, new Vector2(4,-96), new Vector2(-4,-73), TextAlignmentOptions.Center);
        Text(bg.transform, (pts[a] + ((a==signatureA && s==signatureS)?1:0)).ToString(), 18, abilityColors[a], new Vector2(74,-34), new Vector2(-4,-5), TextAlignmentOptions.Center);
    }

    void SkillSignatureCard(int a, int s, Vector2 min, Vector2 max)
    {
        bool sel = a==signatureA && s==signatureS;
        var go = new GameObject("SkillSignatureCard", typeof(RectTransform), typeof(CanvasRenderer), typeof(Image), typeof(Button));
        go.transform.SetParent(_root, false);
        var bg = go.GetComponent<Image>();
        bg.color = sel ? new Color(0.18f,0.06f,0.035f,0.96f) : new Color(0.07f,0.06f,0.05f,0.94f);
        var rt = (RectTransform)go.transform;
        AnchorSmart(rt, _root, min, max);
        SkillPortrait(rt, a, s, new Vector2(12,-90), new Vector2(-12,-10));
        Text(rt, skills[a][s], 15, Color.white, new Vector2(8,-116), new Vector2(-8,-92), TextAlignmentOptions.Center);
        Text(rt, (pts[a] + (sel ? 1 : 0)).ToString(), 24, abilityColors[a], new Vector2(205,-42), new Vector2(-8,-8), TextAlignmentOptions.Center);
        Text(rt, sel ? "SIGNATURE" : "SET SIGNATURE", 13, ChoiceRed(), new Vector2(8,-142), new Vector2(-8,-120), TextAlignmentOptions.Center);
        go.GetComponent<Button>().onClick.AddListener(() => { signatureA=a; signatureS=s; Show(Screen.Signature); });
    }

    static Color ChoiceRed(){ return new Color(0.86f,0.30f,0.22f); }

    RectTransform Panel(Vector2 a, Vector2 b){ var rt=Img(_root,new Color(0.08f,0.075f,0.065f,0.94f)).rectTransform; AnchorSmart(rt,_root,a,b); return rt; }
    void Header(string h,string sub){ Text(_root,h,58,Color.white,new Vector2(140,-130),new Vector2(1500,-50),TextAlignmentOptions.Left); Text(_root,sub,26,new Color(0.72f,0.70f,0.62f),new Vector2(145,-185),new Vector2(1700,-135),TextAlignmentOptions.Left); }
    Button MenuButton(string label, Vector2 a, Vector2 b, UnityEngine.Events.UnityAction cb){ var go=new GameObject("MenuButton",typeof(RectTransform),typeof(CanvasRenderer),typeof(Image),typeof(Button));go.transform.SetParent(_root,false);var img=go.GetComponent<Image>();img.color=new Color(0,0,0,0.001f);var rt=(RectTransform)go.transform;AnchorSmart(rt,_root,a,b);var t=Text(rt,label,22,new Color(0.93f,0.90f,0.82f),new Vector2(0,0),new Vector2(0,0),TextAlignmentOptions.Left);StretchInset(t.rectTransform,0);var btn=go.GetComponent<Button>();btn.targetGraphic=img;btn.onClick.AddListener(cb);return btn;}
    Button Button(Transform p,string label,float size,Vector2 a,Vector2 b,UnityEngine.Events.UnityAction cb){ var go=new GameObject("Button",typeof(RectTransform),typeof(CanvasRenderer),typeof(Image),typeof(Button));go.transform.SetParent(p,false);var img=go.GetComponent<Image>();img.color=new Color(0.12f,0.10f,0.085f,0.9f);var rt=(RectTransform)go.transform;AnchorSmart(rt,p,a,b);var t=Text(rt,label,size,new Color(0.86f,0.30f,0.22f),new Vector2(8,8),new Vector2(-8,-8),TextAlignmentOptions.Center);StretchInset(t.rectTransform,8);var btn=go.GetComponent<Button>();btn.onClick.AddListener(cb);return btn;}
    TextMeshProUGUI Text(Transform p,string s,float size,Color c,Vector2 a,Vector2 b,TextAlignmentOptions al){ var go=new GameObject("Text",typeof(RectTransform),typeof(CanvasRenderer));go.transform.SetParent(p,false);var t=go.AddComponent<TextMeshProUGUI>();t.text=s;t.fontSize=size;t.color=c;t.alignment=al;t.textWrappingMode=TextWrappingModes.Normal;if(TMP_Settings.defaultFontAsset)t.font=TMP_Settings.defaultFontAsset;AnchorSmart(t.rectTransform,p,a,b);return t;}
    Image Img(Transform p,Color c){ var go=new GameObject("Img",typeof(RectTransform),typeof(CanvasRenderer),typeof(Image));go.transform.SetParent(p,false);var i=go.GetComponent<Image>();i.color=c;Stretch((RectTransform)go.transform);return i;}
    static void Stretch(RectTransform r){r.anchorMin=Vector2.zero;r.anchorMax=Vector2.one;r.offsetMin=Vector2.zero;r.offsetMax=Vector2.zero;}
    void AnchorSmart(RectTransform r,Transform parent,Vector2 a,Vector2 b)
    {
        if (parent == _root)
        {
            r.anchorMin=new Vector2(0,1); r.anchorMax=new Vector2(0,1); r.offsetMin=a; r.offsetMax=b;
        }
        else
        {
            r.anchorMin=new Vector2(0,1); r.anchorMax=new Vector2(1,1); r.offsetMin=a; r.offsetMax=b;
        }
    }
    static void StretchInset(RectTransform r,float pad){r.anchorMin=Vector2.zero;r.anchorMax=Vector2.one;r.offsetMin=new Vector2(pad,pad);r.offsetMax=new Vector2(-pad,-pad);}
}

