using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandAudioWaitOnce : SequencerCommand
	{
		private static string _VarPrefix;

		private float _stopTime;

		private AudioSource _audioSource;

		private int _nextClipIndex;

		private AudioClip _currentClip;

		private AudioClip _originalClip;

		private bool _restoreOriginalClip;

		public IEnumerator Start()
		{
			return null;
		}

		private void TryAudioClip(string audioClipName)
		{
		}

		private string buildOnceVarName(string audioClipName)
		{
			return null;
		}

		private bool hasPlayedAlready(string audioClipName)
		{
			return false;
		}

		private void markAsPlayedAlready(string audioClipName)
		{
		}

		private bool hasNextClip()
		{
			return false;
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
