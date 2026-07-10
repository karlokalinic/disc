using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class LocalizableTextPropertyType
	{
		private LocalizedStringType[] localizedStringField;

		private string nameField;

		private int countField;

		[XmlElement]
		public LocalizedStringType[] LocalizedString
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
