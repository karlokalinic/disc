using DiscoPages.Elements;
using Pages.Common.Charsheet;
using PagesSystem;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillPortraitOverviewPanel : MonoBehaviour
{
	private const float PREVIEW_TO_OVERVIEW_PORTRAIT_CONVERSION_RATE = 2.6f;

	[SerializeField]
	private Image portrait;

	[SerializeField]
	private Image bonusTextMinusImage;

	[SerializeField]
	private TextMeshProUGUI bonusText;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private SkillOverviewPageLabelConfigurator labelConfigurator;

	[SerializeField]
	private SegmentIndicator portraitSkillPipIndicator;

	[SerializeField]
	private SkillPortraitAnimatorHelperPageSystem skillPortraitAnimatorHelper;

	private string shortDescriptionTextStr;

	private string longDescriptionTextStr;

	private string titleTextStr;

	private SkillPortraitPanelPageSystem portraitPanel;

	private Skill skill;

	public Skill Skill => null;

	public string ShortDescriptionTextStr => null;

	public string LongDescriptionTextStr => null;

	public string TitleTextStr => null;

	public void ShowModifiable(Modifiable modifiable, SkillPortraitPanelPageSystem portraitPanel, bool updateBonusText)
	{
	}

	public void ShowSkill(Skill skill, SkillPortraitPanelPageSystem portraitPanel)
	{
	}
}
