using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voidforge
{
	public class PositionTrackingTag : VoidTag
	{
		protected Vector3 cachedPosition;

		protected Quaternion cachedRotation;

		protected Vector3 cachedScale;

		protected bool isChanged;

		public event Action TrackingEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void SendTrackingEvent()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
