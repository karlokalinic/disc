using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SelectableNavigationController : MonoBehaviour
{
	[SerializeField]
	private SwitchableNavigation[] switchableNavigations;

	private Selectable selectable;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private IEnumerator OnEnableFindSingleton()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OnInteractableChanged(bool b)
	{
	}
}
