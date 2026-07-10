using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.Debug
{
	public class TwitchDebugRegisterSecretKey : TwitchDebug
	{
		[SerializeField]
		private InputField secretKeyField;

		[SerializeField]
		private Graphic showServerType;

		[SerializeField]
		private Text serverTypeLabel;

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void RrefreshTargetServerState()
		{
		}

		private void OnStatusRequestRecieved(StatusRequestResult obj)
		{
		}

		private static string GetTwitchStatus()
		{
			return null;
		}

		public void RegisterSecretKey()
		{
		}

		public void DisableTwitchIntegration()
		{
		}

		public void Clear()
		{
		}

		public void SetDebugKeyAsSecret()
		{
		}

		public void ToggleTargetServerChange()
		{
		}
	}
}
