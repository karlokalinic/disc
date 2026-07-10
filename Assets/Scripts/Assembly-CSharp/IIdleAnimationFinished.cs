using UnityEngine.EventSystems;

public interface IIdleAnimationFinished : IEventSystemHandler
{
	void OnIdleAnimationExitState();
}
