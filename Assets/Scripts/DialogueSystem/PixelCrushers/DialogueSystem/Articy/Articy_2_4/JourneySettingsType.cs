using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class JourneySettingsType
	{
		private BackgroundImageModeType backgroundImageModeField;

		private ReferenceType backgroundImageField;

		private BackgroundImagePositioningModeType backgroundImagePositioningModeField;

		private BackgroundColorModeType backgroundColorModeField;

		private string backgroundColorField;

		private BackgroundColorGradientModeType backgroundColorGradientModeField;

		private int durationField;

		private TransitionModeType transitionModeField;

		public BackgroundImageModeType BackgroundImageMode
		{
			get
			{
				return default(BackgroundImageModeType);
			}
			set
			{
			}
		}

		public ReferenceType BackgroundImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BackgroundImagePositioningModeType BackgroundImagePositioningMode
		{
			get
			{
				return default(BackgroundImagePositioningModeType);
			}
			set
			{
			}
		}

		public BackgroundColorModeType BackgroundColorMode
		{
			get
			{
				return default(BackgroundColorModeType);
			}
			set
			{
			}
		}

		public string BackgroundColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BackgroundColorGradientModeType BackgroundColorGradientMode
		{
			get
			{
				return default(BackgroundColorGradientModeType);
			}
			set
			{
			}
		}

		public int Duration
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public TransitionModeType TransitionMode
		{
			get
			{
				return default(TransitionModeType);
			}
			set
			{
			}
		}
	}
}
