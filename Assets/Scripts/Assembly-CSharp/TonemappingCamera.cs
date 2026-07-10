using System;
using System.Collections;
using UnityEngine;

public class TonemappingCamera : MonoBehaviour
{
	public static Action<float> OnWhiteNitsChanged;

	public static bool HDROn;

	private static Camera HDRCamera;

	private static CMDHDRTonemap HDRCmdBuffer;

	public static float m_StartPaperWhiteNits;

	private static float m_PaperWhiteNits;

	private static ColorGamut m_ColorGamut;

	public static float PaperWhiteNits
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static ColorGamut ColorGamut
	{
		get
		{
			return default(ColorGamut);
		}
		private set
		{
		}
	}

	private static bool PlatformSupports()
	{
		return false;
	}

	public static bool ISHDRSupported()
	{
		return false;
	}

	public static bool ISHDRActive()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSettingsInitialized()
	{
	}

	private void InitHDR()
	{
	}

	public void ToggleHDR()
	{
	}

	public void SwitchHDR(bool flag, bool coroutine = true)
	{
	}

	private IEnumerator SwitchHDRModeCoR()
	{
		return null;
	}

	private bool SwitchHDRMode()
	{
		return false;
	}

	private void RequestHDRChange(bool flag)
	{
	}

	public static void HandleHDROptionsVisibility()
	{
	}

	private static void ToggleHDRCheckboxOption(bool flag)
	{
	}

	private static void ToggleBrightnessOption(bool flag)
	{
	}
}
