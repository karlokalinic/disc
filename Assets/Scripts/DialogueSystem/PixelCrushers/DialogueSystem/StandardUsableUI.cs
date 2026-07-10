using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUsableUI : AbstractUsableUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public UITextField nameText;

		public UITextField useMessageText;

		public Color inRangeColor;

		public Color outOfRangeColor;

		public Graphic reticleInRange;

		public Graphic reticleOutOfRange;

		public AnimationTransitions animationTransitions;

		public Canvas canvas;

		protected Animator animator;

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public override void Show(string useMessage)
		{
		}

		public override void Hide()
		{
		}

		public void OnBarkStart(Transform actor)
		{
		}

		public void OnConversationStart(Transform actor)
		{
		}

		public override void UpdateDisplay(bool inRange)
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
