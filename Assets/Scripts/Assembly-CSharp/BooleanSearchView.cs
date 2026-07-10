using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BooleanSearchView : MonoBehaviour
{
	private const string PERSISTNCE_KEY_COUNT = "BooleanListView_Count";

	private const string PERSISTNCE_KEY_NAME = "BooleanListView_Bool_";

	public InputField SearchInput;

	public RectTransform SearchResultContainer;

	public RectTransform SearchResultScrollView;

	public RectTransform ListContainer;

	public Text NoSearchResultText;

	public Button SearchResultEntryTemplate;

	public RectTransform BooleanTemplate;

	public RectTransform NumberTemplate;

	public Button RemoveVariableButtonTemplate;

	private Dictionary<string, Button> searchResultObjects;

	private SortedDictionary<string, RectTransform> listObjects;

	private List<string> searchResult;

	private string previousSearchToken;

	public void Start()
	{
	}

	private void LoadFromPersistence()
	{
	}

	public void OnSearchInputChanged()
	{
	}

	private void UpdateSearchResults()
	{
	}

	private void CreateSearchResultButton(string variableName)
	{
	}

	private void DeleteUnusedSearchResults()
	{
	}

	public void AddBooleanToList()
	{
	}

	private void CreateButton(string variableName)
	{
	}

	private void RemoveVariableFromList(string variableName)
	{
	}

	public void CloseSearch()
	{
	}

	public void PersistSelection()
	{
	}

	public void RefreshList()
	{
	}
}
