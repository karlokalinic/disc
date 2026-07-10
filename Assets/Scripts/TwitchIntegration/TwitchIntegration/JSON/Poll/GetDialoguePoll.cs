using System;

namespace TwitchIntegration.JSON.Poll
{
	[Serializable]
	public class GetDialoguePoll
	{
		public string channel_id;

		public bool closed;

		public string prompt;

		public Options[] options;

		public int[] votes;

		public int TotalVotes { get; private set; }

		public int IdOfHighestVote { get; private set; }

		public void CountTotalVotesAndFindHighestVote()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string VotesToString()
		{
			return null;
		}

		public float GetPercentage(int voteOptionPosition)
		{
			return 0f;
		}

		public int GetVoteCountForPosition(int voteOptionPosition)
		{
			return 0;
		}
	}
}
