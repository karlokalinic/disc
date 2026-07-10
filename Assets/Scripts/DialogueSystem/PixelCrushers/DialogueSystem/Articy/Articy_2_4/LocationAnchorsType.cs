using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class LocationAnchorsType
	{
		private LocationAnchorType[] anchorField;

		private int countField;

		private bool countFieldSpecified;

		[XmlElement]
		public LocationAnchorType[] Anchor
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
