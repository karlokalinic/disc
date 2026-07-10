using FortressOccident;
using UnityEngine;

public class AbandonedPartyMemberHolder : MonoBehaviour
{
	public static AbandonedPartyMemberHolder Singleton;

	private void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public static void HoldPartyMember(Character character, bool hide)
	{
	}

	public static void ReturnPartyMember(Character character)
	{
	}

	public static void ShowPartyMember(Character character)
	{
	}

	private void CheckForSpecialConditions()
	{
	}

	private void CheckForSpecialConditionsForKim()
	{
	}

	public bool IsCharacterAbandoned(Character character)
	{
		return false;
	}
}
