using System.Collections;
using UnityEngine;

public class ConfigurationManager : MonoBehaviour
{
	public const string VOLUME_AMBIENT = "volumeAmbient";

	public const string VOLUME_UI = "volumeUI";

	public const string VOLUME_MUSIC = "volumeMusic";

	public const string VOLUME_DIALOGUE = "volumeDialogue";

	public const string VOLUME_VOICEOVER = "volumeVoiceover";

	public const string VOLUME_WEATHER = "volumeWeather";

	public IEnumerator Start()
	{
		return null;
	}

	public static float GetAudioSetting(string settingName)
	{
		return 0f;
	}
}
