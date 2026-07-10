using System;
using System.Collections;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class LocalizedTextFormatter : MonoBehaviour
	{
		public Action OnTextFormatted;

		[SerializeField]
		private bool useCharacterWrappingInKorean;

		private Text _textField;

		private RectTransform _rectTransform;

		private Localize localize;

		private IEnumerator delayedFormatCoR;

		private LocalizeFontSize localizeFontSize;

		private string currentText;

		public Text textField => null;

		public RectTransform rectTransform => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void DelayedFormatText()
		{
		}

		public void UpdateAndFormatText()
		{
		}

		public void SetAndFormatText(string text, bool updateImmediate = false)
		{
		}

		private IEnumerator DelayedUpdateTextAndFormat()
		{
			return null;
		}

		private IEnumerator DelayedSetTextAndFormat(string text)
		{
			return null;
		}

		private void UpdateFont()
		{
		}

		private void UpdateFontSize()
		{
		}
	}
}
