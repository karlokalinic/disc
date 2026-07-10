using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class OptionDropbox : MonoBehaviour
{
	public static Dictionary<string, OptionDropbox> registry;

	[HideInInspector]
	public TMP_Dropdown dropdown;

	protected string settingName;

	protected int valueBeforePreview;

	private bool isRegistered;

	protected virtual SETTINGS_CATEGORY settingsCategory => default(SETTINGS_CATEGORY);

	public int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static void PreviewResetRegisteredSettings()
	{
	}

	public static void CancelPreviewRegisteredSettings()
	{
	}

	public static void ResetRegisteredSettings()
	{
	}

	public static void ReApplySettings()
	{
	}

	public virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	public virtual void OnEnable()
	{
	}

	public virtual void ReApply()
	{
	}

	protected void RegisterGraphicsOption()
	{
	}

	public abstract void OnChange();

	public virtual void ResetSettings()
	{
	}

	public virtual void PreviewReset()
	{
	}

	public virtual void CancelPreview()
	{
	}

	protected string GetBaseSettingName()
	{
		return null;
	}
}
