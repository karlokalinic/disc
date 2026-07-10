using UnityEngine;
using UnityEngine.Events;
using Voidforge;

public class WeatherController : SingletonComponent<WeatherController>
{
	public enum WeatherEffect
	{
		DRYING = 0,
		WETTING = 1,
		SNOWING = 2,
		MELTING = 3,
		SNOWTOSNOW = 4
	}

	public WeatherMask cloudMask;

	public float windSpeed;

	public Vector2 windDirection;

	public Cloudiness[] cloudinesses;

	private WindZone _windZone;

	public Texture2D pointTexture;

	public float rainSpots;

	public WeatherMask wetMask;

	public float dryingDuration;

	public float wettingDuration;

	public WeatherMask snowMask;

	public WeatherPreset[] weatherPresets;

	public bool debug;

	public int weatherPresetA;

	public int weatherPresetB;

	public float weatherPresetMix;

	public Transform precipitationPosition;

	public LevelCorrection activeLevelCorrection;

	public Cloudiness activeCloudiness;

	public float fogStart;

	public float fogEnd;

	public Color fogColor;

	[Space]
	public float FO_RAIN_COMTRAST;

	public float FO_RAIN_TIPTIP;

	public float FO_RAIN_MAXWET;

	public float FO_TIPTIP_SIZE;

	[Space]
	public static bool isDeserialized;

	public UnityEvent<string> OnWeatherChanged;

	public float weatherTransitionTime;

	public WeatherControllerState controllerState;

	public WeatherEffect we;

	private static string overridingPreset;

	private static float overridingTime;

	public static float overcastOverride;

	private bool bSoundsTriggered;

	private static readonly int start;

	private static readonly int end;

	private static readonly int color;

	private static readonly int wWindControl;

	private static readonly int wEval;

	private static readonly int wPointTex;

	private static readonly int wcWetness;

	private static readonly int foRainComtrast;

	private static readonly int foRainTiptip;

	private static readonly int foRainMaxwet;

	private static readonly int foTiptipSize;

	public WindZone windZone => null;

	public static int GetLastUsedWeatherPresetID => 0;

	public static string GetLastUsedWeatherPresetName => null;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void OnValidate()
	{
	}

	private void Update()
	{
	}

	public static void TriggerWeather(string weatherPresetName, float transitionTime = -1f)
	{
	}

	private static int PresetNameToIndex(string weatherPresetName)
	{
		return 0;
	}

	public static void TriggerWeather(int weatherPreset, float transitionTime = -1f)
	{
	}

	private void SendGlobalsToShader()
	{
	}

	public void EvaluateWeather()
	{
	}

	public static void ResetToClear()
	{
	}

	public Cloudiness EvaluateCloudiness(float amount)
	{
		return null;
	}

	public WeatherPreset GetRandomWeather()
	{
		return null;
	}
}
