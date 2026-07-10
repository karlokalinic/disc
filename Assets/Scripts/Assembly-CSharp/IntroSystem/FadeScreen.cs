using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace IntroSystem
{
	public class FadeScreen : MonoBehaviour
	{
		private bool skipping;

		private IEnumerator currentFadeCoroutine;

		private Image fadeImage;

		private Color nonTransparentColor;

		private Color transparentColor;

		private Color halfTransparentColor;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SkipFade()
		{
		}

		public IEnumerator Fade(bool fadeIn, float fadeDuration)
		{
			return null;
		}

		public void ShowFadeScreen()
		{
		}

		public void HideFadeScreen()
		{
		}
	}
}
