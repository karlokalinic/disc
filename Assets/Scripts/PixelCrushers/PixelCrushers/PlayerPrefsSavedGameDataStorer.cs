using UnityEngine;

namespace PixelCrushers
{
	public class PlayerPrefsSavedGameDataStorer : SavedGameDataStorer
	{
		[SerializeField]
		private string m_playerPrefsKeyBase;

		public bool encrypt;

		public string encryptionPassword;

		[SerializeField]
		private bool m_debug;

		public string playerPrefsKeyBase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool debug => false;

		public string GetPlayerPrefsKey(int slotNumber)
		{
			return null;
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
	}
}
