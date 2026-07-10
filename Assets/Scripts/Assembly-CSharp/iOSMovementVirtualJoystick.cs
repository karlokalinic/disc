using InControl;
using UnityEngine;
using Touch = InControl.Touch;

public class iOSMovementVirtualJoystick : iOSVirtualStickParent
{
	public float RunThreshold;

	private TouchSprite m_debugThresholdShape;

	private Transform m_debugThresholdTransform;

	public Vector3 DebugThresholdPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	public override void ActivateDebugShape(bool value)
	{
	}

	public void SetRunThreshold(float value)
	{
	}

	public override void SetRingSize(float newSize)
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

	protected override void Update()
	{
	}

	protected override void Activate(Touch touch)
	{
	}

	public override void TouchMoved(Touch touch)
	{
	}

	public override void TouchEnded(Touch touch)
	{
	}
}
