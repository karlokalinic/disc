using System.Collections;
using FortressOccident;
using Sunshine;
using UnityEngine;

public class KimGoodnightShack : CutsceneSituation
{
	private const string FALLBACK_GOODNIGHT_BARK = "\"See you in the morning.\"";

	private const string FALLBACK_BYE_BARK = "\"\u001dBye.\"\u001d";

	private Collider col;

	private Character character;

	private bool atDoor;

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

	private void OnCharacterOnHasArrivedEvent(Character arg1, bool arg2)
	{
	}
}
