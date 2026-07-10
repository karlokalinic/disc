using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	public enum VariableDataTypeType
	{
		Boolean = 0,
		Integer = 1,
		String = 2
	}
}
