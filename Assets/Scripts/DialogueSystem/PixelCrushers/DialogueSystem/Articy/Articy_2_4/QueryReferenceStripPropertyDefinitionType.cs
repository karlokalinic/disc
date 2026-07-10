using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class QueryReferenceStripPropertyDefinitionType
	{
		private LocalizableTextType displayNameField;

		private string colorField;

		private string technicalNameField;

		private string tooltipTextField;

		private int isMandatoryField;

		private bool isMandatoryFieldSpecified;

		private int isLocalizedField;

		private bool isLocalizedFieldSpecified;

		private string placeholderValueField;

		private string defaultValueField;

		private string idField;

		private string basedOnField;

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

		public string TooltipText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int IsMandatory
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool IsMandatorySpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int IsLocalized
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool IsLocalizedSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string PlaceholderValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DefaultValue
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

		[XmlAttribute]
		public string BasedOn
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
