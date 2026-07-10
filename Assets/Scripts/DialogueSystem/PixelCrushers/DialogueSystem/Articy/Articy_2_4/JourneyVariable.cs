using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class JourneyVariable
	{
		private string nameField;

		private VariableDataTypeType dataTypeField;

		private string valueField;

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

		[XmlAttribute]
		public VariableDataTypeType DataType
		{
			get
			{
				return default(VariableDataTypeType);
			}
			set
			{
			}
		}

		[XmlAttribute]
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
