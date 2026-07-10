using System.Collections.Generic;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	public class Item
	{
		[XmlAttribute]
		public int ID;

		public List<Field> Fields;
	}
}
