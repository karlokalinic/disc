using UnityEngine;

[CreateAssetMenu]
public class GameModeData : ScriptableObject
{
	public int whiteCheckModifier;

	public float healingItemCostMultiplier;

	public float drugItemCostMultiplier;

	public float containerMoneyMultiplayer;

	public int drugBaseChargesAmount;

	public int expMinorRewardBonus;

	public int expStandardRewardBonus;
}
