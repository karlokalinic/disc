using System.Collections.Generic;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	public class DialogEntry
	{
		[XmlAttribute]
		public int ID;

		[XmlAttribute]
		public bool IsRoot;

		[XmlAttribute]
		public bool IsGroup;

		[XmlAttribute]
		public string NodeColor;

		[XmlAttribute]
		public bool DelaySimStatus;

		[XmlAttribute]
		public string FalseCondtionAction;

		[XmlAttribute]
		public string ConditionPriority;

		public List<Field> Fields;

		public List<Link> OutgoingLinks;

		public string ConditionsString;

		public string UserScript;
	}
}
