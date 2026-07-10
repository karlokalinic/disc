using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voidforge
{
	public class InputPointer : IDisposable
	{
		protected Camera _camera;

		protected bool _isUpdated;

		protected Line _line;

		protected Vector3? _navPoint;

		protected Vector3 _screenPosition;

		protected Transform _selected;

		protected RaycastHit[] _raycastHits;

		protected RaycastHit2D[] _raycastHits2D;

		public Camera camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isActive => false;

		public Vector3? navPoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 screenPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Transform selected
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action PositionEvent
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

		public event Action<Transform> SelectedEvent
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

		public virtual void Dispose()
		{
		}

		public bool HasLineOfEffect(Vector3 offset)
		{
			return false;
		}

		public void MarkAsChanged()
		{
		}

		protected void Recalculate()
		{
		}
	}
}
