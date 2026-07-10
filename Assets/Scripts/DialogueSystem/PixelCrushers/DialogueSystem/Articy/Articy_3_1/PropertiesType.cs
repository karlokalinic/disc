using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class PropertiesType
	{
		private object[] itemsField;

		private int countField;

		[XmlElement]
		[XmlElement]
		[XmlElement]
		[XmlElement]
		[XmlElement]
		[XmlElement]
		[XmlElement]
		public object[] Items
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
