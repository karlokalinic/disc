using Sunshine.Metric;
using Voidforge;

public class Alterant : SingletonClass<Alterant>
{
	public static void HandleItemPickup(string itemName, InventoryItem item)
	{
	}

	public static void SubstanceEffectAlteration(ThoughtCabinetProject project)
	{
	}

	public static void SubstanceEffectRestoration(ThoughtCabinetProject project)
	{
	}

	public static void ChangeItemBuff(string buffName, ItemGroup group)
	{
	}

	public static int SubstanceUsedAmount(string substance)
	{
		return 0;
	}

	public static void SubstanceChargeUsed(string substance)
	{
	}

	public static bool ItemConditionMet(string itemName)
	{
		return false;
	}

	public static string TooltipInjector(InventoryItem item)
	{
		return null;
	}

	public static void SpecialEndButton()
	{
	}

	public static void RegularEndButton()
	{
	}
}
