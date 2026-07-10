using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	public enum AssetCategoryType
	{
		Image = 0,
		Audio = 1,
		Video = 2,
		Document = 3,
		Misc = 4
	}
}
