using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIAlertControls : AbstractUIAlertControls
	{
		public UIPanel panel;

		public UITextField alertText;

		public bool queueAlerts;

		public bool dontQueueDuplicates;

		public bool waitForHideAnimation;

		public bool allowForceImmediate;

		private bool m_initializedAnimator;

		public override bool isVisible => false;

		public bool isHiding => false;

		public override void SetActive(bool value)
		{
		}

		public void HideImmediate()
		{
		}

		public override void SetMessage(string message, float duration)
		{
		}
	}
}
