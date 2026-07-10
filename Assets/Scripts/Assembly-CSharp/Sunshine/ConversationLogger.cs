using System;
using System.Collections;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	[Pragma]
	public class ConversationLogger : SingletonComponent<ConversationLogger>
	{
		[SerializeField]
		private float rightStickScrollSpeed;

		public const string AVOID_PARSING_BY_DIALOGUE_SYSTEM_STRING = "--[[ Variable[ ]]";

		public bool _ShowLog;

		public LogRenderer logRenderer;

		public SunshineContinueButton continueButton;

		public ContinueResponseToggle interactionToggler;

		public ScrollDown scrollDown;

		public Image portraitImg;

		public RectTransform FODialogueUI;

		public AbstractDialogueUI unityUI;

		public static DialogueDatabase db;

		public Vector2 viewportFocus;

		public bool inSequence;

		public static GameObject conversant;

		public static bool sequenceHidePortrait;

		public static bool specialEndButton;

		public Action onceAfterConversation;

		private bool optionResponse;

		protected Vector2 normalViewportFocus;

		protected float normalZoom;

		protected bool DialogueWithEntity;

		private IEnumerator exitInterfaceCoroutine;

		private ScrollRect ScrollController;

		private bool inConversation;

		[SerializeField]
		protected bool processContinueButtonHotkey;

		public static int speakerId;

		public static int lastSpeakerId;

		public static Conversation lastConversation;

		public static CheckResult lastCheckResult;

		public static bool LastDialogueIsSeen;

		public static DialogueEntry LastDialogueEntry;

		private bool isAsyncPrepared;

		private bool wereResponsesShown;

		private string previousActorName;

		private AsyncOperationHandle<Sprite> spriteHandle;

		protected bool previousOrbState;

		public static FinalEntry finalEntry { get; protected set; }

		public bool InConversation => false;

		public static bool CameraLockActive => false;

		public bool SpeakerChanged => false;

		public SunshineContinueButton ContinueButton => null;

		public ScrollDown ScrollDown => null;

		public void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		public void StopWorldOnConversationStart()
		{
		}

		private void SaveLastConversationTitle()
		{
		}

		private void LowerSounds()
		{
		}

		private void RaiseSounds()
		{
		}

		private void HidePortrait()
		{
		}

		private void PrepareCamera()
		{
		}

		private void RestoreCamera()
		{
		}

		public static void CutsceneCameraUnlock()
		{
		}

		public static void CutsceneCameraRelock()
		{
		}

		private void PrepareActors()
		{
		}

		private void RestoreActors()
		{
		}

		private void ResetTrigger(Animator anim, string trig)
		{
		}

		private void SetTrigger(Animator anim, string trig)
		{
		}

		private void HideOrbs()
		{
		}

		private void RestoreOrbs()
		{
		}

		private void CleanLog()
		{
		}

		private void ShowInterface()
		{
		}

		private void HideInterface(bool playSound = true)
		{
		}

		public void StopConversation()
		{
		}

		public void ForceStopConversation()
		{
		}

		private void StopExitConversationCoroutine()
		{
		}

		public void EndConversationCleanup()
		{
		}

		public void CleanUpDialogues()
		{
		}

		private void CleanUp()
		{
		}

		private IEnumerator ExitInterface()
		{
			return null;
		}

		protected bool OnContinueButtonHotkey()
		{
			return false;
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		public void OnPrepareConversationLine(DialogueEntry entry)
		{
		}

		public void OnContinue()
		{
		}

		public void PreparePortrait()
		{
		}

		public void ForceShowPortrait()
		{
		}

		private void UpdatePortrait(Subtitle subtitle)
		{
		}

		private void LoadPortraitAsync(Actor actor)
		{
		}

		public void UnloadPortraitAsync()
		{
		}

		private void SetPortrait(AsyncOperationHandle<Sprite> portraitHandle)
		{
		}

		private bool SubtitleEmpty(Subtitle subtitle)
		{
			return false;
		}

		public void EnableContinue(Subtitle subtitle)
		{
		}

		public void CheckIfSequence(DialogueEntry entry)
		{
		}

		public void EnableContinue(DialogueEntry entry)
		{
		}

		private void ChooseContinue(Prediction prediction)
		{
		}

		public void OnConversationResponseMenu(Response[] responses)
		{
		}

		public static bool NextSequence(DialogueEntry entry)
		{
			return false;
		}

		public FinalEntry AssembleFinalEntry(DialogueEntry entry, CheckResult checkResult = null, bool isLocalizationTrigger = false)
		{
			return null;
		}

		public string FormatResponse(int counter, FinalResponseText response)
		{
			return null;
		}

		public FinalResponseText ChooseResponseText(Response response)
		{
			return null;
		}

		private float CalculateVerticalScrollSpeed()
		{
			return 0f;
		}
	}
}
