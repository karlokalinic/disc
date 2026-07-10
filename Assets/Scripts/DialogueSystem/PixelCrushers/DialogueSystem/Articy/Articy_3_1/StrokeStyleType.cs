using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	public enum StrokeStyleType
	{
		Solid = 0,
		Dot = 1,
		Dash = 2,
		DashDot = 3,
		DashDotDot = 4
	}
}
