using System;

namespace Voidforge
{
	public class UpdateAttribute : Attribute
	{
		public bool ignoreTimeScale { get; set; }

		public int priority { get; set; }

		public UpdateType type { get; set; }

		public UpdateAttribute(UpdateType updateType = UpdateType.NORMAL)
		{
		}
	}
}
