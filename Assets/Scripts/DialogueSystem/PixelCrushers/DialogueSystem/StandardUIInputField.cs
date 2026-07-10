using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIInputField : UIPanel, ITextFieldUI
	{
		public Graphic panel;

		public UITextField label;

		public UIInputField inputField;

		public KeyCode acceptKey;

		public KeyCode cancelKey;

		public bool showTouchScreenKeyboard;

		public UnityEvent onAccept;

		public UnityEvent onCancel;

		private AcceptedTextDelegate m_acceptedText;

		private bool m_isAwaitingInput;

		private TouchScreenKeyboard m_touchScreenKeyboard;

		protected override void Start()
		{
		}

		public void StartTextInput(string labelText, string text, int maxLength, AcceptedTextDelegate acceptedText)
		{
		}

		protected override void Update()
		{
		}

		public void CancelTextInput()
		{
		}

		public void AcceptTextInput()
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void SetActive(bool value)
		{
		}
	}
}
