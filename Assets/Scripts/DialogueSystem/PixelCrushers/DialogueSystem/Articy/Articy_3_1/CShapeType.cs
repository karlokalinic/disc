using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	public enum CShapeType
	{
		Polygon = 0,
		Circle = 1,
		Rectangle = 2
	}
}
