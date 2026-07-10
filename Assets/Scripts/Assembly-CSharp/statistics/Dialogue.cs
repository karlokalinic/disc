using System;
using System.Collections.Generic;

namespace statistics
{
	[Serializable]
	public class Dialogue
	{
		public Dictionary<string, List<string>> Filters;

		public List<Conversation> Conversations;
	}
}
