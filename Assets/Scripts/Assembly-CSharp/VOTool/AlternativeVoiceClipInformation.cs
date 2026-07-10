using System;

namespace VOTool
{
	[Serializable]
	public class AlternativeVoiceClipInformation
	{
		public int AlternativeID;

		public string AlternativeAssetName;

		public string AlternativeClipPath;

		public bool DoesNotNeedVO;

		public bool HaveValidVoiceFileToPlay => false;

		public AlternativeVoiceClipInformation()
		{
		}

		public AlternativeVoiceClipInformation(int alternativeID, string alternativeAssetName, string alternativeClipPath, bool doesNotNeedVO)
		{
		}

		public void UpdateValues(string assetAlternativeName, string alternativeClipPath, bool doesNotNeedVO)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
