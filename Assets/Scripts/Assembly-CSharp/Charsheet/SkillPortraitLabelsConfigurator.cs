using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;

namespace Charsheet
{
	public class SkillPortraitLabelsConfigurator : MonoBehaviour
	{
		[SerializeField]
		private TranslationScriptable[] labelsSettings;

		private ISkillPortraitLabelHandler[] portraitLabels;

		private Dictionary<SkillType, int> skillToPresetIndex;

		private Dictionary<string, SkillPortraitLabelsPreset> languageToLabelsSettings;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}
	}
}
