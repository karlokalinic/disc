using System.Collections.Generic;
using InControl;
using UnityEngine;

namespace MultiplayerBasicExample
{
	public class PlayerManager : MonoBehaviour
	{
		public GameObject playerPrefab;

		private const int maxPlayers = 4;

		private List<Vector3> playerPositions;

		private List<Player> players;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool JoinButtonWasPressedOnDevice(InputDevice inputDevice)
		{
			return false;
		}

		private Player FindPlayerUsingDevice(InputDevice inputDevice)
		{
			return null;
		}

		private bool ThereIsNoPlayerUsingDevice(InputDevice inputDevice)
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
