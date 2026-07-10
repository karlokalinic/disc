using Sunshine.Metric;
using Sunshine.Views;
using TMPro;
using UnityEngine;

public class SkillModifierTemplate : MonoBehaviour, ISkillDisplayElement
{
	private const float padding = 0f;

	[SerializeField]
	private TextMeshProUGUI skillNameText;

	[SerializeField]
	private ColorHighlighter nameHighlighter;

	[SerializeField]
	private TextMeshProUGUI skillValueText;

	[SerializeField]
	private ColorHighlighter valueHighlighter;

	[SerializeField]
	private Color positiveHighlightColor;

	[SerializeField]
	private Color negativeHighlightColor;

	[SerializeField]
	private Color nameHighlightColor;

	private float lastBonusValue;

	public Skill Skill { get; private set; }

	private SkillType _skillType { get; set; }

	public bool IsVisible { get; private set; }

	public void UpdateSkill(ViewType currentView)
	{
	}

	public void UpdateSkill(SkillType skillType, ViewType currentView)
	{
	}

	public void Refresh(ViewType currentView)
	{
	}

	private string GetBonusDisplayString(int bonusValue)
	{
		return null;
	}

	private void UpdateHighlight(int bonusValue)
	{
	}

	private void ToggleVisibility(bool isVisible)
	{
	}

	private void SetNumberOfDots()
	{
	}

	public SkillType GetSkillType()
	{
		return default(SkillType);
	}
}
