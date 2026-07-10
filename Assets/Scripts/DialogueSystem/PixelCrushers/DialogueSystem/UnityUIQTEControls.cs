using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIQTEControls : AbstractUIQTEControls
	{
		public Graphic[] qteIndicators;

		private int numVisibleQTEIndicators;

		public override bool areVisible => false;

		public UnityUIQTEControls(Graphic[] qteIndicators)
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
