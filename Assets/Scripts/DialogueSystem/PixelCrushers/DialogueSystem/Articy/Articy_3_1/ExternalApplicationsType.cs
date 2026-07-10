using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class ExternalApplicationsType
	{
		private ApplicationDefinitionType[] itemsField;

		[XmlElement]
		public ApplicationDefinitionType[] Items
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
