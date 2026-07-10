using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class PropertyDefinitionRefType
	{
		private string idRefField;

		private string valueField;

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
