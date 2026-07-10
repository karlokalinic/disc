using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class PreviewImageType
	{
		private RectangleType viewBoxField;

		private string guidRefField;

		private ViewBoxModeType modeField;

		public RectangleType ViewBox
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
		public string GuidRef
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
		public ViewBoxModeType Mode
		{
			get
			{
				return default(ViewBoxModeType);
			}
			set
			{
			}
		}
	}
}
