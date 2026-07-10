using UnityEngine;

public class Precipitation : MonoBehaviour
{
	private const string playlistController = "PLC_Weather_Sounds";

	private const string playlist = "Weather_Sounds";

	private ParticleSystem[] _particleSystems;

	private float[] _particleSystemEmissions;

	public string audioLoop;

	public bool musicRequestToggle;

	public string musicSongName;

	public float musicPriority;

	public bool followTarget;

	public Transform targetToFollow;

	private WeatherPreset wp;

	private bool destroying;

	private ParticleSystem[] ParticleSystems => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public virtual void PlaySound(float fadeTime = 5f)
	{
	}

	public virtual void StopSound(float fadeTime = 5f)
	{
	}

	public virtual void SetAmount(float t)
	{
	}

	private void HideIfInterior()
	{
	}

	public bool HasActiveParticles()
	{
		return false;
	}

	public void DestroyParticles(WeatherPreset wpIn, bool instant = false)
	{
	}
}
