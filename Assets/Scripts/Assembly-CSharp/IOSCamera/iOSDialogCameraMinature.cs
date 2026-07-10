using UnityEngine;

namespace IOSCamera
{
	public class iOSDialogCameraMinature : MonoBehaviour
	{
		[SerializeField]
		private iOSZoomController zoomController;

		[SerializeField]
		private Camera cameraReference;

		private const float baseYValue = 1f;

		private const float minatureYValue = -4.9f;

		private bool isDialogCameraMinatureIsActive;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void DebugMinimalizeCamera()
		{
		}

		public void ActivateMinatureCamera()
		{
		}

		public void DeactivateMinatureCamera()
		{
		}
	}
}
