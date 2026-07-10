using System;
using System.Collections.Generic;

namespace statistics
{
	[Serializable]
	public class Conversation : FieldHolder
	{
		public int Id;

		public string Title;

		public string Description;

		public List<string> References;

		public List<DialogueEntry> Entries;

		public ConversationType ConversationType;

		public string Instruction;

		public override List<string> GetSelectableFields()
		{
			return null;
		}
	}
}
