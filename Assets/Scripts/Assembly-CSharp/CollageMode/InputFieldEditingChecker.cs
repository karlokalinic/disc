using TMPro;
using UnityEngine;

namespace CollageMode
{
	public class InputFieldEditingChecker : MonoBehaviour
	{
		private TMP_InputField inputField;

		public static bool IsInputFieldEdited => false;

		public static TMP_InputField CurrentlyEditedInputField { get; private set; }

		private void Awake()
		{
		}

		private void OnSelect(string text)
		{
		}

		private void OnDeselect(string text)
		{
		}
	}
}
