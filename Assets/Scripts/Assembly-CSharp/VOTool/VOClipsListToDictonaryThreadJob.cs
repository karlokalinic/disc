using System.Collections.Generic;
using UnityThread;

namespace VOTool
{
	public class VOClipsListToDictonaryThreadJob : ThreadedJob
	{
		public List<VoiceClipInformation> sourceClipInformations;

		public Dictionary<string, VoiceClipInformation> resultDictonary;

		protected override void ThreadFunction()
		{
		}

		protected override void OnFinished()
		{
		}
	}
}
