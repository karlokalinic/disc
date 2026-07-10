using System.Collections.Generic;

public class HardcodedDialogues
{
	public enum DIALOGUES
	{
		LIFELINE_VOLITION = 0,
		LIFELINE_ENDURANCE = 1,
		GAME_START_DIALOGUE = 2,
		LEDGER_WAKEUP = 3,
		POST_TRIBUNAL_KIM_WAKEUP = 4,
		POST_TRIBUNAL_CUNO_WAKEUP = 5,
		DREAM_2_INTRO = 6,
		DREAM_2_HANGED_MAN = 7,
		DREAM_3_NO_DOLORES = 8,
		DREAM_3_POST_WAKEUP = 9,
		DREAM_3 = 10,
		DREAM_4 = 11,
		DREAM_5 = 12,
		DREAM_BLACKOUT = 13,
		KIM_DIALOGUE_NAME = 14
	}

	public enum BARKS
	{
		BACKYARD__KIM_APT_DOOR = 0
	}

	public static Dictionary<DIALOGUES, string> LIST;

	public static Dictionary<BARKS, string> BARK_LIST;
}
