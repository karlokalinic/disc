using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	[XmlRoot]
	public class ChatMapperProject
	{
		[XmlAttribute]
		public string Title;

		[XmlAttribute]
		public string Version;

		[XmlAttribute]
		public string Author;

		[XmlAttribute]
		public string EmphasisColor1Label;

		[XmlAttribute]
		public string EmphasisColor1;

		[XmlAttribute]
		public string EmphasisStyle1;

		[XmlAttribute]
		public string EmphasisColor2Label;

		[XmlAttribute]
		public string EmphasisColor2;

		[XmlAttribute]
		public string EmphasisStyle2;

		[XmlAttribute]
		public string EmphasisColor3Label;

		[XmlAttribute]
		public string EmphasisColor3;

		[XmlAttribute]
		public string EmphasisStyle3;

		[XmlAttribute]
		public string EmphasisColor4Label;

		[XmlAttribute]
		public string EmphasisColor4;

		[XmlAttribute]
		public string EmphasisStyle4;

		public string Description;

		public string UserScript;

		public Assets Assets;

		public DialogueDatabase ToDialogueDatabase()
		{
			return null;
		}
	}
}
