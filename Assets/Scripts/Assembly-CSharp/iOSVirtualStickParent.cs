using InControl;
using UnityEngine;
using Touch = InControl.Touch;

public class iOSVirtualStickParent : TouchControl
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

	public float delayedActivation;

	protected Transform m_transform;

	protected Vector3 resetPosition;

	protected Vector3 beganPosition;

	protected Vector2 beganPositionSS;

	protected Vector3 movedPosition;

	protected float ringResetSpeed;

	protected float knobResetSpeed;

	protected Rect worldActiveArea;

	protected Rect screenSpaceActiveArea;

	protected float worldKnobRange;

	protected Vector3 value;

	protected Touch currentTouch;

	protected bool dirty;

	private float m_beganTime;

	protected float m_knobRangeRatio;

	protected Color m_itemsIdleDebugColor;

	protected Color m_itemsIdleRegularColor;

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

	protected virtual void Awake()
	{
	}

	public virtual void ActivateDebugShape(bool value)
	{
	}

	public virtual void SetRingSize(float newSize)
	{
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

	protected virtual void Update()
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

	public bool ActivationAllowed(Touch touch, out bool insideControl)
	{
		insideControl = default(bool);
		return false;
	}

	protected virtual void Activate(Touch touch)
	{
	}

	protected void DelayedInit(Touch touch)
	{
	}

	public override void TouchMoved(Touch touch)
	{
	}

	public override void TouchEnded(Touch touch)
	{
	}
}
