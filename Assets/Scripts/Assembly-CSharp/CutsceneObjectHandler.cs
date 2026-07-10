using System.Collections.Generic;
using UnityEngine;

public class CutsceneObjectHandler : MonoBehaviour
{
	private TriggeredFunctions triggeredFunctions;

	private Dictionary<TriggeredFunctions, string> parameters;

	public TriggeredFunctions TriggeredFunctions => default(TriggeredFunctions);

	public Dictionary<TriggeredFunctions, string> Parameters => null;

	public void ResetCutsceneObject(TriggeredFunctions triggeredFunctions, Dictionary<TriggeredFunctions, string> parameters)
	{
	}

	public void DestroyObject(AnimationEvent animationEvent)
	{
	}

	public void AppearObjectRightHand(AnimationEvent animationEvent)
	{
	}

	public void AppearObjectLeftHand(AnimationEvent animationEvent)
	{
	}

	public void AppearObject(AnimationEvent animationEvent)
	{
	}

	public void AppearObjectZero(AnimationEvent animationEvent)
	{
	}

	public void AppearProp(AnimationEvent animationEvent)
	{
	}

	public void DisappearObjectRightHand(AnimationEvent animationEvent)
	{
	}

	public void DisappearObjectLeftHand(AnimationEvent animationEvent)
	{
	}

	public void DisappearObject(AnimationEvent animationEvent)
	{
	}

	public void DisappearProp(AnimationEvent animationEvent)
	{
	}

	public void HideProp(AnimationEvent animationEvent)
	{
	}

	public void ObjectToCharPos(AnimationEvent animationEvent)
	{
	}

	public void MessageObject(AnimationEvent animationEvent)
	{
	}

	public void AppearObjectRightHand(string objParam)
	{
	}

	public void AppearObjectLeftHand(string objParam)
	{
	}

	public void AppearObject(string objParam)
	{
	}

	public void AppearObjectZero(string objParam)
	{
	}

	public void AppearProp(string objParam)
	{
	}

	public void DisappearObjectRightHand(string objParam)
	{
	}

	public void DisappearObjectLeftHand(string objParam)
	{
	}

	public void DisappearObject(string objParam)
	{
	}

	public void DisappearProp(string objParam)
	{
	}

	public void HideProp(string objParam)
	{
	}

	public void ObjectToCharPos(string objParam)
	{
	}

	public void MessageObject(string objParam)
	{
	}
}
