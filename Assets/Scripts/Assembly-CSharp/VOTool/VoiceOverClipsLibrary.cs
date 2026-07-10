using System.Collections.Generic;
using UnityEngine;

namespace VOTool
{
	[CreateAssetMenu]
	public class VoiceOverClipsLibrary : ScriptableObject
	{
		public List<VoiceClipInformation> clipInformations;

		public VoiceClipInformation GetClipToPlay(string articyID)
		{
			return null;
		}
	}
}
