using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class FeldController : MonoBehaviour
	{
		private static FeldController _instance;

		public Camera feldCamera;

		public GameObject feldBlend;

		public RuntimeAnimatorController feldAnimatorController;

		public RuntimeAnimatorController feldAnimatorControllerUltrawide;

		private GameObject feldGeometry;

		public static Animator feldAnimator;

		public FeldBase[] feldRightPieces;

		public FeldBase[] feldContainerPieces;

		public FeldBase[] feldHUDPieces;

		[HideInInspector]
		public TweenAlpha feldTweenAlpha;

		public GameObject introBlend;

		public RuntimeAnimatorController introAnimatorController;

		private GameObject introFeldGeometry;

		public static Animator introFeldAnimator;

		public GameObject feldContainer;

		public GameObject feldHUD;

		public GameObject feldClock;

		public AnimationCurve rollAnimation;

		public AnimationCurve moveAnimation;

		public float rollLength;

		public AnimationCurve stopAnimation;

		public AnimationCurve flashAnimation;

		public float flashDuration;

		public Color successFlashColor;

		public Color failFlashColor;

		private float flashStartTime;

		[HideInInspector]
		public bool feldFlashes;

		public static FeldController instance => null;

		private FeldController()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void ChangePartySize()
		{
		}

		public void UpdateAspectRatio(Aspect aspect)
		{
		}

		public void SetWide()
		{
		}

		public void SetUltrawide()
		{
		}

		private void Update()
		{
		}

		private void rolltest()
		{
		}

		private void anitest()
		{
		}

		public void Roll(float length = 1.07f)
		{
		}

		public void AnimateDialog(float amount = 1f, float time = 0.2f)
		{
		}

		public void MoveDialog(float amount = 1f)
		{
		}

		public void AnimateContainer(float amount = 1f, float time = 0.2f)
		{
		}

		public void MoveContainer(float amount = 1f)
		{
		}

		public void FlashWhite()
		{
		}

		public void FlashRed()
		{
		}

		public void AnimateHUD(float amount = 1f, float time = 0.2f)
		{
		}

		public void Flash(Color col, float amount = 1f)
		{
		}

		public void WigglePortrait()
		{
		}

		private void FlashUpdate()
		{
		}

		public void HudVisible(bool visible)
		{
		}

		public void ClockVisible(bool visible)
		{
		}

		public void RightVisible(bool visible)
		{
		}
	}
}
