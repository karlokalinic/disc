using UnityEngine;

namespace CollageMode
{
	public class CollageSaveData
	{
		public Texture2D Screenshot;

		public string FileName;

		public CollageSaveFileTemplate SaveData;

		public SaveSlotDesc SlotDesc { get; }

		public CollageSerializer.CollageData JsonSceneData => null;

		public CollageSaveData(SaveSlotDesc saveSlotDesc)
		{
		}

		public CollageSaveData(Texture2D screenshot, CollageSerializer.CollageData saveData)
		{
		}

		public string GetFileNameFromPath(string path)
		{
			return null;
		}

		private void ModifySlotUniqueName()
		{
		}
	}
}
