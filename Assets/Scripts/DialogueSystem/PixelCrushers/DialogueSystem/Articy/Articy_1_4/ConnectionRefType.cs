using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class ConnectionRefType
	{
		private string guidRefField;

		private string pinRefField;

		private string valueField;

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

		[XmlAttribute]
		public string PinRef
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlText]
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
