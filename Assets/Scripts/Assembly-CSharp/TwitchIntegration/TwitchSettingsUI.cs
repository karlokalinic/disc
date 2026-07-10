using System;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration
{
	public class TwitchSettingsUI : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private InputField secretKeyField;

		[SerializeField]
		private Text connectionStatus;

		[SerializeField]
		private Button connectToTwitch;

		[SerializeField]
		private Button disconnectFromTwitch;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private void OnConnectToTwitchPressed()
		{
		}

		private void OnStatusRequestRecieved(StatusRequestResult obj)
		{
		}

		private static string GetTwitchStatus()
		{
			return null;
		}

		public void CheckEndPointStatus(Action<StatusRequestResult> onRequestResult)
		{
		}

		public void DisableTwitchIntegration()
		{
		}

		public void Clear()
		{
		}
	}
}
