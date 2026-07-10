using UnityEngine;

public class DialogSoundController : LiteSingleton<DialogSoundController>
{
	public AudioSource voiceOverAudioSource;

	public AudioSource soundEffectAudioSource;

	public AudioSource loopAudioSource;

	public static void StopVoiceOver()
	{
	}
}
