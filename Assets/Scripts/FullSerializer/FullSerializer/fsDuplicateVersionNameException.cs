using System;

namespace FullSerializer
{
	public sealed class fsDuplicateVersionNameException : Exception
	{
		public fsDuplicateVersionNameException(Type typeA, Type typeB, string version)
		{
		}
	}
}
