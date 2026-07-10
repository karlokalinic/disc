using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public abstract class BarkStarter : ConversationStarter
	{
		public BarkOrder barkOrder;

		public bool allowDuringConversations;

		public bool cacheBarkLines;

		private BarkHistory barkHistory;

		private bool tryingToBark;

		private ConversationState cachedState;

		private IBarkUI barkUI;

		protected BarkGroupMember barkGroupMember;

		public Sequencer sequencer { get; private set; }

		public int BarkIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void TryBark(Transform target)
		{
		}

		public void TryBark(Transform target, Transform interactor)
		{
		}

		private Transform GetBarker()
		{
			return null;
		}

		private string GetBarkerName()
		{
			return null;
		}

		private void BarkCachedLine(Transform speaker, Transform listener)
		{
		}

		private void PopulateCache(Transform speaker, Transform listener)
		{
		}

		private void BarkNextCachedLine(Transform speaker, Transform listener)
		{
		}

		public void ResetBarkHistory()
		{
		}

		public void OnRecordPersistentData()
		{
		}

		public void OnApplyPersistentData()
		{
		}
	}
}
