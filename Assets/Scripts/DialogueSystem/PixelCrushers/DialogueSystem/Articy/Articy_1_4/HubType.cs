using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class HubType
	{
		private LocalizableTextType displayNameField;

		private LocalizableTextType textField;

		private string colorField;

		private string technicalNameField;

		private string externalIdField;

		private string shortIdField;

		private FeaturesType featuresField;

		private PinsType pinsField;

		private string[] text1Field;

		private string guidField;

		private string objectTemplateReferenceField;

		private string objectTemplateReferenceNameField;

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

		public FeaturesType Features
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PinsType Pins
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlText]
		public string[] Text1
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

		[XmlAttribute]
		public string ObjectTemplateReference
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
		public string ObjectTemplateReferenceName
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
