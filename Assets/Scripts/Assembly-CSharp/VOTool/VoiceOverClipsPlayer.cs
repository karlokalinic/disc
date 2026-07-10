using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace VOTool
{
	public class VoiceOverClipsPlayer : LiteSingleton<VoiceOverClipsPlayer>
	{
		public static UnityEvent OneTimeAfterVOPlayed;

		private static DialogueEntry lastEntry;

		public VoiceOverClipsLibrary voiceOverClipsLibrary;

		private AudioSource audioSource;

		private float stopTime;

		private float startTime;

		private Coroutine coroutine;

		private bool dictonaryIsReady;

		private Dictionary<string, VoiceClipInformation> clipDictonary;

		private AsyncOperationHandle<AudioClip> lastDialogueVoiceOverAdressable;

		protected override void Awake()
		{
		}

		private void Start()
		{
		}

		public IEnumerator CreateVODictonary()
		{
			return null;
		}

		public static bool HaveVoiceClip(DialogueEntry entry)
		{
			return false;
		}

		public static void PlayLastClip()
		{
		}

		public static bool PlayVoiceClip(DialogueEntry entry)
		{
			return false;
		}

		public static void PlayBarkVoiceOver(DialogueEntry entry, AudioSource audioSource)
		{
		}

		public static void PlayVoiceClipOnAudioSource(DialogueEntry entry, AudioSource audioSource, bool checkIfAdressableExist = false)
		{
		}

		public static void StopVoiceClipIfOneIsAlreadyPlaying()
		{
		}

		public static void PlayVoiceFromAdressables(string path)
		{
		}

		private bool PlayVoiceInDialogue(DialogueEntry entry, bool checkIfAdressableExist = false)
		{
			return false;
		}

		private void PlayAudioClipDelegate(AsyncOperationHandle<AudioClip> handle)
		{
		}

		private VoiceClipInformation GetClipToPlay(string articyID)
		{
			return null;
		}

		private IEnumerator StopTime()
		{
			return null;
		}

		private void StopPreviousVOClipIfActive()
		{
		}
	}
}
