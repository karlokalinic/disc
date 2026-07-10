using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class LocalizableTextType
	{
		private LocalizedStringType[] localizedStringField;

		private int countField;

		private bool hasMarkupField;

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

		[XmlAttribute]
		public bool HasMarkup
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
