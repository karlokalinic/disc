using System.Collections;
using UnityEngine;

namespace LocalizationCustomSystem
{
	public class SmoothLanguageSwitch : MonoBehaviour
	{
		private const string GlobalTransitionParameter = "GLOBAL_TRANSITION_ALPHA";

		[SerializeField]
		private float fadeOutTime;

		[SerializeField]
		private AnimationCurve fadeOutCurve;

		[SerializeField]
		private float fadeInTime;

		[SerializeField]
		private AnimationCurve fadeInCurve;

		[SerializeField]
		private bool snapToggle;

		private bool isChangingLanguage;

		private float transitionAlpha;

		private IEnumerator languageChangeCoroutine;

		private void OnLanguageChangedInOptions()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public bool CanSwitchLanguage()
		{
			return false;
		}

		private void ToggleLanguage(bool snapToggle)
		{
		}

		public void StartSmoothLanguageChange(string nextLanguageName)
		{
		}

		private IEnumerator SmoothLanguageChange(string languageName)
		{
			return null;
		}

		private void SetTextMaterialProperty(float alpha)
		{
		}
	}
}
