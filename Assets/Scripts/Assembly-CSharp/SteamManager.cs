using System.Text;
using UnityEngine;

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	private static SteamManager s_instance;

	private static bool s_EverInialized;

	private bool m_bInitialized;

	private object m_SteamAPIWarningMessageHook;

	private static SteamManager Instance => null;

	public static bool Initialized => false;

	private static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static string GetLocalPlayerName()
	{
		return null;
	}

	public static string GetLocalSteamID()
	{
		return null;
	}

	public static string GetSteamAvailableLanguages()
	{
		return null;
	}

	public static void GetDebugInformationAboutCurrentlyConnectedGamepads()
	{
	}

	public static bool IsSteamRunningOnSteamDeck()
	{
		return false;
	}
}
