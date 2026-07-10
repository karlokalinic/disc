using System;
using System.Collections.Generic;
using UnityEngine.Audio;

namespace DarkTonic.MasterAudio
{
	[Serializable]
	public class GroupBus
	{
		public string busName;

		public float volume;

		public bool isSoloed;

		public bool isMuted;

		public int voiceLimit;

		public bool stopOldest;

		public bool isExisting;

		public AudioMixerGroup mixerChannel;

		public bool forceTo2D;

		private readonly List<int> _activeAudioSourcesIds;

		private float _originalVolume;

		public int ActiveVoices => 0;

		public bool BusVoiceLimitReached => false;

		public float OriginalVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void AddActiveAudioSourceId(int id)
		{
		}

		public void RemoveActiveAudioSourceId(int id)
		{
		}
	}
}
