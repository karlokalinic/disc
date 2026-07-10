namespace FortressOccident
{
	public abstract class Interactable : FOComponent
	{
		public struct ClickEventData
		{
			public bool isDoubleClick;
		}

		public virtual bool CanInteract => false;

		public abstract bool Interact(ClickEventData data);
	}
}
