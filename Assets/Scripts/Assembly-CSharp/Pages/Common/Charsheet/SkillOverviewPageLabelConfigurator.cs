using System.Collections.Generic;
using Charsheet;
using Sunshine.Metric;
using UnityEngine;

namespace Pages.Common.Charsheet
{
	public class SkillOverviewPageLabelConfigurator : MonoBehaviour
	{
		[SerializeField]
		private TranslationScriptable[] labelsSettings;

		private Dictionary<SkillType, int> skillToPresetIndex;

		private Dictionary<string, SkillPortraitLabelsPreset> languageToLabelsSettings;

		private void Awake()
		{
		}

		public SkillPortraitLabelSettings GetLabelSettings(SkillType type)
		{
			return default(SkillPortraitLabelSettings);
		}
	}
}
