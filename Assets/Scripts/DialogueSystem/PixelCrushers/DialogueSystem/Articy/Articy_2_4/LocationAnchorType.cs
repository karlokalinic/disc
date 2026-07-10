using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class LocationAnchorType
	{
		private float xField;

		private bool xFieldSpecified;

		private float yField;

		private bool yFieldSpecified;

		private string colorField;

		private AnchorSizeNamesType sizeField;

		private bool sizeFieldSpecified;

		[XmlAttribute]
		public float X
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool XSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlAttribute]
		public float Y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool YSpecified
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		[XmlAttribute]
		public AnchorSizeNamesType Size
		{
			get
			{
				return default(AnchorSizeNamesType);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public bool SizeSpecified
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
