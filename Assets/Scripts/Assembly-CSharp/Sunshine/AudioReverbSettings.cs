using UnityEngine;

namespace Sunshine
{
	[CreateAssetMenu]
	public class AudioReverbSettings : ScriptableObject
	{
		public float dryLevel;

		public float room;

		public float roomHF;

		public float roomLF;

		public float decayTime;

		public float decayHFRatio;

		public float reflectionsLevel;

		public float reflectionsDelay;

		public float reverbLevel;

		public float reverbDelay;

		public float hfReference;

		public float lfReference;

		public float diffusion;

		public float density;

		public float roomRolloff;

		public bool ReadFrom(AudioReverbFilter target)
		{
			return false;
		}

		public bool WriteTo(AudioReverbFilter target)
		{
			return false;
		}
	}
}
