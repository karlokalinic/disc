using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlRoot]
	[XmlType]
	[DebuggerStepThrough]
	public class ExportType
	{
		private SettingsType settingsField;

		private ContentType contentField;

		private HierarchyType hierarchyField;

		private ExportErrorsType exportErrorsField;

		private string versionField;

		private string creatorToolField;

		private string creatorVersionField;

		private DateTime createdOnField;

		public SettingsType Settings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ContentType Content
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HierarchyType Hierarchy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExportErrorsType ExportErrors
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
		public string Version
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
		public string CreatorTool
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
		public string CreatorVersion
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
		public DateTime CreatedOn
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}
	}
}
