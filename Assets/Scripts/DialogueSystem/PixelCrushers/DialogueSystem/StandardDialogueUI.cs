using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrushers.DialogueSystem
{
	public class StandardDialogueUI : CanvasDialogueUI, IStandardDialogueUI
	{
		public StandardUIAlertControls alertUIElements;

		public StandardUIDialogueControls conversationUIElements;

		public StandardUIQTEControls QTEIndicatorElements;

		public bool addEventSystemIfNeeded;

		private Queue<QueuedUIAlert> m_alertQueue;

		private StandardUIRoot m_uiRoot;

		public override AbstractUIRoot uiRootControls => null;

		public override AbstractUIAlertControls alertControls => null;

		public override AbstractDialogueUIControls dialogueControls => null;

		public override AbstractUIQTEControls qteControls => null;

		protected Queue<QueuedUIAlert> alertQueue => null;

		public override void Awake()
		{
		}

		private void VerifyAssignments()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public override void Open()
		{
		}

		public override void Update()
		{
		}

		public override void ShowAlert(string message, float duration)
		{
		}

		private void UpdateAlertQueue()
		{
		}

		private void ShowNextQueuedAlert()
		{
		}

		public override void ShowSubtitle(Subtitle subtitle)
		{
		}

		public override void HideSubtitle(Subtitle subtitle)
		{
		}

		public virtual float GetTypewriterSpeed()
		{
			return 0f;
		}

		public virtual void SetTypewriterSpeed(float charactersPerSecond)
		{
		}

		public virtual void SetActorSubtitlePanelNumber(DialogueActor dialogueActor, SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		public virtual void SetActorMenuPanelNumber(DialogueActor dialogueActor, MenuPanelNumber menuPanelNumber)
		{
		}

		public virtual void OverrideActorPanel(Actor actor, SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		public override void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		public override void OnClick(object data)
		{
		}

		public virtual void OverrideActorMenuPanel(Transform actorTransform, MenuPanelNumber menuPanelNumber, StandardUIMenuPanel customPanel)
		{
		}
	}
}
