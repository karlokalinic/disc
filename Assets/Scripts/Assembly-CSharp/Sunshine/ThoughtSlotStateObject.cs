using UnityEngine;

namespace Sunshine
{
	[CreateAssetMenu]
	public class ThoughtSlotStateObject : ScriptableObject
	{
		public ThoughtSlot.SlotState slotType;

		[SerializeField]
		private bool sl_OnMouseover;

		[SerializeField]
		private bool sl_Selected;

		[SerializeField]
		private bool sl_NoMouseoverNoSelected;

		[SerializeField]
		private Sprite halo_Selected;

		[SerializeField]
		private Sprite halo_Mouseover;

		[SerializeField]
		private Sprite halo_NoMouseoverNoSelected;

		[SerializeField]
		private bool halo_MouseoverOverridesSelected;

		public bool ShowLabel_When_MouseOver => false;

		public bool ShowLabel_When_Selected => false;

		public bool ShowLabel_When_NoMouseOverNoSelected => false;

		public Sprite Halo_Selected => null;

		public Sprite Halo_MouseOver => null;

		public Sprite Halo_NoMouseOverNoSelected => null;

		public bool Halo_MouseoverOverridesSelected => false;
	}
}
