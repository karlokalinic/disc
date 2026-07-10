using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	[Serializable]
	[ExcludeFromPreset]
	[HideInMenu]
	public class MarkerTrack : TrackAsset
	{
		public override IEnumerable<PlayableBinding> outputs => null;
	}
}
