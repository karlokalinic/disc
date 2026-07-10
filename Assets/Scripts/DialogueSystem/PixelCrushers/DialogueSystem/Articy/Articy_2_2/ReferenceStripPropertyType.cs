using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class ReferenceStripPropertyType : ReferencesType
	{
		private string nameField;

		[XmlAttribute]
		public string Name
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
