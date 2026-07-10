using UnityEngine;

public class WaterlockPersister : MonoBehaviour
{
	private const string waterLock = "canal.lever_waterlock_closed";

	[SerializeField]
	private Animator[] waterlockAnimators;

	private static readonly int open;

	private void OnEnable()
	{
	}

	private void OpenWaterLock()
	{
	}
}
