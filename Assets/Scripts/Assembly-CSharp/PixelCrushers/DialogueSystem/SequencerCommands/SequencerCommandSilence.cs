using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandSilence : SequencerCommand
	{
		private AudioSource audioSource;

		private void Start()
		{
		}

		public static AudioSource GetAudioSource()
		{
			return null;
		}
	}
}
