using System;
using UnityEngine;

[CreateAssetMenu]
public class AudioValues : ScriptableObject
{
	[Serializable]
	public struct SoundAndGroup
	{
		public string sound;

		public string group;
	}

	private static AudioValues instance;

	[SerializeField]
	private float inDialogueAudioVolumeMultiplayer;

	[SerializeField]
	private float inMenuAudioVolumeMultiplayer;

	[SerializeField]
	private float masterPlaylistDefaultVolume;

	[SerializeField]
	private SoundAndGroup mainMenuConfirm;

	[SerializeField]
	private SoundAndGroup saveGameConfirm;

	[SerializeField]
	private SoundAndGroup resolutionConfirm;

	[SerializeField]
	private SoundAndGroup newThoughtSlotConfirm;

	[SerializeField]
	private SoundAndGroup thoughtSplashScreenAccept;

	[SerializeField]
	private SoundAndGroup revertLevelUpCHR;

	[SerializeField]
	private SoundAndGroup acceptChangesCHR;

	[SerializeField]
	private SoundAndGroup selectArchetypeContinue;

	public float InDialogueAudioVolumeMultiplayer => 0f;

	public float InMenuAudioVolumeMultiplayer => 0f;

	public float MasterPlaylistDefaultVolume => 0f;

	public SoundAndGroup MainMenuConfirm => default(SoundAndGroup);

	public SoundAndGroup SaveGameConfirm => default(SoundAndGroup);

	public SoundAndGroup ResolutionConfirm => default(SoundAndGroup);

	public SoundAndGroup NewThoughtSlotConfirm => default(SoundAndGroup);

	public SoundAndGroup ThoughtSplashScreenAccept => default(SoundAndGroup);

	public SoundAndGroup RevertLevelUpCHR => default(SoundAndGroup);

	public SoundAndGroup AcceptChangesCHR => default(SoundAndGroup);

	public SoundAndGroup SelectArchetypeContinue => default(SoundAndGroup);

	public static AudioValues Instance => null;
}
