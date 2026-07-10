using System;

namespace UnityEngine.Timeline
{
	[Obsolete]
	public class TrackMediaType : Attribute
	{
		public readonly TimelineAsset.MediaType m_MediaType;

		public TrackMediaType(TimelineAsset.MediaType mt)
		{
		}
	}
}
