using UnityEngine;

public class ActivateIfPlatform : MonoBehaviour
{
	[SerializeField]
	private GameObject target;

	[SerializeField]
	private bool disableIfNotSelectedPlatform;

	[SerializeField]
	private bool activateIfPC;

	[SerializeField]
	private bool activateIfStadia;

	[SerializeField]
	private bool activateIfConsole;

	[SerializeField]
	private bool activateIfiOS;

	private void Reset()
	{
	}

	private void Start()
	{
	}
}
