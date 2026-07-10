using UnityEngine;

namespace InControl
{
	public class TouchButtonControl : TouchControl
	{
		[SerializeField]
		private TouchControlAnchor anchor;

		[SerializeField]
		private TouchUnitType offsetUnitType;

		[SerializeField]
		private Vector2 offset;

		[SerializeField]
		private bool lockAspectRatio;

		public ButtonTarget target;

		public bool allowSlideToggle;

		public bool toggleOnLeave;

		public bool pressureSensitive;

		public TouchSprite button;

		private bool buttonState;

		private Touch currentTouch;

		private bool dirty;

		private bool ButtonState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 ButtonPosition
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
