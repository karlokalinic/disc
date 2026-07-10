using System.Collections.Generic;
using UnityEngine;

public class PageSystemWhiteCheckCoordinatesUI : LiteSingleton<PageSystemWhiteCheckCoordinatesUI>
{
	private const string ACTOR_NAME_FIELD = "Name";

	[SerializeField]
	private WhiteCheckCoordinates whiteCheckCoordinates;

	private Dictionary<string, ActorCoordinates> actorNameCoordinates;

	public void InitializeCoordinates()
	{
	}

	public Vector2 GetCheckCoordsForActor(string actorName)
	{
		return default(Vector2);
	}

	private Vector2 GetValidActorCoordinate(ActorCoordinates actorCoordinates)
	{
		return default(Vector2);
	}

	private bool ConditionIsValid(string condition)
	{
		return false;
	}
}
