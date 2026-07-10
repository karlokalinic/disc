using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class TextPropertyDefinitionValueType
	{
		private LocalizedStringType[] localizedStringField;

		private string[] textField;

		private int countField;

		private bool countFieldSpecified;

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

		[XmlIgnore]
		public bool CountSpecified
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
