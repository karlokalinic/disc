using UnityEngine;

public class HealingButtonTooltipDataProvider : MonoBehaviour, IGenericTooltipDataProvider
{
	private HealingButton healingButton;

	public static string HEAL_DAMAGE_ONE_TITLE => null;

	public static string HEAL_DAMAGE_ONE_DESC => null;

	public static string HEAL_DAMAGE_ONE_EFF => null;

	public static string HEAL_DAMAGE_ONE_SND => null;

	public static string HEAL_MORALE_ONE_TITLE => null;

	public static string HEAL_MORALE_ONE_DESC => null;

	public static string HEAL_MORALE_ONE_EFF => null;

	public static string HEAL_MORALE_ONE_SND => null;

	private void Awake()
	{
	}

	public GenericTooltipData GetTooltipData()
	{
		return null;
	}
}
