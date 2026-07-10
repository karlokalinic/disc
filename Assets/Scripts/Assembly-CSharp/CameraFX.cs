using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFX : MonoBehaviour
{
	public FXPreset[] effects;

	public static Dictionary<string, FXPreset> fxs;

	public static List<CameraFX> allComps;

	public string[] debugName;

	public bool debugActive;

	public bool debugTrigger;

	private static bool cleanupAdded;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateDict()
	{
	}

	public static void Toggle(string name, bool on = true)
	{
	}

	public static IEnumerator AnimateCameraFX(FXPreset fxp)
	{
		return null;
	}

	public static void ResetAll()
	{
	}

	private void OnDestroy()
	{
	}
}
