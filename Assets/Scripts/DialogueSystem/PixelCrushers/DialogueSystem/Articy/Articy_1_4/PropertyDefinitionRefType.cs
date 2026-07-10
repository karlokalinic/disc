using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class PropertyDefinitionRefType
	{
		private string guidRefField;

		private string valueField;

		[XmlAttribute]
		public string GuidRef
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
