using System;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageModeContentPolicyPopup : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect scrollRect;

		[SerializeField]
		private Button submitButton;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private float gamepadScrollSpeed;

		private Action submitAction;

		private Action cancelAction;

		public bool IsOpen => false;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnSubmitButtonClicked()
		{
		}

		private void OnCancelButtonClicked()
		{
		}

		public void Show(Action submitAction = null, Action cancelAction = null)
		{
		}

		public void Hide()
		{
		}
	}
}
