using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class OutlineType
	{
		private string colorField;

		private int sizeField;

		private StrokeStyleType styleField;

		[XmlAttribute]
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

		[XmlAttribute]
		public int Size
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public StrokeStyleType Style
		{
			get
			{
				return default(StrokeStyleType);
			}
			set
			{
			}
		}
	}
}
