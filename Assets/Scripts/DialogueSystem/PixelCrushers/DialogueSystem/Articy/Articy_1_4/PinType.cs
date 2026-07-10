using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class PinType
	{
		private string expressionField;

		private string guidField;

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
		public string Guid
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
