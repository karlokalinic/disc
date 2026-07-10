using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	public enum PathCapNamesType
	{
		ColoredDot = 0,
		None = 1,
		LineArrowHead = 2,
		FilledArrowHead = 3,
		Diamond = 4,
		Square = 5,
		Disc = 6
	}
}
