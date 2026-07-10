using System.Collections;
using TMPro;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProBarkUIFader : MonoBehaviour
	{
		public float fadeInDuration;

		public float fadeOutDuration;

		private Color originalColor;

		public void Start()
		{
		}

		public void OnShowedBark(TextMeshProBarkUI barkUI)
		{
		}

		public void OnHidBark(TextMeshProBarkUI barkUI)
		{
		}

		private IEnumerator FadeIn(TextMeshPro textMeshPro)
		{
			return null;
		}

		private IEnumerator FadeOut(TextMeshPro textMeshPro)
		{
			return null;
		}
	}
}
