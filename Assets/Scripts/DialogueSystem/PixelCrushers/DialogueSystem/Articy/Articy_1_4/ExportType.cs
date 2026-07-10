using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	[XmlRoot]
	public class ExportType
	{
		private ContentType contentField;

		private HierarchyType hierarchyField;

		private string[] exportErrorsField;

		private string versionField;

		private string creatorToolField;

		private string creatorVersionField;

		private DateTime createdOnField;

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

		public string[] ExportErrors
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
