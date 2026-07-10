namespace Sunshine.Metric
{
	public class CheckModifier : CheckBonus
	{
		public string expression;

		public CheckModifier(int bonus, string explanation, string expression)
			: base(0, null)
		{
		}
	}
}
