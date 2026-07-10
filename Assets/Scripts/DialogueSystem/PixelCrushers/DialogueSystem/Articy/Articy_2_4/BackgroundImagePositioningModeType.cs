using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	public enum BackgroundImagePositioningModeType
	{
		Fitting = 0,
		Filling = 1,
		Stretched = 2,
		Repeating = 3,
		Centered = 4
	}
}
