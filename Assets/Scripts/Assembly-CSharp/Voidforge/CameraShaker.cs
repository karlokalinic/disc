using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class CameraShaker : SingletonComponent<CameraShaker>
	{
		[SerializeField]
		protected float rpm;

		[SerializeField]
		protected float maxAngle;

		[SerializeField]
		protected Camera[] cameras;

		protected List<Quaternion> cameraRotations;

		protected float duration;

		protected float timer;

		protected Quaternion ShakerRotation => default(Quaternion);

		public static void Shake(float time)
		{
		}

		[NormalUpdate]
		protected void OnTimer(float deltaTime)
		{
		}
	}
}
