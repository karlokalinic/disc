using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	public enum BackgroundColorModeType
	{
		FromNode = 0,
		Custom = 1
	}
}
