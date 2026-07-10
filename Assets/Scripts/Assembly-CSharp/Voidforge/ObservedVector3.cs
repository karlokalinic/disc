using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedVector3 : ObservedValue<Vector3>
	{
		public ObservedVector3()
		{
		}

		public ObservedVector3(Vector3 vector3Value, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
