using FortressOccident;
using UnityEngine;

public class SessionManager : MonoBehaviour
{
	public static SessionManager instance;

	private int currentGameTimeMinutes;

	private int totalMoneyThisSession;

	private float currentTimer;

	private float sendEventTimer;

	private SessionSave savedData;

	private ApplicationManager appMan;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private string GetMetricsFilePath()
	{
		return null;
	}

	private void SendPlayerStatusEvent()
	{
	}

	public void AddCurrentGameTimeMinutes(int time)
	{
	}

	public void AddMoney(int money)
	{
	}
}
