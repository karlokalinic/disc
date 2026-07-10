using UnityEngine;

namespace CollageMode
{
	public class ZoomToAlphaChanger : MonoBehaviour
	{
		[SerializeField]
		private FadeController fadeController;

		[SerializeField]
		private float minimalAlpha;

		[SerializeField]
		private float maxVisibleZoomDifference;

		[SerializeField]
		private HiddenImage hiddenImage;

		private float minZoom;

		private float maxZoom;

		private void Reset()
		{
		}

		public void SetTargetZoom(float minZoom, float maxZoom)
		{
		}

		private void Awake()
		{
		}

		private void OnZoomChanged()
		{
		}

		private void Update()
		{
		}
	}
}
