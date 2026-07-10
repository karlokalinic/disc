using System;

namespace Voidforge
{
	[Serializable]
	public class ObservedFloat : ObservedValue<float>
	{
		public ObservedFloat()
		{
		}

		public ObservedFloat(float floatValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
