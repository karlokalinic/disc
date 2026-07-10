using TMPro;
using Voidforge;

public class TutorialTooltip : SingletonComponent<TutorialTooltip>
{
	private Timer runningTimer;

	private TweeningCanvasGroup tweener;

	public TextMeshProUGUI targetText;

	private bool isPaused;

	public bool HasTooltip { get; private set; }

	protected override void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ShowTestTooltip()
	{
	}

	public void ShowTooltip(string tooltipText, float time)
	{
	}

	public void PauseTooltip()
	{
	}

	public void ResumeTooltip()
	{
	}

	public void HideTooltip(bool now = true)
	{
	}
}
