using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityAlertControls : AbstractUIAlertControls
	{
		public GUIControl panel;

		public GUILabel line;

		public GUIButton continueButton;

		public override bool isVisible => false;

		public override void SetActive(bool value)
		{
		}

		public override void SetMessage(string message, float duration)
		{
		}

		private void SetFadeDuration(GameObject go, float duration)
		{
		}
	}
}
