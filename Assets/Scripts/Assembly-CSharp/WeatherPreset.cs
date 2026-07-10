using UnityEngine;

[CreateAssetMenu]
public class WeatherPreset : ScriptableObject
{
	public WeatherType type;

	public float typeAmount;

	public float windStrength;

	public float defaultCloudiness;

	public float defaultTransitionTime;

	[Space]
	public bool useLevelCorrection;

	public LevelCorrectionPreset levelCorrection;

	[Space]
	public bool usePrecipitation;

	public Precipitation precipitationPrefab;

	private Precipitation _precipitation;

	[Space]
	public bool usesFog;

	public float fogStart;

	public float fogEnd;

	public Color fogColor;

	[HideInInspector]
	public float cloudiness;

	[HideInInspector]
	public float transitionTime;

	public float relativeTimeActive;

	[Space]
	public float probabilityRatio;

	[Space]
	public bool hasAudioLoop;

	public string audioLoop;

	private const string playlistController = "PLC_Weather_Sounds";

	private const string playlist = "Weather_Sounds";

	public Precipitation Precipitation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void DestroyParticles(bool instant = false)
	{
	}

	public void ParticlesToNull()
	{
	}

	public void OnValidate()
	{
	}

	public void OnActivatePreset(float transitionTime = 5f)
	{
	}

	public void OnDeactivatePreset(float transitionTime = 5f)
	{
	}

	public virtual void PlaySound(float fadeTime = 5f)
	{
	}

	public virtual void SetNewFadeTime(float fadeTime)
	{
	}

	public virtual void StopSound(float fadeTime = 5f)
	{
	}
}
