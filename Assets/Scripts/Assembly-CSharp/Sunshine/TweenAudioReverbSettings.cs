using System;
using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class TweenAudioReverbSettings : TweenValue<TweenAudioReverbSettings.Settings>, Tween.IBeforePlaying
	{
		[Serializable]
		public class Settings
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

			public Settings()
			{
			}

			public Settings(AudioReverbFilter filter)
			{
			}

			public Settings(AudioReverbSettings settings)
			{
			}

			public bool WriteTo(AudioReverbFilter target)
			{
				return false;
			}

			public static Settings Lerp(Settings from, Settings to, float t)
			{
				return null;
			}
		}

		public AudioReverbPreset targetPreset;

		public AudioReverbSettings targetSettings;

		public float duration;

		[GetComponent]
		protected ComponentRef<AudioReverbFilter> filter;

		protected AudioReverbPreset fromPreset;

		protected Settings fromValues;

		protected Settings toValues;

		public override Settings Item => null;

		void IBeforePlaying.BeforePlaying()
		{
		}

		protected override void Repaint()
		{
		}
	}
}
