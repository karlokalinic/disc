using System;
using TMPro;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	[Serializable]
	public class TextMeshProQuestTemplateAlternateDescriptions
	{
		public TextMeshProUGUI successDescription;

		public TextMeshProUGUI failureDescription;

		public void SetActive(bool value)
		{
		}
	}
}
