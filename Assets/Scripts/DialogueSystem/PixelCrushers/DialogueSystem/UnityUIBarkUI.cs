using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIBarkUI : AbstractBarkUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public CanvasGroup canvasGroup;

		public Text barkText;

		public Text nameText;

		public bool includeName;

		[HideInInspector]
		public float doneTime;

		public AnimationTransitions animationTransitions;

		public float duration;

		public bool waitUntilSequenceEnds;

		public bool waitForContinueButton;

		public BarkSubtitleSetting textDisplaySetting;

		private Canvas canvas;

		private Animator animator;

		public override bool isPlaying => false;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public bool ShouldShowText(Subtitle subtitle)
		{
			return false;
		}

		public override void Bark(Subtitle subtitle)
		{
		}

		private void SetUIElementsActive(bool value)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnContinue()
		{
		}

		public override void Hide()
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
