using TMPro;

public class PipVisualizer : TextMeshProUGUI
{
	public const string PIPSTYLES = "◆";

	public char fillChar;

	public char emptyChar;

	public int current;

	public int max;

	protected override void Awake()
	{
	}

	public void SetValues(int current, int max = 0)
	{
	}

	public void UpdateValues()
	{
	}
}
