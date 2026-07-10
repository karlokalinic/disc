using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class CreateDialoguePoll
	{
		public Speaker speaker;

		public string prompt;

		public Options[] options;

		public static CreateDialoguePoll GetExample()
		{
			return null;
		}
	}
}
