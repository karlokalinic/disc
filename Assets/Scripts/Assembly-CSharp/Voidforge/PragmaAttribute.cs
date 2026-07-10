using System;

namespace Voidforge
{
	public class PragmaAttribute : Attribute
	{
		public bool keepDuplicate { get; set; }

		public bool suppressSingletonWarning { get; set; }
	}
}
