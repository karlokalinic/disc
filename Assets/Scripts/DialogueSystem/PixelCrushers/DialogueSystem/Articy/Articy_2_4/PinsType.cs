using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class PinsType
	{
		private PinType[] pinField;

		private int countField;

		[XmlElement]
		public PinType[] Pin
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
		public int Count
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
