using Sunshine.Metric;

public interface ICharsheetSelecteble
{
	void UpdateSelectionVisuals();

	Modifiable GetModifiable();

	string GetGameObjectName();

	bool HaveInfoTabAvailable();
}
