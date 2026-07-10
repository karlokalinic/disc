using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class JourneyPointType
	{
		private JourneyRefType targetField;

		private LocalizableTextType textField;

		private string externalIdField;

		private string shortIdField;

		private JourneyPointSettingsType settingsField;

		private TypeOfJourneyPointType typeField;

		private ReachedByType reachedByField;

		public JourneyRefType Target
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

		public JourneyPointSettingsType Settings
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
		public TypeOfJourneyPointType Type
		{
			get
			{
				return default(TypeOfJourneyPointType);
			}
			set
			{
			}
		}

		[XmlAttribute]
		public ReachedByType ReachedBy
		{
			get
			{
				return default(ReachedByType);
			}
			set
			{
			}
		}
	}
}
