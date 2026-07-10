using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	public enum LinkStyleKindType
	{
		Inherited = 0,
		PreviewImage = 1,
		IconOnly = 2,
		Minimal = 3
	}
}
