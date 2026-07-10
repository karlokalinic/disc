using Sunshine.Metric;

namespace Charsheet
{
	public interface ISkillPortraitLabelHandler
	{
		SkillType SkillType { get; }

		SkillPortrayLabel SkillPortraitLabel { get; }
	}
}
