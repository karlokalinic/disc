using UnityEngine;

public class PS5ActivityManager : LiteSingleton<PS5ActivityManager>
{
	[SerializeField]
	private bool _isActivity;

	public bool IsActivity
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool WasActivityStarted { get; private set; }

	public void NewGameNoIntroActivity()
	{
	}

	private static bool CanStartNewGameActivity()
	{
		return false;
	}

	private void OnAreaChanged()
	{
	}
}
