using System;
using System.Collections.Generic;

[Serializable]
public struct CutsceneObjectState
{
	public string name;

	public int lastAnimationHash;

	public TriggeredFunctions triggeredFunctions;

	public Dictionary<TriggeredFunctions, string> parameters;
}
