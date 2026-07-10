using System.Collections;
using FortressOccident;
using Sunshine;
using UnityEngine;

public class KimGoodnight : CutsceneSituation
{
	private const string FALLBACK_GOODNIGHT_BARK = "\"See you in the morning.\"";

	private const string FALLBACK_BYE_BARK = "\"\u001dBye.\"\u001d";

	private Collider col;

	private Character character;

	private bool atDoor;

	private bool inRoom;

	public override void Awake()
	{
	}

	public override void OnEnable()
	{
	}

	public override void OnDisable()
	{
	}

	public override IEnumerator PerformActions()
	{
		return null;
	}

	private void OpenDoor(Character kim, bool wasDestinationReached)
	{
	}

	private void EnterRoom(Character kim, bool wasDestinationReached)
	{
	}
}
