using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.I2Support
{
	public class DialogueSystemUseI2RTLFix : MonoBehaviour
	{
		public List<string> additionalRTLLanguageCodes;

		public bool alignRTLToRight;

		public int textLimit;

		private bool IsRTL()
		{
			return false;
		}

		private void OnConversationStart(Transform actor)
		{
		}

		private void SetTextFieldAlignment(UITextField textField)
		{
		}

		private void OnConversationLine(Subtitle subtitle)
		{
		}

		private void OnConversationResponseMenu(Response[] responses)
		{
		}
	}
}
