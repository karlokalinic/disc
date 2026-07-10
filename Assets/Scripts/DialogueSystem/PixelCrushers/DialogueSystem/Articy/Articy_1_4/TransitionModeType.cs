using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	public enum TransitionModeType
	{
		None = 0,
		Animated = 1
	}
}
