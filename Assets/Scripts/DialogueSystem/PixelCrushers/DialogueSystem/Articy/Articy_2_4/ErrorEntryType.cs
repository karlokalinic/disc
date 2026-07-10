using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class ErrorEntryType
	{
		private ErrorSeverityType severityField;

		private string valueField;

		[XmlAttribute]
		public ErrorSeverityType Severity
		{
			get
			{
				return default(ErrorSeverityType);
			}
			set
			{
			}
		}

		[XmlText]
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
