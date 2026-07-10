using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class NumberPropertyDefinitionType
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

		private decimal defaultValueField;

		private bool defaultValueFieldSpecified;

		private decimal minValueField;

		private bool minValueFieldSpecified;

		private decimal maxValueField;

		private bool maxValueFieldSpecified;

		private int precisionField;

		private bool precisionFieldSpecified;

		private string unitField;

		private int displayThousandsSeparatorField;

		private bool displayThousandsSeparatorFieldSpecified;

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

		public decimal DefaultValue
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool DefaultValueSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public decimal MinValue
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool MinValueSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public decimal MaxValue
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool MaxValueSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Precision
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
		public bool PrecisionSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Unit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int DisplayThousandsSeparator
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
		public bool DisplayThousandsSeparatorSpecified
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
