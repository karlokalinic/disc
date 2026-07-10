using System;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityQTEControls : AbstractUIQTEControls
	{
		public GUIControl[] qteIndicators;

		private int numVisibleQTEIndicators;

		public override bool areVisible => false;

		public UnityQTEControls(GUIControl[] qteIndicators)
		{
		}

		public override void SetActive(bool value)
		{
		}

		public override void ShowIndicator(int index)
		{
		}

		public override void HideIndicator(int index)
		{
		}

		private bool IsQTEIndicatorVisible(int index)
		{
			return false;
		}

		private bool IsValidQTEIndex(int index)
		{
			return false;
		}
	}
}
