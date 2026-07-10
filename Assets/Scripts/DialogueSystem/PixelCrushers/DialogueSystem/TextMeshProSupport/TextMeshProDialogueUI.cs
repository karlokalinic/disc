using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProDialogueUI : CanvasDialogueUI
	{
		private class QueuedAlert
		{
			public string message;

			public float duration;

			public QueuedAlert(string message, float duration)
			{
			}
		}

		[HideInInspector]
		public UnityUIRoot unityUIRoot;

		public TextMeshProDialogueControls dialogue;

		public Graphic[] qteIndicators;

		public TextMeshProAlertControls alert;

		public bool autoFocus;

		public bool allowStealFocus;

		public float autoFocusCheckFrequency;

		public bool findActorOverrides;

		public bool addEventSystemIfNeeded;

		private UnityUIQTEControls uiQTEControls;

		private float nextAutoFocusCheckTime;

		private GameObject lastSelection;

		private Queue<QueuedAlert> alertQueue;

		private TextMeshProSubtitleControls originalNPCSubtitle;

		private TextMeshProSubtitleControls originalPCSubtitle;

		protected TextMeshProResponseMenuControls originalResponseMenu;

		private Dictionary<Transform, OverrideTextMeshProDialogueControls> overrideCache;

		private bool isShowingNpcSubtitle;

		private bool isShowingPcSubtitle;

		private bool isShowingResponses;

		public int alertQueueCount;

		public bool alertIsVisible;

		public bool alertIsHiding;

		public override AbstractUIRoot uiRootControls => null;

		public override AbstractDialogueUIControls dialogueControls => null;

		public override AbstractUIQTEControls qteControls => null;

		public override AbstractUIAlertControls alertControls => null;

		public override void Awake()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		protected virtual void FindControls()
		{
		}

		protected OverrideTextMeshProDialogueControls FindActorOverride(Transform actor)
		{
			return null;
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public override void Open()
		{
		}

		public override void ShowAlert(string message, float duration)
		{
		}

		private void ShowNextQueuedAlert()
		{
		}

		private void StartShowingAlert(string message, float duration)
		{
		}

		public override void ShowSubtitle(Subtitle subtitle)
		{
		}

		private void CheckForSupercededSubtitle(CharacterType characterType)
		{
		}

		public void CheckSubtitleAutoFocus(Subtitle subtitle)
		{
		}

		protected void SetIsShowingSubtitle(Subtitle subtitle, bool value)
		{
		}

		public override void HideSubtitle(Subtitle subtitle)
		{
		}

		public override void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		public void CheckResponseMenuAutoFocus()
		{
		}

		public override void HideResponses()
		{
		}

		public void ClearSelection()
		{
		}

		public override void Update()
		{
		}
	}
}
