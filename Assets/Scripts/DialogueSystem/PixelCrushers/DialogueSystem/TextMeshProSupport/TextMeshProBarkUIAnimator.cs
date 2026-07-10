using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProBarkUIAnimator : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		public AnimationTransitions animationTransitions;

		private TextMeshProBarkUI barkUI;

		private UIShowHideController showHideController;

		private bool isVisible;

		public void Start()
		{
		}

		public void OnShowedBark(TextMeshProBarkUI barkUI)
		{
		}

		public void OnHidBark(TextMeshProBarkUI barkUI)
		{
		}

		private void CheckShowHideController()
		{
		}

		private void ShowControls()
		{
		}

		private void HideControls()
		{
		}
	}
}
