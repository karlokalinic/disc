using UnityEngine.Events;
using Voidforge;

namespace FortressOccident
{
	public class GameEntityEvent : FOComponent
	{
		public UnityEvent onActivate;

		public UnityEvent onDeactivate;

		protected ComponentRef<GameEntity> gameEntity;

		protected void OnActivationEvent(bool active)
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}
	}
}
