using UnityEngine;

namespace InControl
{
	public class TouchTrackControl : TouchControl
	{
		[SerializeField]
		private TouchUnitType areaUnitType;

		[SerializeField]
		private Rect activeArea;

		public AnalogTarget target;

		public float scale;

		public ButtonTarget tapTarget;

		public float maxTapDuration;

		public float maxTapMovement;

		private Rect worldActiveArea;

		private Vector3 lastPosition;

		private Vector3 thisPosition;

		private Touch currentTouch;

		private bool dirty;

		private bool fireButtonTarget;

		private float beganTime;

		private Vector3 beganPosition;

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

		private void OnValidate()
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
