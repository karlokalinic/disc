using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class UsableTextMeshPro : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public TextMeshProUGUI nameText;

		public TextMeshProUGUI useMessageText;

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

		public void Show(string useMessage)
		{
		}

		public void Hide()
		{
		}

		public void OnBarkStart(Transform actor)
		{
		}

		public void UpdateDisplay(bool inRange)
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
