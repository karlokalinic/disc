using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class LinkStyleType
	{
		private LinkStyleKindType kindField;

		private SizeNamesType sizeField;

		[XmlAttribute]
		public LinkStyleKindType Kind
		{
			get
			{
				return default(LinkStyleKindType);
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
