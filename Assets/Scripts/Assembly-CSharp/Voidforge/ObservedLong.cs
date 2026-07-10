using System;

namespace Voidforge
{
	[Serializable]
	public class ObservedLong : ObservedValue<long>
	{
		public ObservedLong()
		{
		}

		public ObservedLong(long longValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
