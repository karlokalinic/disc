using System;
using UnityEngine;
using UnityEngine.Events;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		public class Arm : BodyPart
		{
			[Serializable]
			public enum ShoulderRotationMode
			{
				YawPitch = 0,
				FromTo = 1
			}

			public Transform target;

			public Transform bendGoal;

			public float positionWeight;

			public float rotationWeight;

			public ShoulderRotationMode shoulderRotationMode;

			public float shoulderRotationWeight;

			public float bendGoalWeight;

			public float swivelOffset;

			public Vector3 wristToPalmAxis;

			public Vector3 palmToThumbAxis;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[HideInInspector]
			public Vector3 handPositionOffset;

			private bool hasShoulder;

			private Vector3 chestForwardAxis;

			private Vector3 chestUpAxis;

			private Quaternion chestRotation;

			private Vector3 chestForward;

			private Vector3 chestUp;

			private Quaternion forearmRelToUpperArm;

			private const float yawOffsetAngle = 45f;

			private const float pitchOffsetAngle = -30f;

			public Vector3 position { get; private set; }

			public Quaternion rotation { get; private set; }

			private VirtualBone shoulder => null;

			private VirtualBone upperArm => null;

			private VirtualBone forearm => null;

			private VirtualBone hand => null;

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			public override void PreSolve()
			{
			}

			public override void ApplyOffsets()
			{
			}

			public void Solve(bool isLeft)
			{
			}

			public override void ResetOffsets()
			{
			}

			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return 0f;
			}

			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}
		}

		[Serializable]
		public abstract class BodyPart
		{
			[HideInInspector]
			public VirtualBone[] bones;

			protected bool initiated;

			protected Vector3 rootPosition;

			protected Quaternion rootRotation;

			protected int index;

			public float sqrMag { get; private set; }

			public float mag { get; private set; }

			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			public abstract void PreSolve();

			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			public abstract void ApplyOffsets();

			public abstract void ResetOffsets();

			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			public void MovePosition(Vector3 position)
			{
			}

			public void MoveRotation(Quaternion rotation)
			{
			}

			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			public void Visualize(Color color)
			{
			}

			public void Visualize()
			{
			}
		}

		[Serializable]
		public class Footstep
		{
			public float stepSpeed;

			public Vector3 characterSpaceOffset;

			public Vector3 position;

			public Quaternion rotation;

			public Quaternion stepToRootRot;

			public bool isSupportLeg;

			public Vector3 stepFrom;

			public Vector3 stepTo;

			public Quaternion stepFromRot;

			public Quaternion stepToRot;

			private Quaternion footRelativeToRoot;

			private float supportLegW;

			private float supportLegWV;

			public bool isStepping => false;

			public float stepProgress { get; private set; }

			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		public class Leg : BodyPart
		{
			public Transform target;

			public Transform bendGoal;

			public float positionWeight;

			public float rotationWeight;

			public float bendGoalWeight;

			public float swivelOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public float currentMag;

			private Vector3 footPosition;

			private Quaternion footRotation;

			private Vector3 bendNormal;

			private Quaternion calfRelToThigh;

			public Vector3 position { get; private set; }

			public Quaternion rotation { get; private set; }

			public bool hasToes { get; private set; }

			public VirtualBone thigh => null;

			private VirtualBone calf => null;

			private VirtualBone foot => null;

			private VirtualBone toes => null;

			public VirtualBone lastBone => null;

			public Vector3 thighRelativeToPelvis { get; private set; }

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			public override void PreSolve()
			{
			}

			public override void ApplyOffsets()
			{
			}

			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			public void Solve()
			{
			}

			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			public override void ResetOffsets()
			{
			}
		}

		[Serializable]
		public class Locomotion
		{
			public float weight;

			public float footDistance;

			public float stepThreshold;

			public float angleThreshold;

			public float comAngleMlp;

			public float maxVelocity;

			public float velocityFactor;

			public float maxLegStretch;

			public float rootSpeed;

			public float stepSpeed;

			public AnimationCurve stepHeight;

			public AnimationCurve heelHeight;

			public float relaxLegTwistMinAngle;

			public float relaxLegTwistSpeed;

			public InterpolationMode stepInterpolation;

			public Vector3 offset;

			[HideInInspector]
			public bool blockingEnabled;

			[HideInInspector]
			public LayerMask blockingLayers;

			[HideInInspector]
			public float raycastRadius;

			[HideInInspector]
			public float raycastHeight;

			public UnityEvent onLeftFootstep;

			public UnityEvent onRightFootstep;

			private Footstep[] footsteps;

			private Vector3 lastComPosition;

			private Vector3 comVelocity;

			private int leftFootIndex;

			private int rightFootIndex;

			public Vector3 centerOfMass { get; private set; }

			public Vector3 leftFootstepPosition => default(Vector3);

			public Vector3 rightFootstepPosition => default(Vector3);

			public Quaternion leftFootstepRotation => default(Quaternion);

			public Quaternion rightFootstepRotation => default(Quaternion);

			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			public void AddDeltaPosition(Vector3 delta)
			{
			}

			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
				leftFootPosition = default(Vector3);
				rightFootPosition = default(Vector3);
				leftFootRotation = default(Quaternion);
				rightFootRotation = default(Quaternion);
				leftFootOffset = default(float);
				rightFootOffset = default(float);
				leftHeelOffset = default(float);
				rightHeelOffset = default(float);
			}

			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return false;
			}

			private bool CanStep()
			{
				return false;
			}

			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return false;
			}
		}

		[Serializable]
		public class Spine : BodyPart
		{
			public Transform headTarget;

			public Transform pelvisTarget;

			public float positionWeight;

			public float rotationWeight;

			public float pelvisPositionWeight;

			public float pelvisRotationWeight;

			public Transform chestGoal;

			public float chestGoalWeight;

			public float minHeadHeight;

			public float bodyPosStiffness;

			public float bodyRotStiffness;

			public float neckStiffness;

			public float chestClampWeight;

			public float headClampWeight;

			public float maintainPelvisPosition;

			public float maxRootAngle;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[HideInInspector]
			public Vector3 headPosition;

			private Quaternion headRotation;

			private Quaternion anchorRelativeToHead;

			private Quaternion pelvisRelativeRotation;

			private Quaternion chestRelativeRotation;

			private Vector3 headDeltaPosition;

			private Quaternion pelvisDeltaRotation;

			private Quaternion chestTargetRotation;

			private int pelvisIndex;

			private int spineIndex;

			private int chestIndex;

			private int neckIndex;

			private int headIndex;

			private float length;

			private bool hasChest;

			private bool hasNeck;

			private float headHeight;

			private float sizeMlp;

			private Vector3 chestForward;

			public VirtualBone pelvis => null;

			public VirtualBone firstSpineBone => null;

			public VirtualBone chest => null;

			private VirtualBone neck => null;

			public VirtualBone head => null;

			public Quaternion anchorRotation { get; private set; }

			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			public override void PreSolve()
			{
			}

			public override void ApplyOffsets()
			{
			}

			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			private void SolvePelvis()
			{
			}

			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			public override void ResetOffsets()
			{
			}

			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}
		}

		[Serializable]
		public enum PositionOffset
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2,
			LeftHand = 3,
			RightHand = 4,
			LeftFoot = 5,
			RightFoot = 6,
			LeftHeel = 7,
			RightHeel = 8
		}

		[Serializable]
		public enum RotationOffset
		{
			Pelvis = 0,
			Chest = 1,
			Head = 2
		}

		[Serializable]
		public class VirtualBone
		{
			public Vector3 readPosition;

			public Quaternion readRotation;

			public Vector3 solverPosition;

			public Quaternion solverRotation;

			public float length;

			public float sqrMag;

			public Vector3 axis;

			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			public static float PreSolve(ref VirtualBone[] bones)
			{
				return 0f;
			}

			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length)
			{
			}

			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		private Transform[] solverTransforms;

		private bool hasChest;

		private bool hasNeck;

		private bool hasShoulders;

		private bool hasToes;

		private Vector3[] readPositions;

		private Quaternion[] readRotations;

		private Vector3[] solvedPositions;

		private Quaternion[] solvedRotations;

		private Vector3 defaultPelvisLocalPosition;

		private Quaternion[] defaultLocalRotations;

		private Vector3 rootV;

		private Vector3 rootVelocity;

		private Vector3 bodyOffset;

		private int supportLegIndex;

		public bool plantFeet;

		public Spine spine;

		public Arm leftArm;

		public Arm rightArm;

		public Leg leftLeg;

		public Leg rightLeg;

		public Locomotion locomotion;

		private Leg[] legs;

		private Arm[] arms;

		private Vector3 headPosition;

		private Vector3 headDeltaPosition;

		private Vector3 raycastOriginPelvis;

		private Vector3 lastOffset;

		private Vector3 debugPos1;

		private Vector3 debugPos2;

		private Vector3 debugPos3;

		private Vector3 debugPos4;

		[HideInInspector]
		public VirtualBone rootBone { get; private set; }

		public void SetToReferences(VRIK.References references)
		{
		}

		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		public void DefaultAnimationCurves()
		{
		}

		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		public void Reset()
		{
		}

		public override void StoreDefaultLocalState()
		{
		}

		public override void FixTransforms()
		{
		}

		public override Point[] GetPoints()
		{
			return null;
		}

		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		public override bool IsValid(ref string message)
		{
			return false;
		}

		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		private void UpdateSolverTransforms()
		{
		}

		protected override void OnInitiate()
		{
		}

		protected override void OnUpdate()
		{
		}

		private void WriteTransforms()
		{
		}

		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		private void Solve()
		{
		}

		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		private void Write()
		{
		}

		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}
	}
}
