using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class CircleType
	{
		private float centerXField;

		private float centerYField;

		private float radiusField;

		[XmlAttribute]
		public float CenterX
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
		public float CenterY
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
		public float Radius
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
