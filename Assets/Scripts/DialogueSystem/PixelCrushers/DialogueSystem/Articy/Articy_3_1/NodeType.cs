using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class NodeType
	{
		private NodeType[] nodeField;

		private string[] textField;

		private string idRefField;

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
		public string IdRef
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
