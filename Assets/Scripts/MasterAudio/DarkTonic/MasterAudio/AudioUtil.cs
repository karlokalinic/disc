using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public static class AudioUtil
	{
		private const float SemitonePitchChangeAmt = 1.0594635f;

		public static float FrameTime => 0f;

		public static float GetSemitonesFromPitch(float pitch)
		{
			return 0f;
		}

		public static float GetPitchFromSemitones(float semitones)
		{
			return 0f;
		}

		public static float GetDbFromFloatVolume(float vol)
		{
			return 0f;
		}

		public static float GetFloatVolumeFromDb(float db)
		{
			return 0f;
		}

		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return 0f;
		}

		public static bool IsAudioPaused(AudioSource source)
		{
			return false;
		}

		public static void UnloadNonPreloadedAudioData(AudioClip clip)
		{
		}

		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return false;
		}

		public static bool IsClipReadyToPlay(AudioClip clip)
		{
			return false;
		}
	}
}
