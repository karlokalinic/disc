using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	public enum ShapeType
	{
		Polygon = 0,
		Circle = 1,
		Rectangle = 2
	}
}
