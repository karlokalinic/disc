using UnityEngine;

namespace LocalizationCustomSystem
{
	public class LocalizeRectTransformSize : MonoBehaviour
	{
		[SerializeField]
		private TranslationFloat localizedWidth;

		[SerializeField]
		private TranslationFloat localizedHeight;

		private RectTransform rectTransform;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateRectSize()
		{
		}
	}
}
