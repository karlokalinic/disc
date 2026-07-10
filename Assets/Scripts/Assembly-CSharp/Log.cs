using System.Collections.Generic;
using UnityEngine;

public static class Log
{
	public enum COMPONENT
	{
		CHARACTER_SHEET = 0,
		DIALOGUE = 1,
		PERSISTENCE = 2,
		PERSISTENCE_ERROR = 3,
		SCHEDULER = 4,
		VIEW_SYSTEM = 5,
		WEATHER_SYSTEM = 6,
		WHITE_CHECKS = 7,
		CAMERA_SYSTEM = 8,
		MOVEMENT = 9,
		SDK_GOG = 10,
		EXISTENTIAL_CHRISIS = 11,
		NOTIFICATION = 12,
		ORB_SYSTEM = 13,
		JOURNAL = 14,
		VOICE_OVER = 15,
		CONTROLLER = 16,
		TWITCH_INTEGRATION = 17,
		ACHIEVEMENTS = 18
	}

	private static Dictionary<COMPONENT, bool> componentState;

	public const string KEYWORD1 = "ENABLE_LOGGING";

	public const string KEYWORD2 = "UNITY_EDITOR";

	public static void Info(COMPONENT component, string message)
	{
	}

	public static void Info(COMPONENT component, string message, Object context)
	{
	}

	public static void InfoFormat(COMPONENT component, string message, params object[] args)
	{
	}

	public static void Warning(COMPONENT component, string message)
	{
	}

	public static void Error(COMPONENT component, string message)
	{
	}

	public static void Error(COMPONENT component, string message, Object context)
	{
	}

	public static bool ToggleComponent(COMPONENT component)
	{
		return false;
	}

	public static bool IsComponentActive(COMPONENT component)
	{
		return false;
	}

	private static Dictionary<COMPONENT, bool> InitDictionary()
	{
		return null;
	}
}
