using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedBounds : ObservedValue<Bounds>
	{
		public ObservedBounds()
		{
		}

		public ObservedBounds(Bounds boundsValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
