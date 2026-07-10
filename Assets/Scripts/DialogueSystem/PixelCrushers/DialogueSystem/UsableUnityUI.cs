using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UsableUnityUI : AbstractUsableUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public Text nameText;

		public Text useMessageText;

		public Color inRangeColor;

		public Color outOfRangeColor;

		public Graphic reticleInRange;

		public Graphic reticleOutOfRange;

		public AnimationTransitions animationTransitions;

		private Canvas canvas;

		private Animator animator;

		public void Awake()
		{
		}

		public void Start()
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
