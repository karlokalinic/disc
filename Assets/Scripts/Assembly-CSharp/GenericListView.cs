using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class GenericListView : MonoBehaviour
{
	protected Transform currentlyOpenCategory;

	protected Color truthGreen;

	protected Color truthLightGreen;

	protected Color falseOrange;

	protected Color falseLightOrange;

	protected Color lightGrey;

	protected Color lighterGrey;

	protected Color integerBlue;

	protected Color integerLightBlue;

	public RectTransform viewContent;

	public RectTransform templateObject;

	public List<RectTransform> permanentElements;

	private void HideTemplate()
	{
	}

	public RectTransform AddItem()
	{
		return null;
	}

	public void ResetList()
	{
	}

	protected abstract void PopulateList();

	protected void AdoptParent(Button button, string title, RectTransform root)
	{
	}

	protected RectTransform GetOrCreateCategory(RectTransform root, string name)
	{
		return null;
	}

	protected RectTransform CreateCategory(string name, RectTransform parent)
	{
		return null;
	}

	protected void RefreshOpen()
	{
	}

	public void OpenCategory(Button butt)
	{
	}

	public void CloseCategory(Button butt)
	{
	}

	private void ClearList()
	{
	}

	private void AddPermanentItems()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void Start()
	{
	}

	protected abstract char GetSeparator();

	protected int TitleCompare(string title1, string title2)
	{
		return 0;
	}
}
