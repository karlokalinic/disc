using System;

namespace Voidforge
{
	public class AssetAttribute : Attribute
	{
		public string name { get; set; }

		public string path { get; set; }

		public string FullName => null;
	}
}
