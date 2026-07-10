using System.Collections.Generic;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	public class Conversation
	{
		[XmlAttribute]
		public int ID;

		[XmlAttribute]
		public string NodeColor;

		[XmlAttribute]
		public string LockedMode;

		public List<Field> Fields;

		public List<DialogEntry> DialogEntries;
	}
}
