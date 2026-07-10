using Sunshine.Metric;
using UnityEngine;

public class ArchetypeAbility : MonoBehaviour, IGenericTooltipDataProvider
{
	public NumericFlipClock FlipClockNumber;

	private AbilityType ability;

	private SunshineCharacterTemplate archetype;

	public void SetData(AbilityType ability, SunshineCharacterTemplate archetype)
	{
	}

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}

	private string GetDescription(string abilityActorName)
	{
		return null;
	}

	private string GetSkillValues()
	{
		return null;
	}

	private string GetArchetypeSkillValueLine(SkillType skillType, int value)
	{
		return null;
	}

	private int CalculateSignatureBonus(SkillType skillType)
	{
		return 0;
	}
}
