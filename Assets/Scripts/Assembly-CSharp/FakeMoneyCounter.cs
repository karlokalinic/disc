using UnityEngine;

public class FakeMoneyCounter : MonoBehaviour
{
	[SerializeField]
	private Transform richGuy;

	public static int BonusMoney;

	private long fakeMoney;

	private void Update()
	{
	}

	private long Lerp(long a, long b, float t)
	{
		return 0L;
	}
}
