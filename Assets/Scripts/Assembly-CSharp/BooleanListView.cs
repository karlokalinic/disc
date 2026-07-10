using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BooleanListView : GenericListView
{
	private const char TITLE_DELIMITER = '.';

	public RectTransform booleanTemplate;

	public RectTransform numberTemplate;

	protected override void PopulateList()
	{
	}

	private void CreateButton(Variable variable, RectTransform root)
	{
	}

	protected override void Start()
	{
	}

	protected override char GetSeparator()
	{
		return '\0';
	}
}
