using System;
using UnityEngine;

namespace Voidforge
{
	[Serializable]
	public class ObservedRect : ObservedValue<Rect>
	{
		public ObservedRect()
		{
		}

		public ObservedRect(Rect rectValue, Operation operations = Operation.AllChanges, string fullName = null)
		{
		}
	}
}
