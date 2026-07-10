using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIQTEControls : AbstractUIQTEControls
	{
		public GameObject[] QTEIndicators;

		private int m_numVisibleQTEIndicators;

		public override bool areVisible => false;

		public override void SetActive(bool value)
		{
		}

		public void HideImmediate()
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
