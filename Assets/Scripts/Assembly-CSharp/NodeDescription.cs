using PixelCrushers.DialogueSystem;

public class NodeDescription
{
	public DialogueEntry previousEntry;

	public DialogueEntry entry;

	public int outgoingCount;

	public bool isEnd;

	public bool isGroup;

	public bool hasCondition;

	public bool isAccessible;

	public bool isPassive;

	public bool isPassiveShown;

	public bool isYou;
}
