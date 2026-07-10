using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemControllerPageSystem : MonoBehaviour
	{
		public static DialogueSystemControllerPageSystem Singleton;

		public DialogueDatabase initialDatabase;

		public DisplaySettings displaySettings;

		public PersistentDataSettings persistentDataSettings;

		public bool allowSimultaneousConversations;

		public bool includeSimStatus;

		public bool preloadResources;

		public bool instantiateDatabase;

		public bool dontDestroyOnLoad;

		public bool allowOnlyOneInstance;

		public DialogueTime.TimeMode dialogueTimeMode;

		public DialogueDebug.DebugLevel debugLevel;

		private bool m_isInitialized;

		private const string DefaultDialogueUIResourceName = "Default Dialogue UI";

		private DatabaseManager m_databaseManager;

		public IDialogueUI currentDialogueUI;

		[HideInInspector]
		private IDialogueUI m_originalDialogueUI;

		[HideInInspector]
		private DisplaySettings m_originalDisplaySettings;

		private bool m_overrodeDisplaySettings;

		private bool m_isOverrideUIPrefab;

		private ConversationController m_conversationController;

		private IsDialogueEntryValidDelegate m_isDialogueEntryValid;

		private GetInputButtonDownDelegate m_savedGetInputButtonDownDelegate;

		private LuaWatchers m_luaWatchers;

		private AssetBundleManager m_assetBundleManager;

		private bool m_started;

		private DialogueDebug.DebugLevel m_lastDebugLevelSet;

		private List<ActiveConversationRecord> m_activeConversations;

		private UILocalizationManager m_uiLocalizationManager;

		private bool m_calledRandomizeNextEntry;

		public static bool applicationIsQuitting;

		public static string lastInitialDatabaseName;

		private bool m_disableInput;

		public bool isInitialized => false;

		public DatabaseManager databaseManager => null;

		public DialogueDatabase masterDatabase => null;

		public IDialogueUI dialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IsDialogueEntryValidDelegate isDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GetInputButtonDownDelegate getInputButtonDown { get; set; }

		public bool isConversationActive => false;

		public Transform currentActor { get; private set; }

		public Transform currentConversant { get; private set; }

		public ConversationState currentConversationState { get; set; }

		public string lastConversationStarted { get; private set; }

		public int lastConversationID { get; private set; }

		public ConversationController conversationController => null;

		public ConversationModel conversationModel => null;

		public ConversationView conversationView => null;

		public List<ActiveConversationRecord> activeConversations => null;

		public DatabaseManager DatabaseManager => null;

		public DialogueDatabase MasterDatabase => null;

		public IDialogueUI DialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IsDialogueEntryValidDelegate IsDialogueEntryValid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GetInputButtonDownDelegate GetInputButtonDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsConversationActive => false;

		public Transform CurrentActor
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Transform CurrentConversant
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConversationState CurrentConversationState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LastConversationStarted
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int LastConversationID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ConversationController ConversationController => null;

		public ConversationModel ConversationModel => null;

		public ConversationView ConversationView => null;

		public List<ActiveConversationRecord> ActiveConversations => null;

		public bool allowLuaExceptions { get; set; }

		public bool warnIfActorAndConversantSame { get; set; }

		public event Action OnBeforeConversationStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action receivedUpdateTracker
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event TransformDelegate conversationStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event TransformDelegate conversationEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action initializationComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnDestroy()
		{
		}

		public void Awake()
		{
		}

		public bool StandardGetInputButtonDown(string buttonName)
		{
			return false;
		}

		private bool DisabledGetInputButtonDown(string buttonName)
		{
			return false;
		}

		public bool IsDialogueSystemInputDisabled()
		{
			return false;
		}

		public void SetDialogueSystemInput(bool value)
		{
		}

		public void Start()
		{
		}

		private void InitializeDisplaySettings()
		{
		}

		private void InitializeLocalization()
		{
		}

		public void SetLanguage(string language)
		{
		}

		private void CheckDebugLevel()
		{
		}

		private void InitializeDatabase()
		{
		}

		public void AddDatabase(DialogueDatabase database)
		{
		}

		public void RemoveDatabase(DialogueDatabase database)
		{
		}

		public void ResetDatabase(DatabaseResetOptions databaseResetOptions)
		{
		}

		public void ResetDatabase()
		{
		}

		public void PreloadMasterDatabase()
		{
		}

		public void PreloadDialogueUI()
		{
		}

		public bool ConversationHasValidEntry(string title, Transform actor, Transform conversant)
		{
			return false;
		}

		public bool ConversationHasValidEntry(string title, Transform actor)
		{
			return false;
		}

		public bool ConversationHasValidEntry(string title)
		{
			return false;
		}

		public void PreloadResources()
		{
		}

		public void StartConversation(string title, Transform actor, Transform conversant, int initialDialogueEntryID)
		{
		}

		public void StartConversation(string title, Transform actor, Transform conversant)
		{
		}

		public void StartConversation(string title, Transform actor)
		{
		}

		public void StartConversation(string title)
		{
		}

		public void StopConversation()
		{
		}

		public void UpdateResponses()
		{
		}

		public Transform FindActorTransformFromConversation(string conversationTitle, string actorField)
		{
			return null;
		}

		public void SetPortrait(string actorName, string portraitName)
		{
		}

		public void SetActorPortraitSprite(string actorName, Sprite sprite)
		{
		}

		private void SetConversationUI(Transform actor, Transform conversant)
		{
		}

		private OverrideUIBase FindHighestPriorityOverrideUI(Transform actor, Transform conversant)
		{
			return null;
		}

		private OverrideUIBase FindOverrideUI(Transform character)
		{
			return null;
		}

		private void ApplyOverrideUI(OverrideUIBase overrideUI)
		{
		}

		private void RestoreOriginalUI()
		{
		}

		private void OnDialogueEntrySpoken(Subtitle subtitle)
		{
		}

		public void OnEndConversation(ConversationController endingConversationController)
		{
		}

		public void OnConversationTimeout()
		{
		}

		private void OnConversationStart(Transform actor)
		{
		}

		private void OnConversationEnd(Transform actor)
		{
		}

		private IEnumerator ChooseResponseAfterOneFrame(ResponseTimeoutAction responseTimeoutAction)
		{
			return null;
		}

		public void Bark(string conversationTitle, Transform speaker, Transform listener, BarkHistory barkHistory)
		{
		}

		public void Bark(string conversationTitle, Transform speaker, Transform listener)
		{
		}

		public void Bark(string conversationTitle, Transform speaker)
		{
		}

		public void Bark(string conversationTitle, Transform speaker, BarkHistory barkHistory)
		{
		}

		public void BarkString(string barkText, Transform speaker, Transform listener = null, string sequence = null)
		{
		}

		public float GetBarkDuration(string barkText)
		{
			return 0f;
		}

		private CharacterInfo GetCharacterInfoFromTransform(Transform actorTransform)
		{
			return null;
		}

		public void ShowAlert(string message, float duration)
		{
		}

		public void ShowAlert(string message)
		{
		}

		public void CheckAlerts()
		{
		}

		private IEnumerator MonitorAlerts()
		{
			return null;
		}

		public void HideAlert()
		{
		}

		public string GetLocalizedText(string s)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone, string entrytag)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence, Transform speaker, Transform listener)
		{
			return null;
		}

		public Sequencer PlaySequence(string sequence)
		{
			return null;
		}

		public void StopSequence(Sequencer sequencer)
		{
		}

		public void Pause()
		{
		}

		public void Unpause()
		{
		}

		private void BroadcastDialogueSystemMessage(string message)
		{
		}

		public void UseDialogueUI(GameObject gameObject)
		{
		}

		private IDialogueUI GetDialogueUI()
		{
			return null;
		}

		private void SetDialogueUI(IDialogueUI ui)
		{
		}

		private void ValidateCurrentDialogueUI()
		{
		}

		private void GetDialogueUIFromDisplaySettings()
		{
		}

		private IDialogueUI LoadDefaultDialogueUI()
		{
			return null;
		}

		private IDialogueUI LoadDialogueUIPrefab(GameObject prefab)
		{
			return null;
		}

		private Canvas GetOrCreateDefaultCanvas()
		{
			return null;
		}

		private Sequencer GetNewSequencer()
		{
			return null;
		}

		private void RegisterLuaFunctions()
		{
		}

		private void UnregisterLuaFunctions()
		{
		}

		public void SendUpdateTracker()
		{
		}

		public static void LuaShowAlert(string message)
		{
		}

		public static void LuaHideAlert()
		{
		}

		private static DialogueEntry GetDialogueEntryInCurrentConversation(double entryID)
		{
			return null;
		}

		private static string GetEntryText(double entryID, string fieldName)
		{
			return null;
		}

		private static bool GetEntryBool(double entryID, string fieldName)
		{
			return false;
		}

		private static double GetEntryNumber(double entryID, string fieldName)
		{
			return 0.0;
		}

		public void RandomizeNextEntry()
		{
		}

		public void AddLuaObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		private IEnumerator AddLuaObserverAfterStart(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
			return null;
		}

		public void RemoveLuaObserver(string luaExpression, LuaWatchFrequency frequency, LuaChangedDelegate luaChangedHandler)
		{
		}

		public void RemoveAllObservers(LuaWatchFrequency frequency)
		{
		}

		public void RemoveAllObservers()
		{
		}

		private void Update()
		{
		}

		private void UpdateTracker()
		{
		}

		public void RegisterAssetBundle(AssetBundle bundle)
		{
		}

		public void UnregisterAssetBundle(AssetBundle bundle)
		{
		}

		public UnityEngine.Object LoadAsset(string name)
		{
			return null;
		}

		public UnityEngine.Object LoadAsset(string name, Type type)
		{
			return null;
		}
	}
}
