using System.Collections;
using UnityEngine;

public class WeatherRandomizerRealtime : MonoBehaviour
{
	public float weatherChangeInterval;

	public float weatherChangeFade;

	public float inDialogueMultiplier;

	public static float multiplier;

	private WeatherController _wc;

	private Coroutine cor;

	public static WeatherRandomizerRealtime instance;

	private WeatherPreset previousPreset;

	private WeatherController WC => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private IEnumerator WeatherDriver()
	{
		return null;
	}

	private void Bang()
	{
	}

	private void Bang10()
	{
	}
}
