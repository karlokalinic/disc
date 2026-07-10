using UnityEngine;

namespace Sunshine.Views
{
	public class LobbyManager : MonoBehaviour
	{
		public static LobbyManager INSTANCE;

		public Newspaper newspaper;

		public RectTransform[] debuggingFeatures;

		public static bool lobbyActive;

		private static Canvas canvas;

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public static void DisableCanvas()
		{
		}

		public static void EnableCanvas()
		{
		}

		public void DevOverrideLobby()
		{
		}
	}
}
