using System;

namespace Sunshine
{
	[Serializable]
	public class ContainerItem
	{
		public string name;

		public int probability;

		public int value;

		public int deviation;

		public int calculatedValue;

		public bool bonusLoot;

		public int GameModeDependentCalculatedValue => 0;
	}
}
