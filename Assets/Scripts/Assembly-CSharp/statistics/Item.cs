using System;
using System.Collections.Generic;

namespace statistics
{
	[Serializable]
	public class Item : FieldHolder
	{
		public int Id;

		public string Name;

		public string Group;

		public string Dialogue;

		public string Container;

		public Item(int id, string name, string group)
		{
		}

		public override List<string> GetSelectableFields()
		{
			return null;
		}
	}
}
