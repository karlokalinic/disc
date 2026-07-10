using System;

namespace UnityEngine.Timeline
{
	internal class MenuCategoryAttribute : Attribute
	{
		public readonly string category;

		public MenuCategoryAttribute(string category)
		{
		}
	}
}
