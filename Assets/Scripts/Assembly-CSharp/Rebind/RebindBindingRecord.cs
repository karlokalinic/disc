using System.Collections;
using InControl;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Rebind
{
	public class RebindBindingRecord : MonoBehaviour
	{
		public UnityAction OnBindRemoved;

		[SerializeField]
		private TextMeshProUGUI bindingName;

		[SerializeField]
		private TextMeshProUGUI deviceClass;

		[SerializeField]
		private TextMeshProUGUI bindingSourceType;

		[SerializeField]
		private Button removeBind;

		private PlayerAction playerAction;

		private BindingSource bindingSource;

		private void Awake()
		{
		}

		private void RemoveBindFromPlayer()
		{
		}

		private IEnumerator WaitForFrameAndUpdate()
		{
			return null;
		}

		public void SetUp(PlayerAction pAction, BindingSource bSource)
		{
		}
	}
}
