using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class ReferenceType
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
