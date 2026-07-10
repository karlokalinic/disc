using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ActorSubtitleColor : MonoBehaviour
	{
		public enum ApplyTo
		{
			DialogueText = 0,
			PrependedActorName = 1
		}

		public Color color;

		public ApplyTo applyTo;

		public string prependActorNameSeparator;

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		public void OnBarkLine(Subtitle subtitle)
		{
		}

		private void CheckSubtitle(Subtitle subtitle)
		{
		}

		private string ProcessText(Subtitle subtitle)
		{
			return null;
		}
	}
}
