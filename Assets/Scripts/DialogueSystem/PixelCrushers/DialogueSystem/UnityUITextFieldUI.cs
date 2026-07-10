using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUITextFieldUI : MonoBehaviour, ITextFieldUI
	{
		public Graphic panel;

		public Text label;

		public InputField textField;

		public KeyCode acceptKey;

		public KeyCode cancelKey;

		public bool showTouchScreenKeyboard;

		public UnityEvent onAccept;

		public UnityEvent onCancel;

		private AcceptedTextDelegate acceptedText;

		private bool isAwaitingInput;

		private TouchScreenKeyboard touchScreenKeyboard;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void StartTextInput(string labelText, string text, int maxLength, AcceptedTextDelegate acceptedText)
		{
		}

		public void Update()
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
