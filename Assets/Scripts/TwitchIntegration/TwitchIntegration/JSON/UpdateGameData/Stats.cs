using System;

namespace TwitchIntegration.JSON.UpdateGameData
{
	[Serializable]
	public class Stats
	{
		public int intellect;

		public int psyche;

		public int physique;

		public int motorics;

		public Stats()
		{
		}

		public Stats(int intellect, int psyche, int fysique, int motorics)
		{
		}

		internal static Stats GetExample()
		{
			return null;
		}

		public bool Equals(Stats obj)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
