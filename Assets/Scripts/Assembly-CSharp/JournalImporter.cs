using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

public static class JournalImporter
{
	public const string TASK_NAME_FIELD = "Title";

	public const string TASK_DESCRIPTION_FIELD = "Description";

	public const string TASK_SHOW_FIELD = "display_condition_main";

	public const string TASK_DONE_FIELD = "done_condition_main";

	private const string TASK_CANCEL_FIELD = "cancel_condition_main";

	public const string TASK_REWARD_FIELD = "task_reward";

	private const string TASK_TIMED_FIELD = "task_timed";

	public const int MAX_NR_OF_SUBTASKS = 12;

	public const string SUBTASK_NAME_FIELD_PREFIX = "subtask_title_";

	public const string SUBTASK_TIMED_FIELD_PREFIX = "timed_subtask_";

	public const string SUBTASK_SHOW_FIELD_PREFIX = "display_subtask_";

	public const string SUBTASK_DONE_FIELD_PREFIX = "done_subtask_";

	public const string SUBTASK_CANCEL_FIELD_PREFIX = "cancel_subtask_";

	private static bool isImportDone;

	public static void Populate()
	{
	}

	public static void Populate(List<Conversation> conversations)
	{
	}

	private static void ValidateTaskFormat(Conversation conv, string name)
	{
	}

	public static bool IsTask(List<Field> fields)
	{
		return false;
	}
}
