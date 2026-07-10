using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	public enum SelectabilityType
	{
		Unselectable = 0,
		Selectable = 1
	}
}
