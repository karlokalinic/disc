using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ResolutionSwitcher : LiteSingleton<ResolutionSwitcher>
{
	private static List<ResolutionSetting> _compatibleResolutions;

	private TMP_Dropdown _dd;

	private int previousSettingIndex;

	private int currentIndex;

	private Resolution fallback;

	private ResolutionSetting currentResolution;

	private int valueBeforePreview;

	private bool isInitialized;

	public static ResolutionSetting CurrentResolution => default(ResolutionSetting);

	public static List<ResolutionSetting> CompatibleResolutions => null;

	private TMP_Dropdown DD
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static event Action<ResolutionSetting> OnResolutionChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	public void Activate()
	{
	}

	public void ResetSettings()
	{
	}

	public void PreviewReset()
	{
	}

	public void CancelPreview()
	{
	}

	public void Revert()
	{
	}

	public void ApplyRes()
	{
	}

	private static List<ResolutionSetting> GetCompatibleResolutions()
	{
		return null;
	}

	public static void FireResChangeEvent(ResolutionSetting currentResolution)
	{
	}

	public void SetResolution(int w, int h, FullScreenMode fullScreenMode)
	{
	}

	private IEnumerator RefreshCamerasAndUiNextFrame()
	{
		return null;
	}

	private void Update()
	{
	}

	public static void Apply(string name)
	{
	}
}
