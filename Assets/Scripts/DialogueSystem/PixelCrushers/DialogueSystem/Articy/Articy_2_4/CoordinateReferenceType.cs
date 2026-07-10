using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	public enum CoordinateReferenceType
	{
		Local = 0,
		World = 1
	}
}
