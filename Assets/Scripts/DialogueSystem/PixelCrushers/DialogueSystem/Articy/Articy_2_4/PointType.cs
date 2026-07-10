using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class PointType
	{
		private float xField;

		private float yField;

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
	}
}
