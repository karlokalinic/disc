using UnityEngine;

namespace CollageMode
{
	public class CollageCharacter : CollageElement
	{
		public new class InitData : CollageElement.InitData
		{
			public Vector3 Position;

			public float Rotation;

			public float Scale;

			public string PoseIdentifier;
		}

		private const string DEFAULT_ANIMATION_NAME = "Idle";

		private const string ACTORS_TERM_PREFIX = "Actors/";

		[SerializeField]
		private float smoothFactor;

		[SerializeField]
		private bool useFreePlacement;

		[SerializeField]
		private float rotationSpeed;

		[SerializeField]
		private Transform content;

		[SerializeField]
		private Transform character;

		[SerializeField]
		private string characterNameTerm;

		[SerializeField]
		private bool allowAllPoses;

		[SerializeField]
		private ChangePoseOperation[] allowedPoses;

		[SerializeField]
		private ChangePoseOperation[] forbiddenPoses;

		[SerializeField]
		private bool isMinor;

		private Vector3 lastScreenSpacePosition;

		private Vector3 navMeshPlacementPosition;

		private Vector3 placementPosition;

		private Vector3 smoothedPlacementPosition;

		private CollageCharacter characterPrefab;

		private AnimatorOverrideController animatorOverrideController;

		private string defaultPoseIdentifier;

		private string poseIdentifier;

		private Outline outline;

		public string PoseIdentifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override float Rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override string DisplayTerm => null;

		public bool AllowAllPoses => false;

		public ChangePoseOperation[] AllowedPoses => null;

		public ChangePoseOperation[] ForbiddenPoses => null;

		public bool IsMinor => false;

		protected override void Awake()
		{
		}

		public override void Init(CollageElement.InitData initData)
		{
		}

		public override CollageElement.InitData GetInitData()
		{
			return null;
		}

		protected override void Update()
		{
		}

		public void SetPreview(bool isPreview)
		{
		}

		protected override void InitialPlacementSubmitted()
		{
		}

		protected override void MoveStarted()
		{
		}

		protected override void MoveSubmitted()
		{
		}

		protected override void RotateSubmitted()
		{
		}

		protected override Vector3 GetMousePlacementPosition()
		{
			return default(Vector3);
		}

		protected override Vector3 GetGamepadPlacementPosition()
		{
			return default(Vector3);
		}

		protected override void SetHidden(bool isHidden)
		{
		}

		protected override Vector3 ScreenToTargetPosition(Vector3 targetScreenSpacePosition)
		{
			return default(Vector3);
		}

		protected override void RefreshSelectionVisual(bool isSelected)
		{
		}

		public override void ResetAll()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
