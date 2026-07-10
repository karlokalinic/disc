using System.Collections.Generic;
using Sunshine.Metric;
using Voidforge;

public class ThoughtCabinetProjectList : SingletonComponent<ThoughtCabinetProjectList>
{
	private const string DISPLAY_NAME_FIELD = "DisplayName";

	private const string DESCRIPTION_FIELD = "Description";

	private const string COMPLETION_DESCRIPTION_FIELD = "CompletionDescription";

	private const string TOOLTIP_FIELD_QUIP = "QuipLine";

	private const string TOOLTIP_FIELD_STRING = "StringParameter";

	private const string REPUTATION_BONUS_FIELD = "ReputationBonus";

	private const string COMPLETION_CATEGORY = "Completion";

	private const string RESEARCH_CATEGORY = "Research";

	public ThoughtListItem[] projects;

	protected Dictionary<string, ThoughtCabinetProject> string2thc;

	protected Dictionary<ThoughtCabinetProject, string> thc2string;

	protected override void Awake()
	{
	}

	protected void RefreshCache()
	{
	}

	public ThoughtCabinetProject GetByName(string name)
	{
		return null;
	}

	public string GetName(ThoughtCabinetProject project)
	{
		return null;
	}

	protected void TestCache()
	{
	}

	public void ResetTHCProjects()
	{
	}
}
