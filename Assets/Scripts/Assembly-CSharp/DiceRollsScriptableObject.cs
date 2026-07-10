using UnityEngine;

[CreateAssetMenu]
public class DiceRollsScriptableObject : ScriptableObject
{
	[SerializeField]
	private Sprite[] diceIconsSprites;

	[SerializeField]
	private Sprite[] diceIconsBlursSprites;

	public Sprite GetIconForRoll(int rollValue)
	{
		return null;
	}

	public Sprite GetIconBlurForRoll(int rollValue)
	{
		return null;
	}
}
