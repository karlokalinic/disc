using System.Collections.Generic;
using UnityEngine;
using Voidforge;

public class ThoughtNotBakingTracker : SingletonComponent<ThoughtNotBakingTracker>
{
	private List<string> notBakeDialogues;

	public bool IsBakingBlocked { get; private set; }

	private void Start()
	{
	}

	private void OnConversationStart(Transform actor)
	{
	}

	private void OnConversationEnd(Transform actor)
	{
	}
}
