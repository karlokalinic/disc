using System;
using System.Collections.Generic;
using Voidforge;

namespace statistics
{
	[Serializable]
	public class DialogueEntry : FieldHolder
	{
		public int Id;

		public string Title;

		public string DialogueText;

		public string UserScript;

		public string Condition;

		public List<Voidforge.Tuple<int, int>> OutgoingLinks;

		public NodeType NodeType;

		public override List<string> GetSelectableFields()
		{
			return null;
		}
	}
}
