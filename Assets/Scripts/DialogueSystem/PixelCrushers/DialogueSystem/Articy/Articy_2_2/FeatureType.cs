using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_2
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class FeatureType
	{
		private PropertiesType[] propertiesField;

		private string nameField;

		private string idRefField;

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
		public string IdRef
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
