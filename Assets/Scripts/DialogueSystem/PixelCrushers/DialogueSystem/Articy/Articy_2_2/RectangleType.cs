using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class RectangleType
	{
		private float minXField;

		private float minYField;

		private float maxXField;

		private float maxYField;

		[XmlAttribute]
		public float MinX
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
		public float MinY
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
		public float MaxX
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
		public float MaxY
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
