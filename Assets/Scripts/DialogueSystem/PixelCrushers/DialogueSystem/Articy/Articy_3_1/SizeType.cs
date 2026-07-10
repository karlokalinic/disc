using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class SizeType
	{
		private float widthField;

		private float heightField;

		[XmlAttribute]
		public float Width
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
		public float Height
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
