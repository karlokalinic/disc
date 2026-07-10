using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class AllowedTemplate
	{
		private string nameField;

		private string guidRefField;

		[XmlAttribute]
		public string Name
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
	}
}
