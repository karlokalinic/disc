using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class VariableType
	{
		private string technicalNameField;

		private LocalizableTextType descriptionField;

		private VariableDataTypeType dataTypeField;

		private string defaultValueField;

		[XmlElement]
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

		public LocalizableTextType Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VariableDataTypeType DataType
		{
			get
			{
				return default(VariableDataTypeType);
			}
			set
			{
			}
		}

		public string DefaultValue
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
