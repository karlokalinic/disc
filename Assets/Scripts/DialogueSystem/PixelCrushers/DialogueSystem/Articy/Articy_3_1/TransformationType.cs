using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_3_1
{
	[Serializable]
	[DebuggerStepThrough]
	[XmlType]
	public class TransformationType
	{
		private float rotationField;

		private PointType pivotField;

		private PointType xAxisField;

		private PointType yAxisField;

		private PointType translationField;

		private string transformMatrixField;

		private RectangleType boundsField;

		public float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public PointType Pivot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointType XAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointType YAxis
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointType Translation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TransformMatrix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectangleType Bounds
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
