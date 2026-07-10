using UnityEngine;

namespace Sunshine.Metric
{
	public class PlayerCharacter : LiteSingleton<PlayerCharacter>
	{
		[SerializeField]
		private int xpAmount;

		[SerializeField]
		private int level;

		[SerializeField]
		private int skillPoints;

		public bool NewPointsToSpend;

		[SerializeField]
		private int money;

		public PlayerCharacterHealingPools healingPools;

		public int TotalXpAmount => 0;

		public int XpAmount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SkillPoints
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Money
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public object NotificationHelper { get; private set; }

		protected override void Awake()
		{
		}

		public void InitializeHealingPools()
		{
		}

		public bool HasHealingPoolsForSkill(SkillType skillType)
		{
			return false;
		}

		private void HandleLevelUp()
		{
		}

		public void NewGame()
		{
		}

		public void MidGame()
		{
		}
	}
}
