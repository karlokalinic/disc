using System;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageModePopup : MonoBehaviour
	{
		[SerializeField]
		private Localize text;

		[SerializeField]
		private Button submitButton;

		[SerializeField]
		private Localize submitText;

		[SerializeField]
		private Button cancelButton;

		[SerializeField]
		private Localize cancelText;

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

		public void Show(string popupTerm, Action submitAction = null, Action cancelAction = null, string submitTerm = "BUTTON/ACCEPT", string cancelTerm = "SHARE/CANCEL")
		{
		}

		public void Hide()
		{
		}
	}
}
