using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
	{
		[SerializeField]
		private AudioClip m_Clip;

		[SerializeField]
		private bool m_Loop;

		[SerializeField]
		[HideInInspector]
		private float m_bufferingTime;

		[SerializeField]
		private AudioClipProperties m_ClipProperties;

		internal float bufferingTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AudioClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override double duration => 0.0;

		public override IEnumerable<PlayableBinding> outputs => null;

		public ClipCaps clipCaps => default(ClipCaps);

		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}
	}
}
