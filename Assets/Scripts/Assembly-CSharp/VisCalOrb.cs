using Sunshine.Metric;

public class VisCalOrb : SenseOrb
{
	public override string DifficultyFieldName => null;

	public override bool IsOrbital => false;

	public override bool IsViscal => false;

	public override SkillType Skill => default(SkillType);
}
