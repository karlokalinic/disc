using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Sunshine;
using Sunshine.Unseen;
using UnityEngine;
using UnityEngine.AI;
using Voidforge;

namespace FortressOccident
{
	public class Character : BasicEntity, IVitruvianHandler
	{
		public enum MovementStatus
		{
			IDLE = 0,
			MOVING = 1,
			ADJUSTING = 2,
			BROKEN = 3,
			COMPLETED = 4
		}

		private struct VitruvianItem
		{
			public int index;

			public CharacterItem item;

			public VitruvianItem(CharacterItem item)
			{
				index = 0;
				this.item = null;
			}
		}

		public MovementMode movementMode;

		public Transform rootBone;

		public Transform headBone;

		public Transform rightHandBone;

		public Transform leftHandBone;

		public MovementValidation movementValidator;

		public NavMeshObstacle navMeshObstacle;

		public bool movementCommandLock;

		public bool enableMovementOnEnable;

		public int _rotationLock;

		public float? _idleHeading;

		public bool preventResetAtEndOfConversation;

		[GetComponent]
		public ComponentRef<Observer> observer;

		private Animator animatorComponent;

		[SerializeField]
		private GameObject selectionMarker;

		[SerializeField]
		protected bool _isSelected;

		[SerializeField]
		[HideInInspector]
		protected SkinnedMeshRenderer _bodyRenderer;

		[SerializeField]
		[HideInInspector]
		protected VitruvianManager _vitruvian;

		[SerializeField]
		[HideInInspector]
		protected bool _isVitruvianSet;

		[SerializeField]
		protected bool noShadow;

		[SerializeField]
		protected bool isGhost;

		[SerializeField]
		protected int highlightStencilLayer;

		[SerializeField]
		private Transform inventoryCameraTarget;

		[SerializeField]
		private Vector3 offset;

		private static readonly int alphaMultiply;

		private MovementStatus _movementStatus;

		private GameObject obstacle;

		private BarkOnClick barkOnClick;

		[GetComponent]
		private ComponentRef<Party> myParty;

		private CharacterNavigator[] navigator;

		private AnimDice[] dice;

		private Animator anim;

		public SkinnedMeshRenderer bodyRenderer
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Animator AnimatorComponent => null;

		public static Character Main => null;

		public MovementMode activeMovementMode { get; private set; }

		public Vector3 desiredVelocity => default(Vector3);

		public CharacterNavigator characterNavigator => null;

		public float idleHeading
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool rotationLock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float height => 0f;

		public bool isSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isVitruvianSet { get; set; }

		public bool IsDestinationSetBySequence { get; set; }

		public MovementStatus movementStatus
		{
			get
			{
				return default(MovementStatus);
			}
			set
			{
			}
		}

		public Vector3 inventoryCamPosition => default(Vector3);

		public Vector3 position => default(Vector3);

		public Vector3 navelPosition => default(Vector3);

		public Vector3 rootAbovePosition => default(Vector3);

		public VitruvianManager vitruvian => null;

		public override bool IsAccessible => false;

		private Party party => null;

		private bool isHeadingRightWay => false;

		public AnimDice[] Dice => null;

		public event Action<Character, bool> HasArrivedEvent
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

		protected override void OnAwakeInitialized()
		{
		}

		protected override void OnSceneDeactivated()
		{
		}

		protected void LateUpdate()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnEnable()
		{
		}

		public void SetDestination(Vector3 newPosition, float? newHeading, MovementMode mode, bool forceIfFail = false)
		{
		}

		public SkinnedMeshRenderer FindBodyRenderer()
		{
			return null;
		}

		public void SetPosition(Vector3 worldPos, float heading)
		{
		}

		public void ApplyVitruvianLayers()
		{
		}

		public void EnableCharacterMovement()
		{
		}

		public IEnumerator EnableCharacterMovementCoroutine()
		{
			return null;
		}

		public void DisableCharacterMovement()
		{
		}

		public void ToggleFlashlightIK(bool isEnabled)
		{
		}

		public void FadeRightHandItem(float fadeStart, float fadeEnd)
		{
		}

		public void FadeLeftHandItem(float fadeStart, float fadeEnd)
		{
		}

		public void SetScaleAndRendererEnabledRightHandItem(ItemBehaviour itemHeld, bool makeEnabled, float duration)
		{
		}

		public void SetScaleAndRendererEnabledLeftHandItem(ItemBehaviour itemHeld, bool makeEnabled, float duration)
		{
		}

		private static void SetScaleAndRenderersEnabledState(ItemBehaviour target, bool makeEnabled, float duration)
		{
		}

		public void ResetAnimatorToPlayerMovement()
		{
		}

		private void DebugLogParty()
		{
		}

		private void CutNPCFromNavmeshAndDisableMovement()
		{
		}

		private IEnumerator TimeBasedFade(Renderer renderer, float fadeStart, float fadeEnd, float time)
		{
			return null;
		}
	}
}
