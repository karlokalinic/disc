using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedQuaternion : ObservedValue<Quaternion>
	{
		public ObservedQuaternion()
		{
		}

		public ObservedQuaternion(Quaternion quaternionValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
