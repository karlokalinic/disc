using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class LocalizeFontBestFit : MonoBehaviour
	{
		[SerializeField]
		private TranslationFontBestFit[] translationList;

		private Dictionary<string, TranslationFontBestFit> fontSizeDict;

		private Text text;

		private TextMeshProUGUI textMeshProText;

		private static string DefaultLanguageCode => null;

		public bool IsInitialized { get; private set; }

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateTextSize()
		{
		}

		public Vector2 GetLocalizedFontSizes()
		{
			return default(Vector2);
		}
	}
}
