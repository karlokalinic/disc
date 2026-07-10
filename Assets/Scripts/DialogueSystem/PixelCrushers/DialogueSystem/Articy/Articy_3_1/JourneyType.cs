using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class JourneyType
	{
		private LocalizableTextType displayNameField;

		private LocalizableTextType textField;

		private string colorField;

		private string technicalNameField;

		private string externalIdField;

		private string shortIdField;

		private string urlField;

		private ReferencesType referencesField;

		private JourneySettingsType settingsField;

		private VariableValuesListType initialVariableValuesField;

		private JourneyPointsType journeyPointsField;

		private string idField;

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

		public LocalizableTextType Text
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

		public string ExternalId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ShortId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public ReferencesType References
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JourneySettingsType Settings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VariableValuesListType InitialVariableValues
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JourneyPointsType JourneyPoints
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
