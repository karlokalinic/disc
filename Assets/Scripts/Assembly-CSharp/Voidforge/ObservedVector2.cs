using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedVector2 : ObservedValue<Vector2>
	{
		public ObservedVector2()
		{
		}

		public ObservedVector2(Vector2 vector2Value, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
