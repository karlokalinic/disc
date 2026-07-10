using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class ProjectSettingsType
	{
		private FlowSettingsType flowSettingsField;

		private JourneySettingsType journeySettingsField;

		private LocationSettingsType locationSettingsField;

		private ExternalApplicationsType externalApplicationsField;

		private string idField;

		public FlowSettingsType FlowSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public JourneySettingsType JourneySettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocationSettingsType LocationSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExternalApplicationsType ExternalApplications
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
