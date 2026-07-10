using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CollageMode
{
	public abstract class CollageElement : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public class InitData : SingularSerializableData
		{
			[JsonIgnore]
			public Guid Guid;

			[OnDeserialized]
			internal void OnDeserialized(StreamingContext context)
			{
			}
		}

		[SerializeField]
		private float maxScale;

		[SerializeField]
		private float minScale;

		[SerializeField]
		private float scaleSensitivity;

		[SerializeField]
		protected float gamepadDragSensitivity;

		[SerializeField]
		private float gamepadScaleSensitivity;

		[SerializeField]
		protected float positionPlacementOffsetZ;

		protected DragInput dragInput;

		protected float defaultScale;

		protected Vector3 previousPosition;

		protected float previousRotation;

		protected Vector2 dragMouseScreenSpaceOffset;

		protected Vector3 dragInitialRotation;

		protected float previousScale;

		protected bool isMoving;

		protected bool isScaling;

		protected bool isRotating;

		protected virtual bool CanRotate => false;

		protected virtual bool CanScale => false;

		public Guid Guid { get; private set; }

		public string originIdentifier { get; private set; }

		public bool IsInInitialPlacement { get; set; }

		public bool IsSelected => false;

		public virtual bool UsesSortingOrder => false;

		public virtual int SortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string DisplayTerm { get; }

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		private void SubmitInitialPlacement()
		{
		}

		public virtual void Init(InitData initData)
		{
		}

		public virtual InitData GetInitData()
		{
			return null;
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void Remove()
		{
		}

		public void ResetScale()
		{
		}

		public void ResetRotation()
		{
		}

		public virtual void ResetAll()
		{
		}

		protected virtual void SetHidden(bool isHidden)
		{
		}

		protected virtual void InitialPlacementSubmitted()
		{
		}

		protected virtual void MoveStarted()
		{
		}

		protected virtual void MoveSubmitted()
		{
		}

		protected virtual void RotateStarted()
		{
		}

		protected virtual void RotateSubmitted()
		{
		}

		protected virtual void Clicked()
		{
		}

		protected virtual Vector3 GetMousePlacementPosition()
		{
			return default(Vector3);
		}

		protected virtual Vector3 GetGamepadPlacementPosition()
		{
			return default(Vector3);
		}

		protected virtual Vector3 ScreenToTargetPosition(Vector3 targetScreenSpacePosition)
		{
			return default(Vector3);
		}

		protected abstract void RefreshSelectionVisual(bool isSelected);

		protected void ClampGamepadDragInput()
		{
		}

		private void AbortInitialPlacement()
		{
		}

		private void OnSelectionChanged(CollageElement collageElement, SelectionMode selectionMode)
		{
		}

		private void SubmitScaling()
		{
		}

		private void OnMoveDragStarted(Vector2 value)
		{
		}

		private void OnMoveDragFinished(Vector2 value)
		{
		}

		private void FinishMove()
		{
		}

		private void OnRotateDragStarted(Vector2 value)
		{
		}

		private void OnRotateDragFinished(Vector2 value)
		{
		}

		private void FinishRotate()
		{
		}

		private void OnScaleDragStarted(Vector2 value)
		{
		}

		private void OnScaleDragFinished(Vector2 value)
		{
		}

		private void FinishScale()
		{
		}
	}
}
