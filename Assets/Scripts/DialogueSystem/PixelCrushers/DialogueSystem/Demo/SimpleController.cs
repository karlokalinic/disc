using UnityEngine;

namespace PixelCrushers.DialogueSystem.Demo
{
	public class SimpleController : MonoBehaviour
	{
		public string forwardSpeedFloatParameter;

		public string lateralSpeedFloatParameter;

		public string twoHandWeaponBoolParameter;

		public string attackTriggerParameter;

		public float runSpeed;

		public float mouseSensitivityX;

		public float mouseSensitivityY;

		public float mouseMinimumY;

		public float mouseMaximumY;

		public bool useTwoHandWeapon;

		public float hitDelay;

		public AudioClip attackSound;

		public float hitDistance;

		public LayerMask hitLayerMask;

		public string damageMessage;

		public float weaponDamage;

		public string horizontalAxis;

		public string verticalAxis;

		public string mouseXAxis;

		public string mouseYAxis;

		public string attackButton;

		private CharacterController m_controller;

		private SmoothCameraWithBumper m_smoothCamera;

		private Animator m_animator;

		private float m_cameraRotationY;

		private Quaternion m_originalCameraRotation;

		private bool m_firing;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnFired()
		{
		}

		private void SetSpeed(float forwardSpeed, float lateralSpeed)
		{
		}

		private void OnConversationStart(Transform actor)
		{
		}

		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}
	}
}
