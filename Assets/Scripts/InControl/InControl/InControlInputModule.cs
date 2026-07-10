using UnityEngine;
using UnityEngine.EventSystems;

namespace InControl
{
	public class InControlInputModule : PointerInputModule
	{
		public enum Button
		{
			Action1 = 19,
			Action2 = 20,
			Action3 = 21,
			Action4 = 22
		}

		public Button submitButton;

		public Button cancelButton;

		public float analogMoveThreshold;

		public float moveRepeatFirstDuration;

		public float moveRepeatDelayDuration;

		public bool forceModuleActive;

		public bool allowMouseInput;

		public bool focusOnMouseHover;

		public bool allowTouchInput;

		private InputDevice inputDevice;

		private Vector3 thisMousePosition;

		private Vector3 lastMousePosition;

		private Vector2 thisVectorState;

		private Vector2 lastVectorState;

		private bool thisSubmitState;

		private bool lastSubmitState;

		private bool thisCancelState;

		private bool lastCancelState;

		private bool moveWasRepeated;

		private float nextMoveRepeatTime;

		private TwoAxisInputControl direction;

		public PlayerAction SubmitAction { get; set; }

		public PlayerAction CancelAction { get; set; }

		public PlayerTwoAxisAction MoveAction { get; set; }

		public InputDevice Device
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private InputControl SubmitButton => null;

		private InputControl CancelButton => null;

		private bool VectorIsPressed => false;

		private bool VectorIsReleased => false;

		private bool VectorHasChanged => false;

		private bool VectorWasPressed => false;

		private bool SubmitWasPressed => false;

		private bool SubmitWasReleased => false;

		private bool CancelWasPressed => false;

		private bool MouseHasMoved => false;

		private bool MouseButtonIsPressed => false;

		protected InControlInputModule()
		{
		}

		public override void UpdateModule()
		{
		}

		public override bool IsModuleSupported()
		{
			return false;
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		public override void ActivateModule()
		{
		}

		public override void Process()
		{
		}

		private bool ProcessTouchEvents()
		{
			return false;
		}

		private bool SendButtonEventToSelectedObject()
		{
			return false;
		}

		private bool SendVectorEventToSelectedObject()
		{
			return false;
		}

		protected override void ProcessMove(PointerEventData pointerEvent)
		{
		}

		private void Update()
		{
		}

		private void UpdateInputState()
		{
		}

		private void SetVectorRepeatTimer()
		{
		}

		protected bool SendUpdateEventToSelectedObject()
		{
			return false;
		}

		protected void ProcessMouseEvent()
		{
		}

		protected void ProcessMouseEvent(int id)
		{
		}

		protected void ProcessMousePress(MouseButtonEventData data)
		{
		}

		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
		}
	}
}
