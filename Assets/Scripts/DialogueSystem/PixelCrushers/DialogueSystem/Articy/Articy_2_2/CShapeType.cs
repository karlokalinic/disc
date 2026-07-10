using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
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
