using System.Collections.Generic;
using InControl;

public class KeyboardLayoutBindings
{
	public enum KeyboardLayout
	{
		QWERTY = 0,
		AZERTY = 1,
		DVORAK = 2,
		INVALID = 3,
		CUSTOM = 4
	}

	private Dictionary<string, Key> KeyboardBindingsQWERTY;

	private Dictionary<string, Key> KeyboardBindingsAZERTY;

	private Dictionary<string, Key> KeyboardBindingsDVORAK;

	private Dictionary<string, Key> PrevBindings;

	private Dictionary<string, Key> CurrentBindings;

	public KeyboardLayout PrevLayout { get; private set; }

	public KeyboardLayout CurrentLayout { get; private set; }

	public void Create()
	{
	}

	public void SetKeyboardLayout(KeyboardLayout kbLayout)
	{
	}

	public void AddKeyBinding(PlayerAction action, string name)
	{
	}

	public Key GetPrevKey(string name)
	{
		return default(Key);
	}

	public Key GetKey(string name)
	{
		return default(Key);
	}

	private void CreateQWERTYKeyboardBindings(Dictionary<string, Key> KBLayoutMap)
	{
	}

	private void CreateAZERTYKeyboardBindings(Dictionary<string, Key> KBLayoutMap)
	{
	}

	private void CreateDVORAKKeyboardBindings(Dictionary<string, Key> KBLayoutMap)
	{
	}
}
