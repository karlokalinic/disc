using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	[Serializable]
	public class TextMeshProResponseMenuControls : AbstractUIResponseMenuControls
	{
		[Serializable]
		public class AutonumberSettings
		{
			public bool enabled;

			public string format;
		}

		public Graphic panel;

		public Image pcImage;

		public TextMeshProUGUI pcName;

		public TextMeshProSubtitleControls subtitleReminder;

		public Slider timer;

		public bool selectCurrentOnTimeout;

		public TextMeshProResponseButton[] buttons;

		public TextMeshProResponseButton buttonTemplate;

		public Graphic buttonTemplateHolder;

		public Scrollbar buttonTemplateScrollbar;

		public float buttonTemplateScrollbarResetValue;

		public bool explicitNavigationForTemplateButtons;

		public AutonumberSettings autonumber;

		public UIAnimationTransitions animationTransitions;

		public UnityEvent onContentChanged;

		[HideInInspector]
		public List<GameObject> instantiatedButtons;

		public Action TimeoutHandler;

		private UIShowHideController m_showHideController;

		private bool isHiding;

		private UnityUITimer unityUITimer;

		private Sprite pcPortraitSprite;

		private string pcPortraitName;

		private Animator animator;

		private bool lookedForAnimator;

		public bool isVisible => false;

		private UIShowHideController showHideController => null;

		public override AbstractUISubtitleControls subtitleReminderControls => null;

		public override void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public override void SetActive(bool value)
		{
		}

		protected override void ClearResponseButtons()
		{
		}

		protected override void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		private void SetResponseButton(TextMeshProResponseButton button, Response response, Transform target, int buttonNumber)
		{
		}

		protected int GetNextAvailableResponseButtonPosition(int start, int direction)
		{
			return 0;
		}

		private void SetupTemplateButtonNavigation()
		{
		}

		public virtual void DestroyInstantiatedButtons()
		{
		}

		public void NotifyContentChanged()
		{
		}

		public override void StartTimer(float timeout)
		{
		}

		public virtual void OnTimeout()
		{
		}

		public void DefaultTimeoutHandler()
		{
		}

		public void AutoFocus(GameObject lastSelection = null, bool allowStealFocus = true)
		{
		}

		private bool CanTriggerAnimation(string triggerName)
		{
			return false;
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}

		private IEnumerator DisableAfterAnimation(Graphic panel)
		{
			return null;
		}
	}
}
