using System;
using UnityEngine;

namespace CollageMode
{
	public abstract class DragAction
	{
		public Action<Vector2> DragStarted;

		public Action<Vector2> DragFinished;

		public Vector2 Value { get; protected set; }

		public bool IsDragged { get; protected set; }

		public void ForceSubmitDrag(bool notify = false)
		{
		}

		public void Clamp(float minX, float maxX, float minY = 0f, float maxY = 0f)
		{
		}
	}
}
