using System;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemSaver : Saver
	{
		[Serializable]
		public class RawData
		{
			public byte[] bytes;
		}

		public bool saveRawData;

		private bool m_changingScenes;

		public override void Reset()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyDataImmediate()
		{
		}

		public override void ApplyData(string data)
		{
		}

		public override void OnBeforeSceneChange()
		{
		}

		public override void OnRestartGame()
		{
		}
	}
}
