using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIDialogueUI : CanvasDialogueUI
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

		public UnityUIDialogueControls dialogue;

		public Graphic[] qteIndicators;

		public UnityUIAlertControls alert;

		public bool autoFocus;

		public bool allowStealFocus;

		public float autoFocusCheckFrequency;

		public bool findActorOverrides;

		public bool addEventSystemIfNeeded;

		private UnityUIQTEControls m_qteControls;

		private float m_nextAutoFocusCheckTime;

		private GameObject m_lastSelection;

		private Queue<QueuedAlert> alertQueue;

		protected UnityUISubtitleControls originalNPCSubtitle;

		protected UnityUISubtitleControls originalPCSubtitle;

		protected UnityUIResponseMenuControls originalResponseMenu;

		private Dictionary<Transform, OverrideUnityUIDialogueControls> overrideCache;

		private bool isShowingNpcSubtitle;

		private bool isShowingPcSubtitle;

		private bool isShowingResponses;

		protected int alertQueueCount;

		protected bool alertIsVisible;

		protected bool alertIsHiding;

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

		private void FindControls()
		{
		}

		public OverrideUnityUIDialogueControls FindActorOverride(Transform actor)
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

		protected void CheckForSupercededSubtitle(CharacterType characterType)
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

		private IEnumerator ShowResponsesAfterHidden(Subtitle subtitle, Response[] responses, float timeout)
		{
			return null;
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
