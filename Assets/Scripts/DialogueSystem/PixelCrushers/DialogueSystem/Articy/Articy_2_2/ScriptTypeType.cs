using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	public enum ScriptTypeType
	{
		Unknown = 0,
		Condition = 1,
		Outcome = 2
	}
}
