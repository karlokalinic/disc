using DiscoPages.Elements;
using Pages.Common.Charsheet;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Pages.MainMenu.Charsheet
{
	public class SkillOverviewMainMenuPage : SkillOverviewPage
	{
		[SerializeField]
		private TextMeshProUGUI infoText;

		[SerializeField]
		private Button signatureSkillButton;

		[SerializeField]
		[Space]
		private Button setSignatureButton;

		[SerializeField]
		private Image signatureSkillIcon;

		public override void ShowModifiable(Modifiable modifiable, SkillPortraitPanelPageSystem portraitPanel, bool showBonusText = false)
		{
		}

		public override void Initialize()
		{
		}

		private void SetSignature()
		{
		}

		private void OnConfirm()
		{
		}
	}
}
