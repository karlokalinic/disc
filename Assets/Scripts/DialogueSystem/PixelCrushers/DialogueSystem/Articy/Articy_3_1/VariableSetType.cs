using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class VariableSetType
	{
		private string urlField;

		private string technicalNameField;

		private LocalizableTextType descriptionField;

		private VariablesType variablesField;

		private string idField;

		public string Url
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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
