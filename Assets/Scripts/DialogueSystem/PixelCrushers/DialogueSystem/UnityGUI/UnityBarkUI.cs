using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class UnityBarkUI : AbstractBarkUI
	{
		public Transform textPosition;

		public GUISkin guiSkin;

		public string guiStyleName;

		public bool includeName;

		public float duration;

		public float fadeDuration;

		public TextStyle textStyle;

		public Color textStyleColor;

		public BarkSubtitleSetting textDisplaySetting;

		public bool waitUntilSequenceEnds;

		public bool checkIfPlayerVisible;

		public LayerMask visibilityLayerMask;

		protected UnityBarkUIOnGUI unityBarkUIOnGUI;

		protected Transform playerCameraTransform;

		protected Collider playerCameraCollider;

		protected float secondsLeft;

		public bool showText => false;

		public override bool isPlaying => false;

		public virtual void Awake()
		{
		}

		public virtual void OnDestroy()
		{
		}

		protected void CheckUnityBarkUIOnGUI()
		{
		}

		public override void Bark(Subtitle subtitle)
		{
		}

		public virtual void Update()
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public override void Hide()
		{
		}

		protected void CheckPlayerVisibility()
		{
		}

		protected void CheckPlayerCameraTransform()
		{
		}
	}
}
