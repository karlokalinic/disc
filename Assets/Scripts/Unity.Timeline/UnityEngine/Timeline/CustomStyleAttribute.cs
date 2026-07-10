using System;

namespace UnityEngine.Timeline
{
	public class CustomStyleAttribute : Attribute
	{
		public readonly string ussStyle;

		public CustomStyleAttribute(string ussStyle)
		{
		}
	}
}
