using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.ChatMapper
{
	public class Link
	{
		[XmlAttribute]
		public int ConversationID;

		[XmlAttribute]
		public int OriginConvoID;

		[XmlAttribute]
		public int DestinationConvoID;

		[XmlAttribute]
		public int OriginDialogID;

		[XmlAttribute]
		public int DestinationDialogID;

		[XmlAttribute]
		public bool IsConnector;
	}
}
