using System;

namespace Sunshine.Dialogue
{
	public static class KarmaLuaFunctions
	{
		public static Action<string> OnLuaKarmaChanged;

		public static void Register()
		{
		}

		private static void ModifyRep(string variable, int value)
		{
		}

		public static void ModifyOnce(string variable, double value)
		{
		}

		public static void Reputation(string variable, double value)
		{
		}

		public static void ReputationGrows(string variable)
		{
		}

		public static void ReputationLowers(string variable)
		{
		}

		public static bool IsHighestCopotype(string copotype)
		{
			return false;
		}

		public static bool IsHighestPolitical(string political)
		{
			return false;
		}

		public static void DEBUG_CallKarmaEvent(string variable)
		{
		}
	}
}
