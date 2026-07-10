using System;
using UnityEngine;

[Serializable]
public class SettingsValue
{
	private enum SETTINGS_VALUE_TYPE
	{
		NONE = 0,
		INT = 1,
		FLOAT = 2,
		STRING = 3,
		BOOL = 4
	}

	[SerializeField]
	private int intValue;

	[SerializeField]
	private string stringValue;

	[SerializeField]
	private float floatValue;

	[SerializeField]
	private bool boolValue;

	[SerializeField]
	private SETTINGS_VALUE_TYPE type;

	public SettingsValue(int intValue)
	{
	}

	public SettingsValue(float floatValue)
	{
	}

	public SettingsValue(string stringValue)
	{
	}

	public SettingsValue(bool boolValue)
	{
	}

	public void SetInt(int intValue)
	{
	}

	public void SetFloat(float floatValue)
	{
	}

	public void SetString(string stringValue)
	{
	}

	public void SetBool(bool boolValue)
	{
	}

	public string GetString(string defaultValue)
	{
		return null;
	}

	public int GetInt(int defaultValue)
	{
		return 0;
	}

	public float GetFloat(float defaultValue)
	{
		return 0f;
	}

	public bool GetBool(bool defaultValue)
	{
		return false;
	}
}
