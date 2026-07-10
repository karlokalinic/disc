using System.Collections;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace VOTool
{
	public class VoiceOverPlayer
	{
		private AudioSource audioSource;

		public VoiceOverPlayer(DialogueEntry entry, VoiceClipInformation clip, AudioSource aSource, bool checkIfAdressableExist = false)
		{
		}

		private bool PlayVoice(DialogueEntry entry, VoiceClipInformation clip, bool checkIfAdressableExist = false)
		{
			return false;
		}

		private void PlayAudioClipDelegate(AsyncOperationHandle<AudioClip> handle)
		{
		}

		private static IEnumerator UnloadAudioClipOnPlayFinished(AsyncOperationHandle<AudioClip> handle, AudioSource audioSource)
		{
			return null;
		}
	}
}
