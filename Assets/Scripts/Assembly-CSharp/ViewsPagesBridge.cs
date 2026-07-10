using Sunshine.Journal.Controller;
using Sunshine.Metric;
using Sunshine.Views;
using UnityEngine;

public class ViewsPagesBridge : MonoBehaviour
{
	private static CharacterSheet character;

	private static CharSheetMode sheetMode;

	private static ViewType current;

	private static SkillType selectedSkill;

	public static CharacterSheet Character => null;

	public static SkillType SelectedSkill
	{
		get
		{
			return default(SkillType);
		}
		set
		{
		}
	}

	public static CharSheetMode SheetMode
	{
		get
		{
			return default(CharSheetMode);
		}
		set
		{
		}
	}

	public static ViewType Current
	{
		get
		{
			return default(ViewType);
		}
		set
		{
		}
	}

	public static JournalController JournalController => null;

	public static PartyVisualizer PartyVisualizer => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void InitDialoguePage()
	{
	}

	private void DialoguePageGoBack()
	{
	}
}
