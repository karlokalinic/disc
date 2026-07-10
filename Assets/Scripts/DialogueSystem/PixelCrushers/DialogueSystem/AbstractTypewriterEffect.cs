using System.Collections;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class AbstractTypewriterEffect : MonoBehaviour
	{
		public bool rightToLeft;

		public float charactersPerSecond;

		public AudioClip audioClip;

		public AudioClip[] alternateAudioClips;

		public AudioSource audioSource;

		public bool interruptAudioClip;

		public bool usePlayOneShot;

		public string silentCharacters;

		public string fullPauseCharacters;

		public string quarterPauseCharacters;

		public float fullPauseDuration;

		public float quarterPauseDuration;

		public bool removeDuplicateTypewriterEffects;

		public bool playOnEnable;

		public bool waitOneFrameBeforeStarting;

		public bool stopOnConversationEnd;

		protected bool paused;

		public abstract bool isPlaying { get; }

		public virtual float GetSpeed()
		{
			return 0f;
		}

		public virtual void SetSpeed(float charactersPerSecond)
		{
		}

		public abstract void Awake();

		public abstract void Start();

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void StopOnConversationEnd(Transform actor)
		{
		}

		public abstract void Stop();

		public abstract void StartTyping(string text, int fromIndex = 0);

		public abstract void StopTyping();

		public static string StripRPGMakerCodes(string s)
		{
			return null;
		}

		protected bool IsFullPauseCharacter(char c)
		{
			return false;
		}

		protected bool IsQuarterPauseCharacter(char c)
		{
			return false;
		}

		protected bool IsSilentCharacter(char c)
		{
			return false;
		}

		protected bool IsCharacterInString(char c, string s)
		{
			return false;
		}

		protected virtual void PlayCharacterAudio()
		{
		}

		protected IEnumerator PauseForDuration(float duration)
		{
			return null;
		}
	}
}
