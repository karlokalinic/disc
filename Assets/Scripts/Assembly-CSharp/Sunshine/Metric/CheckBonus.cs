using LocalizationCustomSystem;

namespace Sunshine.Metric
{
	public class CheckBonus
	{
		public int bonus;

		public string fallbackExplanation;

		public TranslationString localizedExplanation;

		public string explanation => null;

		public bool IsPenalty => false;

		public CheckBonus(int bonus, string fallbackExplanation)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
