using System.Collections;
using System.Collections.Generic;
using System.Text;
using Sunshine;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckAdvisor : Tooltip<CheckAdvisor>
{
	[SerializeField]
	private Color defaultSkillColor;

	[SerializeField]
	private Color whiteCheckGlowColor;

	[SerializeField]
	private Color redCheckGlowColor;

	[SerializeField]
	private GameObject whiteCheckOpenTutorialMessage;

	[SerializeField]
	private GameObject whiteCheckClosedTutorialMessage;

	[SerializeField]
	private GameObject redCheckTutorialMessage;

	[SerializeField]
	private TextMeshProUGUI whiteCheckOpenTutorialTextContent;

	[SerializeField]
	private TextMeshProUGUI whiteCheckClosedTutorialTextContent;

	[SerializeField]
	private TextMeshProUGUI redCheckTutoriaTextContent;

	[SerializeField]
	private float hiddenYPos;

	[SerializeField]
	private float shownYPos;

	[SerializeField]
	private float slideAnimDuration;

	[SerializeField]
	private float hideDelay;

	[SerializeField]
	private Image checkTypeGlowImage;

	[SerializeField]
	private Image sumsRibbon;

	[SerializeField]
	private Image splatImage;

	[SerializeField]
	private TextMeshProUGUI probabilityText;

	[SerializeField]
	private TextMeshProUGUI probabilityPercentage;

	[SerializeField]
	private TextMeshProUGUI skillTypeLabel;

	[SerializeField]
	private TooltipLine modifierTooltipLinePrefab;

	[SerializeField]
	private Transform parentForTooltip;

	private List<TooltipLine> spawnedTooltipLines;

	private IEnumerator currentCoroutine;

	private CheckResult currentCheck;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	private void OnLanguageChanged()
	{
	}

	public override void SetTooltipContent(TooltipSource tooltipSource)
	{
	}

	public void SetAdvisorContent(CheckResult data)
	{
	}

	private void DisableUnusedTooltipLines(int id)
	{
	}

	private void SetTutorialForCurrentCheckType(CheckResult data)
	{
	}

	private void StartSlideCoroutine(bool slideIn)
	{
	}

	private IEnumerator SlideCoroutine(bool slideIn)
	{
		return null;
	}

	private string HumanizeProbability(float probability)
	{
		return null;
	}

	private string BonusText(CheckResult data)
	{
		return null;
	}

	private string PassiveBonusText(CheckResult data)
	{
		return null;
	}

	private void AbilityAndSkillValuesText(CheckResult data, StringBuilder sb)
	{
	}

	private Color GetModifierBonusColorHex(bool isPositive)
	{
		return default(Color);
	}

	private int ModifierText(int id, CheckResult data)
	{
		return 0;
	}

	private int AddTooltipDescriptionLine(int id, string value, string description)
	{
		return 0;
	}

	private string Explain(CheckResult data)
	{
		return null;
	}
}
