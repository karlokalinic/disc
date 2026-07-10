using Galaxy.Api;
using UnityEngine;

[DisallowMultipleComponent]
public class GogGalaxyManager : MonoBehaviour
{
	public class AuthenticationListener : GlobalAuthListener
	{
		public override void OnAuthSuccess()
		{
		}

		public override void OnAuthFailure(FailureReason failureReason)
		{
		}

		public override void OnAuthLost()
		{
		}
	}

	private string clientID;

	private string clientSecret;

	private static GogGalaxyManager singleton;

	private static GalaxyID myGalaxyID;

	public AuthenticationListener authListener;

	private bool isInitialized;

	public static GogGalaxyManager Instance => null;

	public GOGAchievements GOGAchievements { get; private set; }

	public GalaxyID MyGalaxyID => null;

	public static bool IsUserLogged => false;

	public static bool IsInitialized()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void StartStatsAndAchievements()
	{
	}

	public void ShutdownStatsAndAchievements()
	{
	}

	public void ShutdownAllFeatureClasses()
	{
	}

	private void SignIn()
	{
	}

	public bool IsSignedIn(bool silent = false)
	{
		return false;
	}

	public bool IsLoggedOn(bool silent = false)
	{
		return false;
	}

	public string GetCurrentGameLanguage()
	{
		return null;
	}

	private void ListenersInit()
	{
	}

	private void ListenersDispose()
	{
	}
}
