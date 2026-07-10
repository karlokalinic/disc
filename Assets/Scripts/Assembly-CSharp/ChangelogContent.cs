using UnityEngine;
using UnityEngine.UI;

public class ChangelogContent : MonoBehaviour
{
	public const string changelog = "CHANGELOG\r\n\r\n2019-03-04\r\n- All new characters start out with 1 rank in Endurance and Volition\r\n\r\n2019-02-19\r\n- XP needed for next level lowered to 100\r\n\r\n2019-02-15\r\n- Fix to white checks being unclickable\r\n\r\n2019-02-15\r\n- Thought Cabinet thoughts have bonuses overhauled and partially implemented thoughts marked as such\r\n\r\n2019-01-22\r\n- White Checks now only unlock if Skill is leveled, not on drugs/items/THC entries. (Note: If check target number lowers they still unlock).\r\n- XP to skill pip ratio rebalanced to 150 with first 4 levels being cheaper.\r\n- Skill pip to skill point ratio rebalanced to 1:1 ratio.\r\n\r\nKNOWN ISSUES AND WORKAROUNDS\r\n\r\n- Bug: Dialogue fails to show continue buttons or player dialogue. (Note: we need to know where this happens)\r\n  WORKAROUND: Sometimes possible to use SPACE and number keys to navigate blindly out from the dialogue, save, quit, reload.\r\n\r\n";

	private Text text;

	private void Awake()
	{
	}
}
