using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	public class SequencerCommandTextInput : SequencerCommand
	{
		private ITextFieldUI textFieldUI;

		private string variableName;

		private bool acceptedText;

		public void Start()
		{
		}

		private Transform FindTextFieldUIObject()
		{
			return null;
		}

		private Transform FindChildRecursive(Transform t, string childName)
		{
			return null;
		}

		public void OnAcceptedText(string text)
		{
		}

		public void OnDestroy()
		{
		}
	}
}
