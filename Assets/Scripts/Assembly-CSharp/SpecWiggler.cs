using System.Collections.Generic;
using UnityEngine;

public class SpecWiggler : MonoBehaviour
{
	private int _matId;

	private Material _mat;

	private const int MaxGlobalArraySize = 50;

	private static List<SpecWiggler> register;

	private static float[] globalSpecShiftArray;

	private static int lastFrame;

	private static int propId_FOAdditive_SpecShiftArray;

	private static int propId_MatId;

	private static int propId_SpecShift;

	public static bool portraitWiggles;

	private static float portraitWiggleStartTime;

	private static bool setFloatCalled;

	private Material Mat => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private static void SetGlobalConstants()
	{
	}

	private void Update()
	{
	}

	public static void Wiggle()
	{
	}

	public static void SetSpecShift(float v)
	{
	}

	private void OnDestroy()
	{
	}
}
