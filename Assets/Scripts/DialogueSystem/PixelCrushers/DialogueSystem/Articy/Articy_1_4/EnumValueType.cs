using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class EnumValueType
	{
		private int valueField;

		private string technicalNameField;

		private LocalizableTextType displayNameField;

		public int Value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string TechnicalName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizableTextType DisplayName
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
