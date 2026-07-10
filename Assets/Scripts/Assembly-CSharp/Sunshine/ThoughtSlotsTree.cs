using System.Collections.Generic;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.UI;
using Voidforge;

namespace Sunshine
{
	public class ThoughtSlotsTree : LiteSingleton<ThoughtSlotsTree>
	{
		[SerializeField]
		private Selectable rightSelectable;

		[SerializeField]
		private Selectable leftSelectable;

		[SerializeField]
		private ThoughtSlot slotPrefab;

		[SerializeField]
		[Space]
		private ThoughtSlot[] slots;

		[Space]
		[SerializeField]
		private List<RectTransform> columns;

		[Space]
		private List<ThoughtSlot> openSlots;

		private List<ThoughtSlot> buyableSlots;

		private List<ThoughtSlot> lockedSlots;

		private List<ThoughtSlot> filledSlots;

		[Space]
		private List<ThoughtSlot> recentlyDiscoveredThoughts;

		public const int numberofSlots = 12;

		public ThoughtSlot[] Slots => null;

		public ThoughtSlot SelectedSlot { get; private set; }

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetRightmostSelectable(Selectable selectable)
		{
		}

		private void OnLanguageChanged()
		{
		}

		public bool AddThoughtProject(ThoughtCabinetProject project)
		{
			return false;
		}

		public void RemoveThoughtProject(ThoughtCabinetProject project)
		{
		}

		public void UnlockSlots(int count = 1)
		{
		}

		private ThoughtSlot GetSlot(int slotIndex)
		{
			return null;
		}

		public void BuySlot(int slotIndex)
		{
		}

		public void BuySlot()
		{
		}

		private void BuySlot(ThoughtSlot slot)
		{
		}

		public ThoughtSlot GetBuyableSlot()
		{
			return null;
		}

		public void ResetTree()
		{
		}

		public void RefreshTree()
		{
		}

		public void BakeThoughts(int timePassed)
		{
		}

		public void Initialize()
		{
		}

		public ThoughtSlot ReturnFirstFreeSlot()
		{
			return null;
		}

		public bool IsFilled(ThoughtSlot slot)
		{
			return false;
		}

		public bool IsFilled(int index)
		{
			return false;
		}

		public bool HaveOpenSlots()
		{
			return false;
		}

		public void AddDiscoveredThought(ThoughtCabinetProject project)
		{
		}

		public void RunDiscoveredThoughtAnimation()
		{
		}

		private void RegisterThoughtToCabinet(ThoughtCabinetProject thcp)
		{
		}

		private void ConnectEvents()
		{
		}

		private void Restart()
		{
		}

		private void SelectEmptySlot(ThoughtSlot slot)
		{
		}

		public void DeselectSelectedSlot()
		{
		}

		private void SelectSlot(ThoughtCabinetProject project, bool fromList)
		{
		}

		private void SetupNewBuyableSlot(int index)
		{
		}

		public bool AddThoughtProjectToSlot(int slotIndex, ThoughtCabinetProject project)
		{
			return false;
		}

		private bool AddThoughtProjectToSlot(ThoughtSlot slot, ThoughtCabinetProject project)
		{
			return false;
		}

		private ThoughtSlot ReturnSlotWithProject(ThoughtCabinetProject project)
		{
			return null;
		}

		public ThoughtSlot[] GetAllSlotsForPersistence()
		{
			return null;
		}

		public void RestoreSlotStates(Tuple<ThoughtSlot.SlotState, string>[] slotStates)
		{
		}

		public void SelectDefault()
		{
		}
	}
}
