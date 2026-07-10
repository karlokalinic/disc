using UnityEngine;

public class HudFakeMoneyController : HudElementController
{
	public static HudFakeMoneyController Singleton;

	[SerializeField]
	private float shakeAmount;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float duration;

	[SerializeField]
	private ShakeAnimationGUI shakeAnim;

	private const string SYMBOL = "\ufffd";

	public const string REAL = "réa";

	[SerializeField]
	private LongNumericFlipClock moneyFlipClock;

	private long fakeMoney;

	private long previousAmount;

	public override void Awake()
	{
	}

	public void UpdateMoney(long amount)
	{
	}

	public string GetFormattedMoney(long money, bool coloured)
	{
		return null;
	}
}
