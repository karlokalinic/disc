using System.Collections;
using UnityEngine;

public class FakeMoneySwapper : MonoBehaviour
{
	[SerializeField]
	private GameObject realMoneyHud;

	[SerializeField]
	private GameObject fakeMoneyHud;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void HandleMoneyHudSwapping()
	{
	}

	private IEnumerator DisableRealMoney()
	{
		return null;
	}
}
