using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class CommentType
	{
		private LocalizableTextType textField;

		private string colorField;

		private string urlField;

		private DateTime createdOnField;

		private string createdByField;

		private string idField;

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

		public string CreatedBy
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
