using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class NoteContentType
	{
		private XmlElement anyField;

		private int countField;

		[XmlAnyElement]
		public XmlElement Any
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
		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
