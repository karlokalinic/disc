using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardBarkUI : AbstractBarkUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public CanvasGroup canvasGroup;

		public UITextField barkText;

		public UITextField nameText;

		public bool includeName;

		public Image portraitImage;

		public bool showPortraitImage;

		[HideInInspector]
		public float doneTime;

		public AnimationTransitions animationTransitions;

		public float duration;

		public bool keepInView;

		public bool waitUntilSequenceEnds;

		public bool waitForContinueButton;

		public BarkSubtitleSetting textDisplaySetting;

		protected int numSequencesActive;

		protected Canvas canvas { get; set; }

		protected Animator animator { get; set; }

		protected Vector3 originalCanvasLocalPosition { get; set; }

		public override bool isPlaying => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected void Update()
		{
		}

		public virtual bool ShouldShowText(Subtitle subtitle)
		{
			return false;
		}

		public override void Bark(Subtitle subtitle)
		{
		}

		protected virtual void SetUIElementsActive(bool value)
		{
		}

		public virtual void OnBarkEnd(Transform actor)
		{
		}

		public virtual void OnContinue()
		{
		}

		public override void Hide()
		{
		}

		protected virtual bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
