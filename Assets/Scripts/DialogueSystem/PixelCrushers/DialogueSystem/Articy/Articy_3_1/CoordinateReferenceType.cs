using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	public enum CoordinateReferenceType
	{
		Local = 0,
		World = 1
	}
}
