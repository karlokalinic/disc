using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;

public class SkillPanel : MonoBehaviour, ISkillDisplayElement
{
	public Text skillName;

	public Text skillNumber;

	public Text skillPips;

	public Text pointsToNextRank;

	public SkillType skill;

	public void UpdateData()
	{
	}

	public SkillType GetSkillType()
	{
		return default(SkillType);
	}
}
