using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class LocationSettingsType
	{
		private int showDisplayNameForZoneField;

		private int dropShadowForZoneField;

		private float displayNameSizeForZoneField;

		private string displayNameColorForZoneField;

		private int showDisplayNameForPathField;

		private int dropShadowForPathField;

		private float displayNameSizeForPathField;

		private string displayNameColorForPathField;

		private int showDisplayNameForImageField;

		private int dropShadowForImageField;

		private float displayNameSizeForImageField;

		private string displayNameColorForImageField;

		private int showDisplayNameForSpotField;

		private int dropShadowForSpotField;

		private string displayNameColorForSpotField;

		private SpotStyleKindType spotStyleKindField;

		private SizeNamesType spotStyleSizeField;

		private int showDisplayNameForLinkField;

		private int dropShadowForLinkField;

		private string displayNameColorForLinkField;

		private LinkStyleKindType linkStyleKindField;

		private SizeNamesType linkStyleSizeField;

		private int dropShadowForTextField;

		public int ShowDisplayNameForZone
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DropShadowForZone
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float DisplayNameSizeForZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string DisplayNameColorForZone
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ShowDisplayNameForPath
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DropShadowForPath
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float DisplayNameSizeForPath
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string DisplayNameColorForPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ShowDisplayNameForImage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DropShadowForImage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float DisplayNameSizeForImage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string DisplayNameColorForImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ShowDisplayNameForSpot
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DropShadowForSpot
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string DisplayNameColorForSpot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpotStyleKindType SpotStyleKind
		{
			get
			{
				return default(SpotStyleKindType);
			}
			set
			{
			}
		}

		public SizeNamesType SpotStyleSize
		{
			get
			{
				return default(SizeNamesType);
			}
			set
			{
			}
		}

		public int ShowDisplayNameForLink
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DropShadowForLink
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string DisplayNameColorForLink
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LinkStyleKindType LinkStyleKind
		{
			get
			{
				return default(LinkStyleKindType);
			}
			set
			{
			}
		}

		public SizeNamesType LinkStyleSize
		{
			get
			{
				return default(SizeNamesType);
			}
			set
			{
			}
		}

		public int DropShadowForText
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
