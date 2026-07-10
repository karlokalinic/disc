using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class WhiteCheckCoordinatesUI : LiteSingleton<WhiteCheckCoordinatesUI>
{
	private const string ACTOR_NAME_FIELD = "Name";

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private Image actorPortrait;

	[SerializeField]
	private Image actorPortraitGlow;

	[SerializeField]
	private Image portraitFrame;

	[SerializeField]
	private TextMeshProUGUI actorSignatureText;

	[SerializeField]
	private WhiteCheckCoordinates whiteCheckCoordinates;

	private Dictionary<string, ActorCoordinates> actorNameCoordinates;

	public string prevActorName;

	private bool isAsyncPrepared;

	private AsyncOperationHandle<Sprite> spriteHandle;

	public void InitializeCoordinates()
	{
	}

	public bool ShowCheckCoordsForActor(Actor actor, string actorName)
	{
		return false;
	}

	private Vector2 GetValidActorCoordinate(ActorCoordinates actorCoordinates)
	{
		return default(Vector2);
	}

	private bool ConditionIsValid(string condition)
	{
		return false;
	}

	private void AsyncLoadPortrait(Actor actor)
	{
	}

	private void SetPortrait(AsyncOperationHandle<Sprite> portraitHandle)
	{
	}
}
