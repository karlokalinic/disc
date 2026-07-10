using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AspectRatioFitterUtility : MonoBehaviour
{
	private AspectRatioFitter fitter;

	private CanvasScaler scaler;

	private static List<AspectRatioFitterUtility> registry;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnOverscanChanged(float per, float size)
	{
	}

	public static void SetFitter(float ratio, Bars bars)
	{
	}

	public static void SetScaler(Vector2 refRes, float matchWH)
	{
	}
}
