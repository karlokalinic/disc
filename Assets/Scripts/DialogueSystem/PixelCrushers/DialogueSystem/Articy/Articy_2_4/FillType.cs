using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class FillType
	{
		private string colorField;

		[XmlAttribute]
		public string Color
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
