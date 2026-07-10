using System.Collections.Generic;
using Voidforge;

public class NewspaperEndgamesList : SingletonComponent<NewspaperEndgamesList>
{
	private const string TITLE_FIELD = "Title";

	private const string DESCRIPTION_FIELD = "Description";

	public List<NewspaperEndgameListItem> projects;

	protected Dictionary<string, NewspaperEndgame> string2endgames;

	protected override void Awake()
	{
	}

	protected void RefreshCache()
	{
	}

	public NewspaperEndgame GetByName(string name)
	{
		return null;
	}
}
