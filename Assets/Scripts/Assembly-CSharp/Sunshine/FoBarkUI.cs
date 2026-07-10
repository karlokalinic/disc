using PixelCrushers.DialogueSystem;
using UnityEngine;

namespace Sunshine
{
	public class FoBarkUI : AbstractBarkUI
	{
		[SerializeField]
		private Vector3 barkOffset;

		public override bool isPlaying => false;

		public override void Bark(Subtitle subtitle)
		{
		}

		public void BarkLocalized(string barkTerm, DialogueEntry dialogueEntry)
		{
		}

		private static void PlayVoiceOverBark(string barkTerm, DialogueEntry dialogueEntry, FloatTemplate barkUI)
		{
		}

		public override void Hide()
		{
		}
	}
}
