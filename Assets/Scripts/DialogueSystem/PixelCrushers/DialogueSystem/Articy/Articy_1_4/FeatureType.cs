using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class FeatureType
	{
		private PropertiesType[] propertiesField;

		private string nameField;

		private string guidRefField;

		[XmlElement]
		public PropertiesType[] Properties
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
		public string GuidRef
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
