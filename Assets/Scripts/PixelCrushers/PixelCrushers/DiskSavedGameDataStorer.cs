using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class DiskSavedGameDataStorer : SavedGameDataStorer
	{
		private class SavedGameInfo
		{
			public string sceneName;

			public SavedGameInfo(string sceneName)
			{
			}
		}

		public bool encrypt;

		public string encryptionPassword;

		[SerializeField]
		private bool m_debug;

		private List<SavedGameInfo> m_savedGameInfo;

		public bool debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Start()
		{
		}

		public virtual string GetSaveGameFilename(int slotNumber)
		{
			return null;
		}

		public virtual string GetSavedGameInfoFilename()
		{
			return null;
		}

		public virtual void LoadSavedGameInfoFromFile()
		{
		}

		public virtual void UpdateSavedGameInfoToFile(int slotNumber, SavedGameData savedGameData)
		{
		}

		public override bool HasDataInSlot(int slotNumber)
		{
			return false;
		}

		public override void StoreSavedGameData(int slotNumber, SavedGameData savedGameData)
		{
		}

		public override SavedGameData RetrieveSavedGameData(int slotNumber)
		{
			return null;
		}

		public override void DeleteSavedGameData(int slotNumber)
		{
		}

		public static void WriteStringToFile(string filename, string data)
		{
		}

		public static string ReadStringFromFile(string filename)
		{
			return null;
		}
	}
}
