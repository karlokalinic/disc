using UnityEngine;

namespace PixelCrushers.DialogueSystem.I2Support
{
	public class DialogueSystemUseI2Language : MonoBehaviour
	{
		public I2LanguageIdentifierType specifyLanguageBy;

		public bool useI2LanguageOnStart;

		public bool useI2LanguageAtRuntime;

		private void Start()
		{
		}

		public void UseCurrentI2Language()
		{
		}

		protected void OnConversationLine(Subtitle subtitle)
		{
		}

		protected void OnConversationResponseMenu(Response[] responses)
		{
		}
	}
}
