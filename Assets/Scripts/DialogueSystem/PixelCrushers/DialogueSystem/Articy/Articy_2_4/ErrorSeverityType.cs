using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	public enum ErrorSeverityType
	{
		Soft = 0,
		Hard = 1
	}
}
