using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_2_4
{
	[Serializable]
	[XmlType]
	[DebuggerStepThrough]
	public class CoordinatesType
	{
		private VerticesType[] verticesField;

		[XmlElement]
		public VerticesType[] Vertices
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
