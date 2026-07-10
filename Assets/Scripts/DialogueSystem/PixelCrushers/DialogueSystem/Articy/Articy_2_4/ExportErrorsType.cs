using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
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
