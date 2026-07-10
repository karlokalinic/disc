using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	public class GroupTrack : TrackAsset
	{
		public override IEnumerable<PlayableBinding> outputs => null;

		internal override bool CanCompileClips()
		{
			return false;
		}
	}
}
