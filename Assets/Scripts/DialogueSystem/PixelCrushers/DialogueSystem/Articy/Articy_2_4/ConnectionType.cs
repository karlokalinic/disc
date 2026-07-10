using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class ConnectionType
	{
		private string colorField;

		private string technicalNameField;

		private string urlField;

		private LocalizableTextType labelField;

		private ConnectionRefType sourceField;

		private ConnectionRefType targetField;

		private bool showLabelField;

		private string idField;

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

		public LocalizableTextType Label
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConnectionRefType Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ConnectionRefType Target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ShowLabel
		{
			get
			{
				return false;
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
