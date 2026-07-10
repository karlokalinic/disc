using FortressOccident;
using UnityEngine;

namespace IOSCamera
{
	public class iOSCameraPositionController : MonoBehaviour
	{
		private static readonly Vector2 maxZoomScreenPosition;

		private static readonly Vector2 minZoomScreenPosition;

		[SerializeField]
		private ScreenPointToRay screenPointToRay;

		private Character characterToFollow;

		private float cachedNormalizedZoomValue;

		private bool attachedToCharacter;

		private Vector3 targetPosition;

		public void OnLateUpdate(Vector3 position)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void SetTarget(Character followTarget)
		{
		}

		public void OnZoomValueChanged(float newNormalizedZoomValue)
		{
		}

		public void FocusOnTarget(Vector3 newPosition, float? newZoomFactor, bool instant)
		{
		}

		public void AttachToCharacter()
		{
		}

		public void DetachFromCharacter()
		{
		}

		public Vector3 GetCameraFocus()
		{
			return default(Vector3);
		}

		public void SetPosition(Vector3 newPosition)
		{
		}

		public Vector3 GetTargetPosition(float zoom01)
		{
			return default(Vector3);
		}
	}
}
