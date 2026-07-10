using System;
using System.Collections.Generic;

namespace VOTool
{
	[Serializable]
	public class VoiceClipInformation
	{
		public string AssetName;

		public string ArticyID;

		public string AssetBundle;

		public string PathToClipInProject;

		public bool DoesNotNeedVO;

		public List<AlternativeVoiceClipInformation> alternativeVoiceClips;

		public bool HaveValidVoiceFileToPlay => false;

		public VoiceClipInformation(string articyID, string assetName, string assetbundle, string pathToClipInProject, bool doesNotNeedVO)
		{
		}

		public void UpdateClipData(string assetName, string assetbundle, string pathToClipInProject)
		{
		}

		public void UpdateAlternativeClipData(int alternativeID, string assetAlternativeName, string alternativeClipPath, bool doesNotNeedVO)
		{
		}

		public AlternativeVoiceClipInformation GetAlternativeVoiceClip(int alternativeID)
		{
			return null;
		}

		public string ClipInformationToString()
		{
			return null;
		}

		public bool ShouldBeDeleted()
		{
			return false;
		}
	}
}
