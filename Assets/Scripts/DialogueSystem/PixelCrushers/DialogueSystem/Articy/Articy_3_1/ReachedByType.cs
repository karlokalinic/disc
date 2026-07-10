using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	public enum ReachedByType
	{
		Invalid = 0,
		JourneyStart = 1,
		Skip = 2,
		Next = 3,
		Submerge = 4,
		Emerge = 5,
		Branch = 6,
		EndPoint = 7
	}
}
