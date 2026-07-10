using TMPro;
using UnityEngine;

public class StockValueController : MonoBehaviour
{
	private const float RANDOM_RANGE = 1000f;

	private const int STOCK_UPDATE_TIME_PERIOD = 8;

	private const int INITIAL_VALUE = 23207089;

	private static StockValueController singleton;

	[SerializeField]
	private TextMeshProUGUI stockValueText;

	[SerializeField]
	private MoneyFlipClock flipClock;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private int stockValue;

	private int lastPeriod;

	public static StockValueController Singleton => null;

	public int StockValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetInitial()
	{
	}

	private void UpdateOnTimeChange()
	{
	}

	private void PickRandom()
	{
	}

	private void UpdateStockText()
	{
	}
}
