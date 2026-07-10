using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProQuestTemplate : MonoBehaviour
	{
		public Button heading;

		public TextMeshProUGUI description;

		public TextMeshProUGUI entryDescription;

		public Button trackButton;

		public Button abandonButton;

		public bool ArePropertiesAssigned => false;
	}
}
