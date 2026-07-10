using UnityEngine;

namespace InControl
{
	public class TouchSwipeControl : TouchControl
	{
		[SerializeField]
		private TouchUnitType areaUnitType;

		[SerializeField]
		private Rect activeArea;

		public float sensitivity;

		public bool oneSwipePerTouch;

		public AnalogTarget target;

		public SnapAngles snapAngles;

		public ButtonTarget upTarget;

		public ButtonTarget downTarget;

		public ButtonTarget leftTarget;

		public ButtonTarget rightTarget;

		public ButtonTarget tapTarget;

		private Rect worldActiveArea;

		private Vector3 currentVector;

		private bool currentVectorIsSet;

		private Vector3 beganPosition;

		private Vector3 lastPosition;

		private Touch currentTouch;

		private bool fireButtonTarget;

		private ButtonTarget nextButtonTarget;

		private ButtonTarget lastButtonTarget;

		private bool dirty;

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

		private ButtonTarget GetButtonTargetForVector(Vector2 vector)
		{
			return default(ButtonTarget);
		}
	}
}
