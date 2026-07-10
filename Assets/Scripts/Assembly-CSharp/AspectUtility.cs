using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectUtility : MonoBehaviour
{
	public enum AspectRatio
	{
		Ratio_16x9 = 0,
		Ratio_21x9 = 1,
		Ratio_16x10 = 2,
		Ratio_4x3 = 3,
		Ratio_9x16 = 4
	}

	public const float RATIO_16X9 = 1.777778f;

	public const float RATIO_21X9 = 2.3888888f;

	public const float RATIO_16X10 = 1.6f;

	public const float RATIO_4X3 = 1.3333334f;

	public const float RATIO_9X16 = 0.5625f;

	private static AspectRatio currentRatio;

	public static float wantedAspectRatio;

	public Camera cam;

	private static List<AspectUtility> camerasAspectUtilities;

	public static AspectUtility singleton;

	private static Camera backgroundCam;

	public static AspectRatio CurrentRatio => default(AspectRatio);

	public int screenHeight => 0;

	public int screenWidth => 0;

	public int xOffset => 0;

	public int yOffset => 0;

	public Rect screenRect => default(Rect);

	public Vector3 mousePosition => default(Vector3);

	public Vector2 guiMousePosition => default(Vector2);

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static void UpdateAspectRatio(Aspect aspect, Bars bars)
	{
	}

	private static void SetAllCameras(AspectRatio aspectRatio)
	{
	}

	private void SetCamera()
	{
	}

	private static IEnumerator BlickWithBackgroundCamera()
	{
		return null;
	}

	private static void SetBackgroundCam()
	{
	}
}
