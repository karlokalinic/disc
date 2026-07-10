using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class TextPropertyDefinitionType
	{
		private LocalizableTextType displayNameField;

		private string technicalNameField;

		private string tooltipTextField;

		private int isMandatoryField;

		private bool isMandatoryFieldSpecified;

		private int isLocalizedField;

		private bool isLocalizedFieldSpecified;

		private string placeholderValueField;

		private TextPropertyDefinitionValueType defaultValueField;

		private decimal disallowedCharsField;

		private bool disallowedCharsFieldSpecified;

		private int maxLengthField;

		private bool maxLengthFieldSpecified;

		private int allowsLinebreaksField;

		private bool allowsLinebreaksFieldSpecified;

		private string guidField;

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

		public TextPropertyDefinitionValueType DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public decimal DisallowedChars
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
		public bool DisallowedCharsSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int MaxLength
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
		public bool MaxLengthSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int AllowsLinebreaks
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
		public bool AllowsLinebreaksSpecified
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
