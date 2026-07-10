public class HudMoneyController : HudElementController
{
	private const string SYMBOL = "\ufffd";

	public NumericFlipClock moneyFlipClock;

	public static HudMoneyController Current { get; protected set; }

	private void Start()
	{
	}

	public void UpdateMoney()
	{
	}

	public static string GetFormattedMoney(int money, bool coloured, bool revertTagsForRTL = false)
	{
		return null;
	}
}
