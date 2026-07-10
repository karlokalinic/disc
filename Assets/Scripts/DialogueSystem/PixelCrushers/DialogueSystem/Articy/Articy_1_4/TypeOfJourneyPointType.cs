using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	public enum TypeOfJourneyPointType
	{
		FlowFragment = 0,
		Dialog = 1,
		DialogFragment = 2,
		Connection = 3,
		Pin = 4,
		Hub = 5,
		Jump = 6,
		FlowConnectionSelection = 7,
		DialogConnectionSelection = 8,
		InputPinSelection = 9,
		OutputPinSelection = 10
	}
}
