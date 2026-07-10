using System.Collections.Generic;
using FortressOccident;
using PixelCrushers.DialogueSystem;
using Sunshine;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SenseOrb : FOComponent
{
	public const string conditionFieldName = "Condition";

	public const string instructionFieldName = "Instruction";

	public const string ORB_LUA_TABLE = "ShownOrbs";

	public const string luaFieldName = "OrbSeen";

	public const string MORSELFIELD = "AlternateOrbText";

	public const string DIST1 = "Description";

	public const string SOUND_GROUP_FIELD = "orbSoundGroup";

	public const string SOUND_VARIATION_FIELD = "orbSoundVariation";

	public const string SOUND_VOLUME_FIELD = "orbSoundVolume";

	public static bool ForceVisible;

	public static List<SenseOrb> sceneOrbSet;

	public static List<SenseOrb> sceneOrbsToProcess;

	private static bool warnCache;

	public OrbType orbType;

	public string conversation;

	public string textOverride;

	public bool IsOrbiting;

	public bool isEnabled;

	private CameraMarker cameraMarker;

	private OrbUiElement orbUI;

	private Collider orbCollider;

	private SphereCollider sphereCollider;

	private bool hasDialogue;

	private bool isOrbital;

	private bool initDone;

	private string morselText;

	private Scene sourceScene;

	private bool isConversationDataCached;

	private static HashSet<string> ignoreAreaOrbs;

	public bool isMullenOrb;

	public Conversation ConversationObject { get; private set; }

	public SenseOrbSound OrbSound { get; private set; }

	public OrbUiElement OrbUI
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual SkillType Skill => default(SkillType);

	public virtual string DifficultyFieldName => null;

	public string Condition => null;

	public float InteractionRadius => 0f;

	public bool IsAccessible => false;

	public bool IsMorsel { get; private set; }

	public bool IsVisuallyVisible => false;

	public virtual bool IsViscal => false;

	public bool HasDialogue => false;

	public virtual bool IsOrbital => false;

	public virtual int SkillThreshold => 0;

	public virtual bool PrerequisitesMet()
	{
		return false;
	}

	public bool IsCheckPassed()
	{
		return false;
	}

	public virtual bool WasShown()
	{
		return false;
	}

	public void SetShown()
	{
	}

	protected override void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private bool AttachToAreaChange()
	{
		return false;
	}

	protected virtual void OnSceneActivated()
	{
	}

	protected virtual void OnSceneDeactivated()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void disableOrb()
	{
	}

	public void Shakeup()
	{
	}

	public void RunInstruction()
	{
	}

	public void CacheConversationData()
	{
	}

	public void StartConversation()
	{
	}

	public bool RunThoughtSplashScreen()
	{
		return false;
	}

	public string GetText()
	{
		return null;
	}

	public Color GetOrbColor()
	{
		return default(Color);
	}

	public Sprite GetOrbSprite(InteractableRenderer interactableRenderer)
	{
		return null;
	}

	private bool IsInterfaceVisible()
	{
		return false;
	}

	public OrbVisibility DesiredVisibilityState()
	{
		return default(OrbVisibility);
	}

	private void InitThings()
	{
	}

	private bool MaybeCreateMorselData()
	{
		return false;
	}
}
