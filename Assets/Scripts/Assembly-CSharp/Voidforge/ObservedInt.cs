using System;

namespace Voidforge
{
	[Serializable]
	public class ObservedInt : ObservedValue<int>
	{
		public ObservedInt()
		{
		}

		public ObservedInt(int intValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
