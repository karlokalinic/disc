using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using Sunshine.Views;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	[Persistent]
	public class GameController : SingletonComponent<GameController>, ICursorSource
	{
		[SerializeField]
		private CursorType movementCursor;

		[SerializeField]
		private CursorType noActionCursor;

		[SerializeField]
		public CursorType hideCursor;

		[SerializeField]
		private GameObject destinationMarker;

		[SerializeField]
		private TweenShaderProperty destinationMarkerAlpha;

		[SerializeField]
		private Animator destinationMarkerAnimator;

		[SerializeField]
		private float minMouseHoldDistance;

		public bool isTeleporting;

		public bool cursorHidden;

		public bool isNarrowEnvironment;

		private uint clickCount;

		private Vector3 _destination;

		public Tween _destinationMarkerTween;

		private Component _target;

		private Vector3 _targetVector;

		private object _currentTarget;

		private bool _isMoving;

		public MovementCommand _movementCommand;

		protected ComponentRef<NavMeshPathTag> _navPathTag;

		private bool genericFlag;

		public bool EnvironmentTriggerActive;

		private bool worldInputDisabled;

		private List<object> inputLocks;

		public MovementMode currentMovementMode;

		public bool canMove => false;

		public Vector3 destination
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool isMoving
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private Party party => null;

		private CursorType currentCursor => null;

		Vector2 ICursorSource.hotspot => default(Vector2);

		Texture2D ICursorSource.texture => null;

		public void ClearAllInputLocks()
		{
		}

		public bool HasInputLock(object locker)
		{
			return false;
		}

		public void AddInputLock(object locker)
		{
		}

		public void RemoveInputLock(object locker)
		{
		}

		public bool IsWorldInputDisabled()
		{
			return false;
		}

		public bool MoveToTarget(object target, MovementMode movementMode = MovementMode.AUTOMATIC, Formation.Purpose movementPurpose = Formation.Purpose.UNIVERSAL, bool calculateFinalHeading = true, bool predefinedSectorPos = false)
		{
			return false;
		}

		public void ValidateMovement(Formation target)
		{
		}

		private IEnumerator Validate(Formation to)
		{
			return null;
		}

		public void CancelPartyMemberMovement()
		{
		}

		public void CancelPartyMovement()
		{
		}

		public void Update()
		{
		}

		private void ResetClickCount()
		{
		}

		public bool TryMoveToTarget()
		{
			return false;
		}

		public void StopMovement(bool force = false)
		{
		}

		private void SlaveCamera()
		{
		}

		private bool OnMouseClick(int clickCount)
		{
			return false;
		}

		private bool OnMouseHold()
		{
			return false;
		}

		public void ForceTequilaCompleteMovement()
		{
		}

		public void OnPhotoMode(bool enabled)
		{
		}

		private void OnCharacterHasArrived(Character character, bool wasDestinationReached)
		{
		}

		private void OnAreaReady()
		{
		}

		public void OnAreaNotReady()
		{
		}

		private void OnCameraLocked(CameraController cc)
		{
		}

		private void OnInputPointerPosition()
		{
		}

		private void OnMovementStopped()
		{
		}

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void StopMovementForViewChange(ViewType nextView)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
