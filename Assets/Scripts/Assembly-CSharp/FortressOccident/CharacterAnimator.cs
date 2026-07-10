using System.Collections;
using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class CharacterAnimator : VoidElement
	{
		public enum Variables
		{
			SPEED = 0,
			ANGULAR_SPEED = 1,
			COUNT = 2
		}

		private const int LAYER_SWORD_L = 1;

		private const int LAYER_PLASTIC_BAG_L = 2;

		private const int LAYER_FLASHLIGHT_L = 4;

		private const int LAYER_BOOMBOX_L = 5;

		private const int LAYER_GUN_L = 6;

		private const int LAYER_ALCOHOL_L = 7;

		private const int LAYER_PYRHOLIDON_L = 8;

		private const int LAYER_FOLDER_L = 9;

		private const int LAYER_FOLDER_R = 10;

		private const int LAYER_SWORD_R = 11;

		private const int LAYER_PLASTIC_BAG_R = 12;

		private const int LAYER_FLASHLIGHT_R = 13;

		private const int LAYER_BOOMBOX_R = 14;

		private const int LAYER_GUN_R = 15;

		private const int LAYER_ALCOHOL_R = 16;

		private const int LAYER_PYRHOLIDON_R = 17;

		private const float FOOTSTEP_DETECTION_DELAY = 0.2f;

		[SerializeField]
		protected float animatorSpeedCutoff;

		[SerializeField]
		protected string speedParameter;

		[SerializeField]
		protected string angularSpeedParameter;

		protected int[] cachedNameHashes;

		[GetComponent]
		protected ComponentRef<Animator> animator;

		[GetComponent]
		protected ComponentRef<Character> character;

		protected Transform _leftFootBone;

		protected Transform _rightFootBone;

		protected Vector3? _leftFootPosition;

		protected Vector3? _rightFootPosition;

		protected Vector3 _leftFootOffset;

		protected Vector3 _rightFootOffset;

		protected AnimationType rightHandAnimType;

		protected AnimationType leftHandAnimType;

		protected Vector3 _desiredVelocity;

		private float footstepTime;

		protected float currentHeading => 0f;

		protected float desiredHeading => 0f;

		protected Vector3 desiredVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		protected bool isMoving => false;

		protected int hash(Variables v)
		{
			return 0;
		}

		protected IEnumerator Start()
		{
			return null;
		}

		protected override void Awake()
		{
		}

		protected void FixedUpdate()
		{
		}

		protected void OnAnimatorMove()
		{
		}

		protected void OnAnimatorIK(int layerIndex)
		{
		}

		protected void OnLeftFootDown(AnimationEvent e)
		{
		}

		protected void OnRightFootDown(AnimationEvent e)
		{
		}

		public void PlayLeftHandAnimation(AnimationType animType)
		{
		}

		public void PlayRightHandAnimation(AnimationType animType)
		{
		}

		public void StopLeftHandAnimation()
		{
		}

		public void StopRightHandAnimation()
		{
		}

		public void DisableHeldAnimationLayer()
		{
		}

		public void DisableHeldAnimationLayerTween(float duration)
		{
		}

		public void RestoreHeldAnimationLayer()
		{
		}

		public void RestoreHeldAnimationLayerTween(float duration)
		{
		}

		public static IEnumerator SetLayerWeight(Animator anim, float duration, int layerIndex, float endWeight)
		{
			return null;
		}

		private void SetupHands()
		{
		}

		private void OnEnable()
		{
		}

		private IEnumerator WaitForAnimatorThenHands()
		{
			return null;
		}

		private int GetLeftHandLayerIndex(AnimationType type)
		{
			return 0;
		}

		private int GetRightHandLayerIndex(AnimationType type)
		{
			return 0;
		}

		protected void OnLeftFootUp()
		{
		}

		protected void OnRightFootUp()
		{
		}
	}
}
