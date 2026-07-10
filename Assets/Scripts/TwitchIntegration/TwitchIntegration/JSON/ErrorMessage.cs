using System;

namespace TwitchIntegration.JSON
{
	[Serializable]
	public class ErrorMessage
	{
		public string error_code;

		public string error_message;

		public override string ToString()
		{
			return null;
		}
	}
}
