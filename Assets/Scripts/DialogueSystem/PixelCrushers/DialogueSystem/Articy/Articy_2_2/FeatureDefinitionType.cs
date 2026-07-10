using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class FeatureDefinitionType
	{
		private LocalizableTextType displayNameField;

		private string colorField;

		private string technicalNameField;

		private PropertyDefinitionsType propertyDefinitionsField;

		private string idField;

		private string basedOnField;

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

		public string Color
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

		public PropertyDefinitionsType PropertyDefinitions
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

		[XmlAttribute]
		public string BasedOn
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
