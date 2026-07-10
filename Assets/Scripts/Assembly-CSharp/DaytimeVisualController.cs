using System;
using UnityEngine;

public class DaytimeVisualController : MonoBehaviour
{
	[Serializable]
	public struct DaytimeTiming
	{
		public Daytime daytime;

		public DaytimeVisual[] daytimeVisuals;

		public float time;
	}

	[SerializeField]
	private DaytimeVisual[] daytimeVisuals;

	public DaytimeTiming[] daytimeTimings;

	public float time;

	public float desiredTime;

	[SerializeField]
	private int h;

	[SerializeField]
	private int m;

	public float overcast;

	public bool attachToSunshineClock;

	[SerializeField]
	public DaytimeVisual ovrDTV1;

	[SerializeField]
	public DaytimeVisual ovrDTV2;

	[SerializeField]
	private bool ovrSwap;

	public Light sun;

	public GameObject shadowRotator;

	public Transform mornT;

	public Transform noonT;

	public Transform eveT;

	public Texture2D cloudTex;

	public Texture2D screenSpaceSpecular;

	public AnimationCurve sunIntensity;

	public Gradient sky;

	public AnimationCurve skyIntensity;

	[Space]
	public Texture2D shadowGradFrom;

	public Texture2D shadowGradTo;

	public float lutLerp;

	[Space]
	public float mornToNoonSwitch;

	public float noonToEveSwitch;

	public static bool lockVisuals;

	public AnimationCurve aniDir;

	public AnimationCurve aniOvc;

	public AnimationCurve aniEmit;

	public static bool nightlightsStreet;

	public static bool nightlightsWindow;

	public static float timescale;

	private string[] varArray;

	public static DaytimeVisualController Singleton { get; private set; }

	private void Awake()
	{
	}

	public void OnM()
	{
	}

	public void OnN()
	{
	}

	public void OnE()
	{
	}

	public void OnB()
	{
	}

	public void OnQ()
	{
	}

	public void OnL()
	{
	}

	public void OnCaptureScreenshot()
	{
	}

	private void Update()
	{
	}

	private void OnValidate()
	{
	}

	private void AdjustTime()
	{
	}

	public static void SetDesiredTime(int t, bool immediately = false)
	{
	}

	public static void RefreshVisual()
	{
	}

	private void PopulateDTV()
	{
	}

	public void UpdateShadowMasks()
	{
	}

	private void UpdateVarArray()
	{
	}

	public void ValuesToShader()
	{
	}

	private void OvrValueToShader(DaytimeVisual dtv)
	{
	}

	private void ValueToShader(string name)
	{
	}

	public void BakeValues()
	{
	}

	public void BakeGradients()
	{
	}

	private void ColorsToGradient(string name)
	{
	}

	private void FloatsToCurve(string name)
	{
	}

	private void CalculateDebugValues()
	{
	}

	public void UpdateShadowGrads()
	{
	}

	private int GetClosestDaytimeVisual(DaytimeVisualDirection dir)
	{
		return 0;
	}
}
