using System;

namespace InControl
{
	[Serializable]
	public class InControlException : Exception
	{
		public InControlException()
		{
		}

		public InControlException(string message)
		{
		}

		public InControlException(string message, Exception inner)
		{
		}
	}
}
