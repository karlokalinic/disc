using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class ProjectType
	{
		private string displayNameField;

		private string urlField;

		private string idField;

		public string DisplayName
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
