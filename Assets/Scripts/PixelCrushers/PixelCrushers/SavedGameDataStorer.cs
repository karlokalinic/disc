using UnityEngine;

namespace PixelCrushers
{
	public abstract class SavedGameDataStorer : MonoBehaviour
	{
		public abstract bool HasDataInSlot(int slotNumber);

		public abstract void StoreSavedGameData(int slotNumber, SavedGameData savedGameData);

		public abstract SavedGameData RetrieveSavedGameData(int slotNumber);

		public abstract void DeleteSavedGameData(int slotNumber);
	}
}
