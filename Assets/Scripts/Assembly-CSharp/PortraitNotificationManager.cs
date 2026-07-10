using UnityEngine;

public class PortraitNotificationManager : MonoBehaviour
{
	[SerializeField]
	private LevelUpPortraitNotification levelUpNotification;

	[SerializeField]
	private KimTalkPortraitNotification kimTalkNotification;

	private PortraitVisualizer potraitVisualizer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ShowNotification(PortraitNotificationType type)
	{
	}

	public void HideNotification(PortraitNotificationType type)
	{
	}

	public void PauseAnimations()
	{
	}

	public void ResumeAnimations(bool dialogueEnding)
	{
	}
}
