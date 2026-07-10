using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class UnityTextFieldUI : MonoBehaviour, ITextFieldUI
	{
		public GUIControl panel;

		public GUILabel label;

		public GUITextField textField;

		public KeyCode acceptKey;

		public KeyCode cancelKey;

		private AcceptedTextDelegate acceptedText;

		private GUIControl control;

		private bool ignoreFirstAccept;

		private bool ignoreFirstCancel;

		public void Awake()
		{
		}

		public void StartTextInput(string labelText, string text, int maxLength, AcceptedTextDelegate acceptedText)
		{
		}

		private void OnGUI()
		{
		}

		private bool IsAcceptKey()
		{
			return false;
		}

		private bool IsKeyCodeReturn(KeyCode keyCode)
		{
			return false;
		}

		public void CancelTextInput()
		{
		}

		private void AcceptTextInput()
		{
		}

		public void OnAccept(object data)
		{
		}

		public void OnCancel(object data)
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void SetControlsActive(bool value)
		{
		}
	}
}
