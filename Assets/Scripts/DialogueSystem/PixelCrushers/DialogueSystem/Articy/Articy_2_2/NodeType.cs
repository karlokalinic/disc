using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class NodeType
	{
		private NodeType[] nodeField;

		private string[] textField;

		private string idField;

		private string typeField;

		[XmlElement]
		public NodeType[] Node
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlText]
		public string[] Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public string Type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
