using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	[Serializable]
	public class Actor
	{
		[XmlAttribute]
		public int ID;

		public List<Field> Fields;
	}
}
