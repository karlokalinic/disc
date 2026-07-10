using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	public class AudioTrack : TrackAsset
	{
		[SerializeField]
		private AudioMixerProperties m_TrackProperties;

		public override IEnumerable<PlayableBinding> outputs => null;

		public TimelineClip CreateClip(AudioClip clip)
		{
			return null;
		}

		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		private void OnValidate()
		{
		}
	}
}
