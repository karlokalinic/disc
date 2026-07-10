using DiscoPages.Elements;
using Pages.Common.Charsheet;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.Gameplay.Charsheet
{
	public class SkillOverviewGameplayPage : SkillOverviewPage
	{
		[SerializeField]
		private TextMeshProUGUI extraText;

		[SerializeField]
		private Button levelUpButton;

		[SerializeField]
		private SkillLevelUpButton skillLevelUpButton;

		[SerializeField]
		private XPPanel xpPanel;

		public override void Initialize()
		{
		}

		public override void ShowModifiable(Modifiable modifiable, SkillPortraitPanelPageSystem portraitPanel, bool showBonusText = false)
		{
		}

		public override void UpdateData()
		{
		}

		protected override void ShowSkill(Skill skill, SkillPortraitPanelPageSystem portraitPanel)
		{
		}
	}
}
