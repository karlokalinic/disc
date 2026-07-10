using Sunshine.Metric;

public class ModifierCauseHolder
{
	public enum MODIFIER_CAUSE_TYPE
	{
		INVENTORY_ITEM = 0,
		THOUGHT = 1,
		ABILITY = 2
	}

	public string ModifierKey;

	public MODIFIER_CAUSE_TYPE ModifierCauseType;

	private ModifierCauseHolder(IModifierCause modifierCause)
	{
	}

	public static ModifierCauseHolder GetModifierCauseHolder(IModifierCause modifierCause)
	{
		return null;
	}

	public IModifierCause GetModifierCause(CharacterSheet characterSheet)
	{
		return null;
	}
}
