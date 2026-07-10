using System.Collections.Generic;
using I2.Loc;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizeSuffix : MonoBehaviour
	{
		[SerializeField]
		private TranslationSuffix[] translationList;

		private Dictionary<string, string> suffixDict;

		private Localize i2Localize;

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

		private void UpdateSuffix()
		{
		}
	}
}
