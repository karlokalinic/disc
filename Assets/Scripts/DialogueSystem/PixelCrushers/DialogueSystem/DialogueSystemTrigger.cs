using System;
using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemTrigger : MonoBehaviour
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;

			public string message;

			public string parameter;
		}

		public enum BarkSource
		{
			None = 0,
			Conversation = 1,
			Text = 2
		}

		[Serializable]
		public class SetGameObjectActiveAction
		{
			public Condition condition;

			public Transform target;

			public Toggle state;
		}

		[Serializable]
		public class SetComponentEnabledAction
		{
			public Condition condition;

			public Component target;

			public Toggle state;
		}

		[Serializable]
		public class SetAnimatorStateAction
		{
			public Condition condition;

			public Transform target;

			public string stateName;

			public float crossFadeDuration;
		}

		[DialogueSystemTriggerEvent]
		public DialogueSystemTriggerEvent trigger;

		public Condition condition;

		public bool setQuestState;

		public string questName;

		[QuestState]
		public QuestState questState;

		public bool setQuestEntryState;

		public int questEntryNumber;

		[QuestState]
		public QuestState questEntryState;

		public string luaCode;

		[TextArea]
		public string sequence;

		public Transform sequenceSpeaker;

		public Transform sequenceListener;

		public bool waitOneFrameOnStartOrEnable;

		public string alertMessage;

		public TextTable textTable;

		public float alertDuration;

		public SendMessageAction[] sendMessages;

		public BarkSource barkSource;

		public string barkConversation;

		public string barkText;

		public string barkTextSequence;

		public Transform barker;

		public Transform barkTarget;

		public BarkOrder barkOrder;

		public bool allowBarksDuringConversations;

		public bool skipBarkIfNoValidEntries;

		public bool cacheBarkLines;

		public string conversation;

		public Transform conversationConversant;

		public Transform conversationActor;

		public int startConversationEntryID;

		public bool exclusive;

		public bool skipIfNoValidEntries;

		public bool stopConversationOnTriggerExit;

		public bool stopConversationIfTooFar;

		public float maxConversationDistance;

		public float monitorConversationDistanceFrequency;

		public bool showCursorDuringConversation;

		public bool pauseGameDuringConversation;

		public SetGameObjectActiveAction[] setActiveActions;

		public SetComponentEnabledAction[] setEnabledActions;

		public SetAnimatorStateAction[] setAnimatorStateActions;

		public GameObjectUnityEvent onExecute;

		[HideInInspector]
		public bool useConversationTitlePicker;

		[HideInInspector]
		public bool useBarkTitlePicker;

		[HideInInspector]
		public bool useQuestNamePicker;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		protected BarkHistory barkHistory;

		protected ConversationState cachedState;

		protected BarkGroupMember barkGroupMember;

		protected IBarkUI barkUI;

		protected float earliestTimeToAllowTriggerExit;

		protected const float MarginToAllowTriggerExit = 0.2f;

		protected Coroutine monitorDistanceCoroutine;

		protected bool wasCursorVisible;

		protected CursorLockMode savedLockState;

		protected bool didIPause;

		protected float preConversationTimeScale;

		protected bool tryingToStart;

		protected bool listenForOnDestroy;

		public Sequencer sequencer { get; protected set; }

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void OnBarkStart(Transform actor)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		protected IEnumerator ShowCursorAfterOneFrame()
		{
			return null;
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnSequenceStart(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnSequenceEnd()
		{
		}

		public void OnUse(Transform actor)
		{
		}

		public void OnUse(string message)
		{
		}

		public void OnUse()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		protected void CheckOnTriggerExit(Transform otherTransform)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionExit(Collision collision)
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		protected IEnumerator StartAtEndOfFrame()
		{
			return null;
		}

		public void TryStart(Transform actor)
		{
		}

		public void TryStart(Transform actor, Transform interactor)
		{
		}

		public void Fire(Transform actor)
		{
		}

		protected virtual void DoQuestAction()
		{
		}

		protected virtual void DoLuaAction()
		{
		}

		protected virtual void DoSequenceAction(Transform actor)
		{
		}

		protected virtual void DoAlertAction()
		{
		}

		protected virtual void DoSendMessageActions()
		{
		}

		protected virtual void DoBarkAction(Transform actor)
		{
		}

		protected virtual Transform GetBarker(string conversation)
		{
			return null;
		}

		protected virtual string GetBarkerName()
		{
			return null;
		}

		protected virtual void BarkCachedLine(Transform speaker, Transform listener)
		{
		}

		protected void PopulateCache(Transform speaker, Transform listener)
		{
		}

		protected void BarkNextCachedLine(Transform speaker, Transform listener)
		{
		}

		public void ResetBarkHistory()
		{
		}

		protected virtual void DoConversationAction(Transform actor)
		{
		}

		protected void StopMonitoringConversationDistance()
		{
		}

		protected IEnumerator MonitorDistance(Transform actor)
		{
			return null;
		}

		protected virtual void DoSetActiveActions(Transform actor)
		{
		}

		protected virtual void DoSetEnabledActions(Transform actor)
		{
		}

		protected virtual void DoSetAnimatorStateActions(Transform actor)
		{
		}

		public void OnRecordPersistentData()
		{
		}

		public void OnApplyPersistentData()
		{
		}
	}
}
