using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSequencerPanel : MonoBehaviour
{
	private enum ViewType
	{
		LIST_VIEW = 0,
		SEQUENCES_VIEW = 1
	}

	private bool isRecording;

	private bool isPlaying;

	private bool playSingle;

	private int currentPlayingSequenceIndex;

	private Dictionary<string, Button> savedListsButtons;

	public RectTransform SavedListsViewRect;

	public RectTransform SavedListsContainer;

	public Button BackButton;

	public Button PlayButton;

	public Button RecordButton;

	public Button SaveButton;

	public Button StopButton;

	public Button NewButton;

	public RectTransform NodeSequenceViewRect;

	public RectTransform NodeSequenceContainer;

	public InputField NodeSequenceCommandsInput;

	private Dictionary<string, Button> nodeSequenceButtons;

	public InputField SequenceListNameInput;

	public Button ButtonTemplate;

	private List<StoredSequence> savedLists;

	private StoredSequence currentList;

	private NodeSequence currentNodeSequence;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void InitFields()
	{
	}

	public void OnNewSavedList()
	{
	}

	private void OnSequenceStarted(string dialogueText, string[] sequenceCommandList)
	{
	}

	private void OnSequenceFinished()
	{
	}

	public void ToggleRecording()
	{
	}

	private void ToggleButtons(bool isInteractable, bool fromRecording)
	{
	}

	public void PlayLoadedRecording()
	{
	}

	private void PlayNextNodeSequence()
	{
	}

	public void StopPlaying()
	{
	}

	private void SelectNodeSequence(string sequenceId)
	{
	}

	private void PlayNodeSequence(string sequenceId)
	{
	}

	private void DeleteNodeSequence(string sequenceID)
	{
	}

	private void ClearRecordingData()
	{
	}

	public void SaveRecordedSequence()
	{
	}

	private void DeleteDuplicateIfExists(string sequenceName)
	{
	}

	private void LoadRecordedSequence(string recordedSequenceName)
	{
	}

	public void OnSequenceTextChange()
	{
	}

	public void NewNodeSequence()
	{
	}

	private void LoadSavedLists()
	{
	}

	public void DeleteSavedList(string savedListName)
	{
	}

	private void CreateNodeSequenceButton(string text, string identifier)
	{
	}

	private Button CreateButton(RectTransform parent, string text, string identifier, Action<string> onClickCallback, Action<string> deleteCallback, Dictionary<string, Button> stash)
	{
		return null;
	}

	private void DestroyAllAndClear(Dictionary<string, Button> dictionary)
	{
	}

	public void BackToListView()
	{
	}

	private void SwitchToView(ViewType viewType)
	{
	}

	private void UpdateSaveButtonNotification(bool set)
	{
	}
}
