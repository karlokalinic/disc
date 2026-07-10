using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandAudioPlay : SequencerCommand
	{
		private float stopTime;

		private AudioSource audioSource;

		private float volume;

		public void Start()
		{
		}

		private void PlayAudioClip(string audioClipName)
		{
		}

		private void PlayAudioClipDelegate(AsyncOperationHandle<AudioClip> handle)
		{
		}

		public void OnDestroy()
		{
		}
	}
}
