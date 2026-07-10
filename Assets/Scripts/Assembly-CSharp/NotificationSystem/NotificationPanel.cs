using System;
using System.Collections;
using LocalizationCustomSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NotificationSystem
{
	public class NotificationPanel : MonoBehaviour
	{
		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private Image _blurIconImage;

		[SerializeField]
		private Image _leftSecondaryIconImage;

		[SerializeField]
		private Image _leftSecondaryIconBlurImage;

		[SerializeField]
		private Image _rightSecondaryIconImage;

		[SerializeField]
		private Image _rightSecondaryIconBlurImage;

		[SerializeField]
		private TextMeshProUGUI _headerText;

		[SerializeField]
		private TextMeshProUGUI _headerTextShadow;

		[SerializeField]
		private Image _headerLabel;

		[SerializeField]
		private TextMeshProUGUI _descriptionText;

		[SerializeField]
		private TextMeshProUGUI _descriptionTextShadow;

		[SerializeField]
		private Image _descriptionLabel;

		[SerializeField]
		private Image _backgroundEffectImage;

		[SerializeField]
		private Material _labelsMaterial;

		[SerializeField]
		private TranslationString _textsMaterialTerm;

		[SerializeField]
		private Material _flashEffectMaterial;

		[SerializeField]
		private RectTransform _slidingContentRect;

		private Material _textsMaterial;

		private Material _submeshMaterial;

		private Action _onStartShowing;

		private Action<float> _onShowing;

		private Action _onShowed;

		private Action _onStartHiding;

		private Action<float> _onHiding;

		private Action _onHidden;

		private Action _onAnimationEnd;

		private Notification _currentNotification;

		private bool _waiting;

		private float fadeAlpha;

		private float startPosition;

		private float endPosition;

		private float direction;

		private Vector3 bottomLeft;

		private Vector3 topRight;

		private RectTransform refLabel;

		private Coroutine _animation;

		private TMP_SubMeshUI _descriptionSubmesh;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void UpdateTextMaterial()
		{
		}

		private void UpdateSubmeshesText()
		{
		}

		public void Start()
		{
		}

		public Action PlayNotification(Notification notification, Action onAnimationEnd)
		{
			return null;
		}

		public void ForceStopCurrentlyShownNotification()
		{
		}

		private void PlaySound(Notification notification)
		{
		}

		private void SetMaterials()
		{
		}

		private void UnplugEvents()
		{
		}

		private void PlugEvents()
		{
		}

		public void UpdateTexts(Notification notification)
		{
		}

		private void PrepareUIElements(Notification notification)
		{
		}

		private void ResetUIElementsAlpha()
		{
		}

		private void CenterSlidingContent()
		{
		}

		private IEnumerator AnimationCoroutine()
		{
			return null;
		}

		private float EaseInOut(float t)
		{
			return 0f;
		}

		public void StopWaiting()
		{
		}

		private void UpdateWorldCorners()
		{
		}

		private void SetStartValuesForAlphaHideMaterial()
		{
		}

		private void UpdateValuesForMaterials(float time)
		{
		}

		private void UpdatePrimaryIconsAlpha(float time)
		{
		}

		private void UpdateSecondaryIconsAlpha(float time)
		{
		}

		private void UpdateAlphaForFlashScreen(float time)
		{
		}

		private void UpdateSlidingContentPos(float time)
		{
		}

		private void SetFullAlphaForMaterials()
		{
		}

		private void SetNullAlphaForMaterials()
		{
		}

		private void CheckAndSetHiddingDirection()
		{
		}
	}
}
