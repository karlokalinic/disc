using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class Subtitle
	{
		public CharacterInfo speakerInfo;

		public CharacterInfo listenerInfo;

		public FormattedText formattedText;

		public string sequence;

		public string responseMenuSequence;

		public DialogueEntry dialogueEntry;

		public string entrytag;

		public Subtitle(CharacterInfo speakerInfo, CharacterInfo listenerInfo, FormattedText formattedText, string sequence, string responseMenuSequence, DialogueEntry dialogueEntry)
		{
		}

		public Subtitle(CharacterInfo speakerInfo, CharacterInfo listenerInfo, FormattedText formattedText, string sequence, string responseMenuSequence, DialogueEntry dialogueEntry, string entrytag)
		{
		}

		private void CheckVariableInputPrompt()
		{
		}

		public Sprite GetSpeakerPortrait()
		{
			return null;
		}
	}
}
