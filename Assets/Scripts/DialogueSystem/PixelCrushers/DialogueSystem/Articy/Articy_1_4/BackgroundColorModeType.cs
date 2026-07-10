using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	public enum BackgroundColorModeType
	{
		FromNode = 0,
		Custom = 1
	}
}
