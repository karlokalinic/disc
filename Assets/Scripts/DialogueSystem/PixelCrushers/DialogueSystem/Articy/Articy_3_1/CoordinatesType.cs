using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
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
