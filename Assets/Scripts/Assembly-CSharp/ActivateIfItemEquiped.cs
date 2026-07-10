using UnityEngine;

public class ActivateIfItemEquiped : MonoBehaviour
{
	[SerializeField]
	private GameObject objectToActivate;

	[SerializeField]
	private string itemName;

	[SerializeField]
	private EquipmentSlotType equippedToSlot;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnItemEquiped(string nameOfEquipedItem, EquipmentSlotType itemType, bool isEquipped)
	{
	}
}
