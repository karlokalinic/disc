using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	public enum TypeOfJourneyPointType
	{
		FlowFragment = 0,
		Dialogue = 1,
		DialogueFragment = 2,
		Connection = 3,
		Pin = 4,
		Hub = 5,
		Jump = 6,
		FlowConnectionSelection = 7,
		DialogueConnectionSelection = 8,
		InputPinSelection = 9,
		OutputPinSelection = 10,
		ConditionNode = 11,
		OutcomeNode = 12
	}
}
