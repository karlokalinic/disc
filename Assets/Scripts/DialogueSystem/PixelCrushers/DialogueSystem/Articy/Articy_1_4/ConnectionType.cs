using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class ConnectionType
	{
		private string colorField;

		private string technicalNameField;

		private LocalizableTextType labelField;

		private ConnectionRefType sourceField;

		private ConnectionRefType targetField;

		private string guidField;

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

		[XmlAttribute]
		public string Guid
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
