using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizeLetterSpacing : MonoBehaviour
	{
		[SerializeField]
		private TranslationLetterSpacing[] translationList;

		private Dictionary<string, float> letterSpacingDict;

		private TextMeshProUGUI text;

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

		private void UpdateLetterSpacing()
		{
		}
	}
}
