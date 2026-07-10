using UnityEngine;

[DisallowMultipleComponent]
public class XBGDKApiControl : MonoBehaviour
{
	private enum AppState
	{
		NewUser = 0,
		ChangeUser = 1,
		ShowPrompt = 2,
		SearchForInput = 3,
		InGame = 4,
		Resume = 5,
		UserUI = 6,
		WaitForNextTask = 7,
		Unknown = 8
	}

	public static XBGDKApiControl m_xbgdkapicontrol;

	private AppState currAppState;

	private AppState prevAppState;
}
