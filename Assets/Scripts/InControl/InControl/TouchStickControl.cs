using UnityEngine;

namespace InControl
{
	public class TouchStickControl : TouchControl
	{
		[SerializeField]
		private TouchControlAnchor anchor;

		[SerializeField]
		private TouchUnitType offsetUnitType;

		[SerializeField]
		private Vector2 offset;

		[SerializeField]
		private TouchUnitType areaUnitType;

		[SerializeField]
		private Rect activeArea;

		public AnalogTarget target;

		public SnapAngles snapAngles;

		public LockAxis lockToAxis;

		public float lowerDeadZone;

		public float upperDeadZone;

		public AnimationCurve inputCurve;

		public bool allowDragging;

		public DragAxis allowDraggingAxis;

		public bool snapToInitialTouch;

		public bool resetWhenDone;

		public float resetDuration;

		public TouchSprite ring;

		public TouchSprite knob;

		public float knobRange;

		private Vector3 resetPosition;

		private Vector3 beganPosition;

		private Vector3 movedPosition;

		private float ringResetSpeed;

		private float knobResetSpeed;

		private Rect worldActiveArea;

		private float worldKnobRange;

		private Vector3 value;

		private Touch currentTouch;

		private bool dirty;

		public bool IsActive => false;

		public bool IsNotActive => false;

		public Vector3 RingPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 KnobPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public TouchControlAnchor Anchor
		{
			get
			{
				return default(TouchControlAnchor);
			}
			set
			{
			}
		}

		public Vector2 Offset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public TouchUnitType OffsetUnitType
		{
			get
			{
				return default(TouchUnitType);
			}
			set
			{
			}
		}

		public Rect ActiveArea
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public TouchUnitType AreaUnitType
		{
			get
			{
				return default(TouchUnitType);
			}
			set
			{
			}
		}

		public override void CreateControl()
		{
		}

		public override void DestroyControl()
		{
		}

		public override void ConfigureControl()
		{
		}

		public override void DrawGizmos()
		{
		}

		private void Update()
		{
		}

		public override void SubmitControlState(ulong updateTick, float deltaTime)
		{
		}

		public override void CommitControlState(ulong updateTick, float deltaTime)
		{
		}

		public override void TouchBegan(Touch touch)
		{
		}

		public override void TouchMoved(Touch touch)
		{
		}

		public override void TouchEnded(Touch touch)
		{
		}
	}
}
