using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class VerticesType
	{
		private int countField;

		private string valueField;

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

		[XmlText]
		public string Value
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
