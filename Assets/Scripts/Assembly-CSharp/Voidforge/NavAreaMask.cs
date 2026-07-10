using System;

namespace Voidforge
{
	[Serializable]
	public struct NavAreaMask
	{
		public int value;

		public static implicit operator int(NavAreaMask mask)
		{
			return 0;
		}

		public static implicit operator NavAreaMask(int intVal)
		{
			return default(NavAreaMask);
		}
	}
}
