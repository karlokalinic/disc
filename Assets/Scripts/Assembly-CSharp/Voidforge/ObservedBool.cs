using System;

namespace Voidforge
{
	[Serializable]
	public class ObservedBool : ObservedValue<bool>
	{
		public ObservedBool()
		{
		}

		public ObservedBool(bool boolValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
