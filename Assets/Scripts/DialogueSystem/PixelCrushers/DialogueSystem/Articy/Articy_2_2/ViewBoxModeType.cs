using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	public enum ViewBoxModeType
	{
		FromAsset = 0,
		Custom = 1,
		Auto = 2
	}
}
