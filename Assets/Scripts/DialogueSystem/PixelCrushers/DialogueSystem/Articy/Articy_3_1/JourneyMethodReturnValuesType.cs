using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class JourneyMethodReturnValuesType
	{
		private string scriptTextField;

		private JourneyMethodReturnValueType[] methodValueField;

		private int countField;

		public string ScriptText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlElement]
		public JourneyMethodReturnValueType[] MethodValue
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
		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
