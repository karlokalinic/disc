using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class PathType
	{
		private LocalizableTextType displayNameField;

		private LocalizableTextType textField;

		private string colorField;

		private string technicalNameField;

		private string externalIdField;

		private string shortIdField;

		private FeaturesType featuresField;

		private VisibilityType visibilityField;

		private SelectabilityType selectabilityField;

		private PreviewImageType previewImageField;

		private VerticesType verticesField;

		private string idField;

		private string objectTemplateReferenceField;

		private string objectTemplateReferenceNameField;

		private float xField;

		private float yField;

		private float zIndexField;

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

		public VerticesType Vertices
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

		[XmlAttribute]
		public float X
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public float Y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[XmlAttribute]
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
	}
}
