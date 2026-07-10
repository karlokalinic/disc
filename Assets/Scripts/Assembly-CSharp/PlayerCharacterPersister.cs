using System.Collections.Generic;
using Sunshine.Metric;

public static class PlayerCharacterPersister
{
	public class PlayerCharacterState
	{
		public int XpAmount;

		public int Level;

		public int SkillPoints;

		public int Money;

		public int StockValue;

		public bool NewPointsToSpend;

		public Dictionary<SkillType, int> healingPools;
	}

	public static PlayerCharacterState Serialize()
	{
		return null;
	}

	public static void Deserialize(PlayerCharacterState state)
	{
	}
}
