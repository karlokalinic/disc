using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class SpotStyleType
	{
		private SpotStyleKindType kindField;

		private SizeNamesType sizeField;

		[XmlAttribute]
		public SpotStyleKindType Kind
		{
			get
			{
				return default(SpotStyleKindType);
			}
			set
			{
			}
		}

		[XmlAttribute]
		public SizeNamesType Size
		{
			get
			{
				return default(SizeNamesType);
			}
			set
			{
			}
		}
	}
}
