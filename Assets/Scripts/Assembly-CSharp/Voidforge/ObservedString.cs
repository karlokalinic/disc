using System;

namespace Voidforge
{
	[Serializable]
	public class ObservedString : ObservedValue<string>
	{
		public ObservedString()
		{
		}

		public ObservedString(string stringValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
