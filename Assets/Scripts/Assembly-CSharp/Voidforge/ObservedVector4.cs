using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedVector4 : ObservedValue<Vector4>
	{
		public ObservedVector4()
		{
		}

		public ObservedVector4(Vector4 vector4Value, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
