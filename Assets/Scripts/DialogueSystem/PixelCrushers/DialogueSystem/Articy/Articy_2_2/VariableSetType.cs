using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class VariableSetType
	{
		private string technicalNameField;

		private LocalizableTextType descriptionField;

		private VariablesType variablesField;

		private string idField;

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

		public VariablesType Variables
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
		public string Id
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
