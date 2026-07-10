using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class PinType
	{
		private string expressionField;

		private string idField;

		private int indexField;

		private SemanticType semanticField;

		public string Expression
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
		public string Id
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
		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public SemanticType Semantic
		{
			get
			{
				return default(SemanticType);
			}
			set
			{
			}
		}
	}
}
