using UnityEngine;

namespace Charsheet
{
	[CreateAssetMenu]
	public class SkillPortraitLabelsPreset : ScriptableObject
	{
		public SkillPortraitLabelSettings[] labelsSettings;

		private void MassChangeLineSpacingToDefault()
		{
		}

		private void MassChangeLineSpacingToArabic()
		{
		}

		private void MassChangeLineSpacing(float value)
		{
		}

		public void Apply(SkillPortrayLabel skillLabel, SkillPortraitLabelSettings settings)
		{
		}
	}
}
