using System.Collections;
using System.Collections.Generic;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine.Views
{
	public class SaveLoadController : VoidElement
	{
		private const int SCREENSHOT_WIDTH = 500;

		private const string SYS_SAVE_DATE_REPLACEMENT_TEXT = "Interal Save";

		public RectTransform saveFileListContentPanel;

		public Button saveButton;

		public SaveGameListEntry saveGameFileListEntryPrefabLegacy;

		public SaveGameListEntry sysSaveGameFileListEntryPrefabLegacy;

		public SaveGameListEntry saveGameFileListEntryPrefabTMPro;

		public SaveGameListEntry sysSaveGameFileListEntryPrefabTMPro;

		public RectTransform fileListSeparator;

		[SerializeField]
		private ScrollRect scrollArea;

		public Color SelectedSaveGameFileButtonColor;

		public Color NormalSaveGameFileButtonColor;

		public Localize titleLocalize;

		public string saveTerm;

		public string overwriteTerm;

		public string titleSaveTerm;

		public string titleLoadTerm;

		public RectTransform fileInfoComponentHolderPanel;

		public Image screenshotImagePanel;

		public Sprite defaultSprite;

		public Localize errorLocalize;

		public Button LoadButton;

		public Button DeleteButton;

		[SerializeField]
		private VerticalStepScrollView verticalStep;

		private Dictionary<string, SaveGameListEntry> saveGameFileList;

		private List<SaveGameListEntry> spawnedEntiers;

		private List<SaveGameListEntry> selectedSaveGameList;

		private SaveGameListEntry selectedSaveGame;

		private bool isBundled;

		private SaveGameListEntry newGameSaveListEntry;

		[SerializeField]
		private SoundPlayer buttonClickedSoundPlayer;

		private SAVE_LOAD_MODE currentMode;

		private Coroutine refreshSaveGameListAsync;

		private static bool triggerSaveListUIRefresh;

		private SaveGameListEntry SaveGameFileListEntryPrefab => null;

		private SaveGameListEntry SysSaveGameFileListEntryPrefab => null;

		public static void TriggerSaveListUIRefresh()
		{
		}

		private void Update()
		{
		}

		public IEnumerator SaveListUIRefreshCoR()
		{
			return null;
		}

		public void CloseView()
		{
		}

		public void ResetViewData(bool unsubscribeInput = true)
		{
		}

		public void UnsubscribeInput()
		{
		}

		public void PrepareView(SAVE_LOAD_MODE mode)
		{
		}

		public void OnThumbnail(string name, byte[] bytes)
		{
		}

		private void ResetSaveFileNameToDefault()
		{
		}

		private string GenerateUniqueSaveGameName()
		{
			return null;
		}

		private IEnumerator RefreshSaveGameFileListAsync()
		{
			return null;
		}

		public void SelectLastSelectedElement()
		{
		}

		public SaveGameListEntry SelectFirstListElement()
		{
			return null;
		}

		private void RefreshTitleText()
		{
		}

		private void AddInternallyBundledSaves()
		{
		}

		private void AddBundledSaveGameToMenu(string parsedFileName)
		{
		}

		private void AddSaveGameToMenu(string parsedFileName)
		{
		}

		private void AddNewSaveGameToMenu()
		{
		}

		private void SetNavigation(SaveGameListEntry entry)
		{
		}

		private void OnSaveRenamed(string oldName, string newName)
		{
		}

		private void OnSaveButtonSubmitted()
		{
		}

		private void ClickBundledSavedGame(SaveGameListEntry clickedSave)
		{
		}

		private void ClickNewSavedGame(SaveGameListEntry clickedSave)
		{
		}

		private void ClickSavedGame(SaveGameListEntry clickedSave)
		{
		}

		private void AddSavedGameToSelection(string fileNamePrefix, bool addRange, bool toggle)
		{
		}

		private void ToggleButtonSelection(SaveGameListEntry saveGameListEntry, bool toggle)
		{
		}

		private void ClearSaveGameSelection()
		{
		}

		private void DisplaySaveGameFileInfo(SaveGameListEntry saveListEntry)
		{
		}

		private void ClearSaveGameFileDetails()
		{
		}

		public void CreateASaveGame()
		{
		}

		private void ReplaceSave()
		{
		}

		public void ShowLoadGameConfirmation()
		{
		}

		public void LoadGame()
		{
		}

		private void SetImageTextureToThumbnail(Texture2D texture)
		{
		}

		private void ClearErrors()
		{
		}

		private void ShowError(string errorTerm)
		{
		}

		public void ShowDeleteConfirmationDialogue()
		{
		}

		private void ShowReplaceConfirmationDialogue()
		{
		}

		private void CloseConfirmationDialogue()
		{
		}

		private IEnumerator DeleteSaveGameCoR()
		{
			return null;
		}

		private void DeleteSaveGame()
		{
		}

		private IEnumerator DeleteMultipleSaveGameCoR()
		{
			return null;
		}

		private void DeleteMultiple()
		{
		}

		public void OnQuickSave()
		{
		}

		public void OnQuickLoad()
		{
		}

		private void ToggleSelectionGroup()
		{
		}

		private void MoveToMenu()
		{
		}

		private Button GetButtonBasedOnCurrentMode()
		{
			return null;
		}

		public void RegisterEvents()
		{
		}

		public void UnregisterEvents()
		{
		}
	}
}
