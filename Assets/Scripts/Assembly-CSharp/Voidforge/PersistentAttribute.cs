using System;

namespace Voidforge
{
	public class PersistentAttribute : Attribute
	{
		private static bool _isEnabled;

		public static bool isEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
