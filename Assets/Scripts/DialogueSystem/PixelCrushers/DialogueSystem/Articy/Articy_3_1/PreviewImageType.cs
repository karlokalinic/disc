using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class PreviewImageType
	{
		private RectangleType viewBoxField;

		private string idRefField;

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
		public string IdRef
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
