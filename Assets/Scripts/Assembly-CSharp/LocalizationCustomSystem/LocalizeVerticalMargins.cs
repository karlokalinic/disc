using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizeVerticalMargins : MonoBehaviour
	{
		[SerializeField]
		private TranslationMargins[] translationList;

		private Dictionary<string, Vector2> fontSizeDict;

		private TextMeshProUGUI textMeshProText;

		private bool isInitialized;

		private static string DefaultLanguageCode => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void Initialize()
		{
		}

		public void UpdateTextSize()
		{
		}
	}
}
