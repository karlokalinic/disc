using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class FeatureDefinitionsType
	{
		private FeatureDefinitionRefType[] featureDefinitionRefField;

		private int countField;

		private bool countFieldSpecified;

		[XmlElement]
		public FeatureDefinitionRefType[] FeatureDefinitionRef
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

		[XmlIgnore]
		public bool CountSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
