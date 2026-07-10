using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LocalizationCustomSystem
{
	public class LocalizeLineSpacing : MonoBehaviour
	{
		[SerializeField]
		private TranslationLineSpacing[] translationList;

		private Dictionary<string, int> lineSpacingDict;

		private Text text;

		private TextMeshProUGUI textMeshProText;

		private bool isInitialized;

		private static string DefaultLanguageCode => null;

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

		public void UpdateLineSpacing()
		{
		}
	}
}
