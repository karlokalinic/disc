using Voidforge;

namespace Sunshine
{
	public class EnddayManager : SingletonComponent<EnddayManager>
	{
		public const string CAN_SLEEP = "auto.daychange_can_sleep";

		public const string DEBRIEF_DONE = "TASK.debrief_with_kim_day_one_done";

		public const string KIM_TRIGGER_NAME = "auto.daychange_kim_alert";

		public const string KIM_TRIGGER_ACTIVATED_NAME = "auto.daychange_kim_alert_activated";

		public const string HAS_PAID = "auto.daychange_whirling_paid";

		public const string HAS_SLEPT = "auto.daychange_has_slept";

		public const string IN_TEQUILA_ROOM = "auto.inside_tequila_room";

		private CutsceneSituation _currentDream;

		protected SunshineClockTime restTime;

		public CutsceneSituation CurrentDream
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SunshineClockTime RestTime => null;

		public static bool HasDoorDialogue => false;

		public static bool CanSleep
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool HasSlept
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool HasDebriefed => false;

		public static bool HasPaid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool InTequilaRoom => false;

		public static bool KimHasWorried
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool LockedElectronically => false;

		public static bool IsTired()
		{
			return false;
		}

		protected override void Awake()
		{
		}

		public static void NewGame()
		{
		}

		public void OnTimeChanged()
		{
		}

		private void LockTequilaDoorWhilePresent()
		{
		}

		public void CallItADay()
		{
		}

		public void LetterFaint()
		{
		}

		public void SeaFortSleepDream()
		{
		}

		public void SeaFortSleepNoDream()
		{
		}

		public void TestExitDream()
		{
		}

		public void KimDebriefing()
		{
		}

		public void TribunalEnd()
		{
		}

		public static void ExitDream()
		{
		}

		public static void ExitDreamSeaFort()
		{
		}

		protected void DreamScene()
		{
		}
	}
}
