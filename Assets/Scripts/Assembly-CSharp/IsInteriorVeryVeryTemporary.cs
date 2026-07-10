using UnityEngine;

public class IsInteriorVeryVeryTemporary : MonoBehaviour
{
	public bool isInterior;

	private static bool _isInterior;

	private const string playlistController = "PLC_Weather_Sounds";

	private const string playlist = "Weather_Sounds";

	public static bool IsInterior => false;

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void OnDisable()
	{
	}

	private void ToggleWeatherSounds(bool to)
	{
	}
}
