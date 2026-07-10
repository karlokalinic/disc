using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIResponseMenuControls : AbstractUIResponseMenuControls
	{
		public Graphic panel;

		public Image pcImage;

		public Text pcName;

		public UnityUISubtitleControls subtitleReminder;

		public Slider timer;

		public bool selectCurrentOnTimeout;

		public UnityUIResponseButton[] buttons;

		public UnityUIResponseButton buttonTemplate;

		public Graphic buttonTemplateHolder;

		public Scrollbar buttonTemplateScrollbar;

		public float buttonTemplateScrollbarResetValue;

		public bool explicitNavigationForTemplateButtons;

		public bool loopExplicitNavigation;

		public UIAutonumberSettings autonumber;

		public UIAnimationTransitions animationTransitions;

		public UnityEvent onContentChanged;

		[HideInInspector]
		public List<GameObject> instantiatedButtons;

		public Action TimeoutHandler;

		private UIShowHideController m_showHideController;

		private UnityUITimer unityUITimer;

		private Sprite pcPortraitSprite;

		private string pcPortraitName;

		private Animator animator;

		private bool lookedForAnimator;

		private ObjectPool responsesPool;

		public bool isVisible => false;

		public UIShowHideController showHideController => null;

		public override AbstractUISubtitleControls subtitleReminderControls => null;

		public override void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public void Initialize()
		{
		}

		public override void SetActive(bool value)
		{
		}

		private void DeactivateUIElements()
		{
		}

		protected override void ClearResponseButtons()
		{
		}

		protected override void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		private int GetNextAvailableResponseButtonPosition(int start, int direction)
		{
			return 0;
		}

		public void SetupTemplateButtonNavigation()
		{
		}

		public void DestroyInstantiatedButtons()
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
	}
}
