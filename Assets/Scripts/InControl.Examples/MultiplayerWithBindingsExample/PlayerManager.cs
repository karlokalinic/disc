using System.Collections.Generic;
using InControl;
using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	public class PlayerManager : MonoBehaviour
	{
		public GameObject playerPrefab;

		private const int maxPlayers = 4;

		private List<Vector3> playerPositions;

		private List<Player> players;

		private PlayerActions keyboardListener;

		private PlayerActions joystickListener;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private bool JoinButtonWasPressedOnListener(PlayerActions actions)
		{
			return false;
		}

		private Player FindPlayerUsingJoystick(InputDevice inputDevice)
		{
			return null;
		}

		private bool ThereIsNoPlayerUsingJoystick(InputDevice inputDevice)
		{
			return false;
		}

		private Player FindPlayerUsingKeyboard()
		{
			return null;
		}

		private bool ThereIsNoPlayerUsingKeyboard()
		{
			return false;
		}

		private void OnDeviceDetached(InputDevice inputDevice)
		{
		}

		private Player CreatePlayer(InputDevice inputDevice)
		{
			return null;
		}

		private void RemovePlayer(Player player)
		{
		}

		private void OnGUI()
		{
		}
	}
}
