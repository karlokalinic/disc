using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedColor : ObservedValue<Color>
	{
		public ObservedColor()
		{
		}

		public ObservedColor(Color colorValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
