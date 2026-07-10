using TMPro;
using TwitchIntegration.Results;
using UnityEngine;
using UnityEngine.UI;

namespace TwitchIntegration.UI
{
	public class TwitchEnableIntegration : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup[] canvasGroups;

		[SerializeField]
		private GameObject twitchIntegrationToggleOptions;

		[SerializeField]
		private GameObject moreTwitchIntegrationOptions;

		[SerializeField]
		private TextMeshProUGUI connectionResult;

		[SerializeField]
		private Toggle intergationEnabledToggle;

		[SerializeField]
		private TMP_InputField secretKeyField;

		[SerializeField]
		private Toggle connectToggle;

		protected void Reset()
		{
		}

		protected void Awake()
		{
		}

		protected void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void DisableConnectToggle()
		{
		}

		private void OnConnectToggleValueChanged(bool startConnection)
		{
		}

		private void OnIntegrationEnabledToggleValueChanged(bool showMoreTwitchOptions)
		{
		}

		public void RegisterSecretKeyWithTwitch()
		{
		}

		private string GetLocalizedTerm(string term)
		{
			return null;
		}

		private void OnStatusRequestRecieved(StatusRequestResult obj)
		{
		}

		private void IfDebugIsActiveAddTargetedServer()
		{
		}

		private static string GetTwitchStatus()
		{
			return null;
		}

		public void DisableTwitchIntegration()
		{
		}

		private void SetInteractable(bool state)
		{
		}

		private void Clear()
		{
		}

		public void SetDebugKeyAsSecret()
		{
		}
	}
}
