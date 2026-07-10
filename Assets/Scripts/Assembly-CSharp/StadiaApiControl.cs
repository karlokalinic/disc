using System;
using UnityEngine;

public class StadiaApiControl : MonoBehaviour
{
	public enum GamerStats
	{
		STEPS_TRAVELLED = 1,
		NARCOTICS = 2,
		TARE_SOLD = 3
	}

	public enum StreamProfiles
	{
		Invalid = 0,
		LowLatency = 1,
		Balanced = 2,
		HighVisualQuality = 3
	}

	public enum HDRRange
	{
		Invalid = 0,
		Sdr = 1,
		Hdr10 = 2
	}

	public struct StreamCaps
	{
		public int width;

		public int height;

		public int pixelDensity;

		public HDRRange hdr;
	}

	private static StadiaApiControl m_instance;

	public static Action OnStreamStarting;

	public static Action<StreamCaps> OnStreamStarted;

	public static Action<StreamCaps> OnStreamResumed;

	public static Action OnStreamSuspended;

	public static Action OnStreamExited;

	public static StadiaApiControl Instance => null;
}
