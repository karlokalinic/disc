using UnityEngine;

public class PartyManager : MonoBehaviour
{
	public static SleepLocation sleepLocation;

	public static WaitLocation KimWaitLocation;

	public static CunoWaitLocation CunoWaitLocation;

	public static bool IsKimDead => false;

	public static int TimeSinceKimWentSleepingInHisRoom { get; set; }

	public static bool IsKimSleepingInHisRoom { get; set; }

	public static bool IsKimAwayUpToMorning { get; private set; }

	public static bool IsKimWaitingAtChurch => false;

	public static bool IsKimWaitingAtTent => false;

	public static bool IsKimWaitingAtLair => false;

	public static bool IsCunoYourPartner => false;

	public static bool SleptInWhirling => false;

	public static bool SleptInShack => false;

	public static bool SleptInFort => false;

	public static void NewGame(bool isRestoringGame = false)
	{
	}

	public static void KitsuragiWillReturnTomorrow()
	{
	}

	public static void KitsuragiReturningNow()
	{
	}

	public static void RestoreReturnState(bool returnState)
	{
	}

	public static void SetKimWaitLocation(WaitLocation location)
	{
	}

	public static void SetCunoWaitLocation(CunoWaitLocation location)
	{
	}

	public static void RemoveAllPartyMembersFromParty()
	{
	}

	public static void RemoveKitsuragiFromParty()
	{
	}

	public static void LeaveKitsuragiOutside()
	{
	}

	public static void AddKitsuragiToParty()
	{
	}

	public static void ReturnKitsuragiToParty()
	{
	}

	public static void ReturnCunoToParty()
	{
	}

	public static void ReturnKitsuragiToPosition(GameObject obj)
	{
	}

	public static void ReturnCunoToPosition(GameObject obj)
	{
	}

	public static void RemoveKitsuragiFromPartyDevMenu()
	{
	}

	public static void ReturnKitsuragiToPartyDevMenu()
	{
	}

	public static bool IsKimInParty()
	{
		return false;
	}

	public static bool IsKimHere()
	{
		return false;
	}

	public static bool IsCunoInParty()
	{
		return false;
	}
}
