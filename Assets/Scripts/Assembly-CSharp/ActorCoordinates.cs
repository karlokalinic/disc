using System;
using System.Collections.Generic;

[Serializable]
public struct ActorCoordinates
{
	public string actorName;

	public List<ConditionedCoordinate> conditionedCoordinates;
}
