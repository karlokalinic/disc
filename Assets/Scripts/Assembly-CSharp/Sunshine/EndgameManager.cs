using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Voidforge;

namespace Sunshine
{
	public class EndgameManager : SingletonComponent<EndgameManager>
	{
		public static EndgameType endgameType;

		public static string NewspaperToShow;

		public static bool showCredits;

		public static bool trashBinAchievement;

		private Dictionary<string, Voidforge.Tuple<string, string>> Newspapers;

		private const string GAME_OVER_DIALOGUE_FRAGMENT_ARTICY_ID = "0x0100008900000C9F";

		public event Action OnGenericEndgame
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Start()
		{
		}

		private void LoadNewspapers()
		{
		}

		private void ParseNewspaper(string luaFunctionCall)
		{
		}

		protected override void OnDestroy()
		{
		}

		private void GenericEndgame()
		{
		}

		private void CreditsEndgame()
		{
		}

		public void NewspaperEndgame(string type, string title, string opener)
		{
		}

		public void PosseEndgame()
		{
		}

		public void QueuedNewspaperEndgame()
		{
		}

		private void _NewspaperEndgame(string title, string opener)
		{
		}

		public void TheReturnEndgame()
		{
		}
	}
}
