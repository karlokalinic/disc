using Sunshine.Metric;
using UnityEngine;

public class BasicSkillDisplayElement : MonoBehaviour, ISkillDisplayElement
{
	public SkillType skillType;

	public SkillType GetSkillType()
	{
		return default(SkillType);
	}
}
