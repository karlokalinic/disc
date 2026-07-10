using InControl;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rebind
{
	public class RebindActionRecord : MonoBehaviour
	{
		public UnityAction OnStartListenToBind;

		public UnityAction OnEndListenToBind;

		[SerializeField]
		private TextMeshProUGUI actionLabel;

		[SerializeField]
		private Transform bindingsContainer;

		[SerializeField]
		private Button addBind;

		private PlayerAction playerAction;

		public Transform BindingsContainer => null;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void StopListeningForBind()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetUp(PlayerAction pAction)
		{
		}

		private void CallOnEndListenToBind(PlayerAction pAction)
		{
		}

		public void OnDisableListenButtonPressed()
		{
		}

		public void StartListenForBinding()
		{
		}
	}
}
