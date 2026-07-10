using System;

namespace Voidforge
{
	[Serializable]
	public class ObservedDouble : ObservedValue<double>
	{
		public ObservedDouble()
		{
		}

		public ObservedDouble(double doubleValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
