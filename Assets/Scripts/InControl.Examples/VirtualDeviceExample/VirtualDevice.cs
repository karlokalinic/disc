using InControl;
using UnityEngine;

namespace VirtualDeviceExample
{
	public class VirtualDevice : InputDevice
	{
		private const float Sensitivity = 0.1f;

		private const float MouseScale = 0.05f;

		private float kx;

		private float ky;

		private float mx;

		private float my;

		public override void Update(ulong updateTick, float deltaTime)
		{
		}

		private Vector2 GetVectorFromKeyboard(float deltaTime, bool smoothed)
		{
			return default(Vector2);
		}

		private static float GetXFromKeyboard()
		{
			return 0f;
		}

		private static float GetYFromKeyboard()
		{
			return 0f;
		}

		private Vector2 GetVectorFromMouse(float deltaTime, bool smoothed)
		{
			return default(Vector2);
		}

		private static float ApplySmoothing(float lastValue, float thisValue, float deltaTime, float sensitivity)
		{
			return 0f;
		}
	}
}
