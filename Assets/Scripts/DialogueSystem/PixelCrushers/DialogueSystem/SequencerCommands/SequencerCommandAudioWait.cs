using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandAudioWait : SequencerCommand
	{
		private float stopTime;

		private AudioSource audioSource;

		private int nextClipIndex;

		private AudioClip currentClip;

		private AudioClip originalClip;

		private bool restoreOriginalClip;

		public IEnumerator Start()
		{
			return null;
		}

		private void TryAudioClip(string audioClipName)
		{
		}

		public void Update()
		{
		}

		public void OnDialogueSystemPause()
		{
		}

		public void OnDialogueSystemUnpause()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
