using System.Collections.Generic;
using Sunshine;

public class InventorySlotList : LiteSingleton<InventorySlotList>
{
	public InventorySlotListComponent[] slots;

	protected Dictionary<EquipmentSlotType, UIDragDock> string2slot;

	protected Dictionary<UIDragDock, EquipmentSlotType> slot2string;

	protected override void Awake()
	{
	}

	protected void RefreshCache()
	{
	}

	public UIDragDock GetSlot(EquipmentSlotType slotType)
	{
		return null;
	}

	public EquipmentSlotType GetName(UIDragDock slot)
	{
		return default(EquipmentSlotType);
	}
}
