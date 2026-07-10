using UnityEngine;

namespace Sunshine
{
	public class CameraStartFrom : CameraSettings
	{
		[SerializeField]
		protected Vector3 worldPosition;

		[SerializeField]
		protected string luaCondition;

		[SerializeField]
		protected string luaInstruction;

		public void TryActivateCameraPan()
		{
		}

		public void SetCameraControllerValues()
		{
		}

		public void TryActivateCameraPans()
		{
		}
	}
}
