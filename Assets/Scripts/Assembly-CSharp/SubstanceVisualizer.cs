using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;

public class SubstanceVisualizer : MonoBehaviour
{
	[SerializeField]
	private StatusNotification statusIconTemplate;

	[SerializeField]
	private Transform usedStatusIconsParent;

	[SerializeField]
	private Transform unusedStatusIconsParent;

	[SerializeField]
	private StatusNotificationDim statusNotificationDim;

	private List<StatusNotification> activeStatusIcons;

	private List<StatusNotification> unusedStatusIconsPool;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Refresh()
	{
	}

	private void UpdateDim()
	{
	}

	public void RemoveSubstanceEffect()
	{
	}

	private void CheckCurrentStatusIcons()
	{
	}

	private void ShowNewStatusIcons()
	{
	}

	private void AddIconsForItem(InventoryItem item)
	{
	}

	private void AddIconForEffect(InventoryItem item, CharacterEffect effect)
	{
	}

	private StatusNotification GetFromPool()
	{
		return null;
	}

	private void ReturnToPool(StatusNotification icon)
	{
	}

	private void OnStatusIconDisabled(StatusNotification icon)
	{
	}

	private bool ValidateEffect(CharacterEffect effect)
	{
		return false;
	}

	private void OnTimeChanged()
	{
	}
}
