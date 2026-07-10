using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class ExportErrorsType
	{
		private ErrorEntryType[] itemsField;

		[XmlElement]
		public ErrorEntryType[] Items
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
