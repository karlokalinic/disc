using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIAlertControls : AbstractUIAlertControls
	{
		public Graphic panel;

		public Text line;

		public Button continueButton;

		public bool queueAlerts;

		public bool waitForHideAnimation;

		public UIAnimationTransitions animationTransitions;

		private UIShowHideController m_showHideController;

		public override bool isVisible => false;

		public bool IsHiding => false;

		private UIShowHideController showHideController => null;

		public override void SetActive(bool value)
		{
		}

		private void ShowPanel()
		{
		}

		private void HidePanel()
		{
		}

		public void ActivateUIElements()
		{
		}

		public void DeactivateUIElements()
		{
		}

		public override void SetMessage(string message, float duration)
		{
		}

		public void AutoFocus(bool allowStealFocus = true)
		{
		}
	}
}
