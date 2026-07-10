using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class SpotType
	{
		private LocalizableTextType displayNameField;

		private LocalizableTextType textField;

		private string colorField;

		private string technicalNameField;

		private string externalIdField;

		private string shortIdField;

		private string urlField;

		private FeaturesType featuresField;

		private VisibilityType visibilityField;

		private SelectabilityType selectabilityField;

		private PreviewImageType previewImageField;

		private PointType positionField;

		private float zIndexField;

		private bool showDisplayNameField;

		private string displayNameColorField;

		private bool dropShadowField;

		private SpotStyleType styleField;

		private string idField;

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

		public VisibilityType Visibility
		{
			get
			{
				return default(VisibilityType);
			}
			set
			{
			}
		}

		public SelectabilityType Selectability
		{
			get
			{
				return default(SelectabilityType);
			}
			set
			{
			}
		}

		public PreviewImageType PreviewImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointType Position
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float ZIndex
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ShowDisplayName
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string DisplayNameColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool DropShadow
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SpotStyleType Style
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
