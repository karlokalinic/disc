using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	public class Field
	{
		[XmlAttribute]
		public string Hint;

		[XmlAttribute]
		public string Type;

		public string Title;

		public string Value;
	}
}
