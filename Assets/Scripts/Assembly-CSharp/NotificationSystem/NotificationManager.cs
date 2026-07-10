using System;
using System.Collections.Generic;
using UnityEngine;

namespace NotificationSystem
{
	public class NotificationManager : LiteSingleton<NotificationManager>
	{
		private List<Notification> _notificationsToShow;

		private Notification _currentlyPlayedNotification;

		private bool _isNotificationPlayed;

		private Coroutine _animationCoroutine;

		[SerializeField]
		private List<NotificationScriptableObject> _notificationSettingsList;

		[SerializeField]
		private DiceRollsScriptableObject _diceRollsData;

		[SerializeField]
		private NotificationPanel _notificationPanel;

		public static Dictionary<NotificationType, NotificationScriptableObject> _settingsDict { get; private set; }

		protected override void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}

		public void ShowNotification(NotificationType notificationType, string text)
		{
		}

		public void ShowLocalizedDescriptionNotification(NotificationType notificationType, string term)
		{
		}

		public void ShowNotification(Notification notification)
		{
		}

		public void ShowNotification(Notification notification, out Action breakNotificationAction)
		{
			breakNotificationAction = null;
		}

		public void CancelNotifications()
		{
		}

		public void BreakNotification(Notification notification)
		{
		}

		public void SetupDiceNotification(NotificationType notificationType, int firstRoll, int secondRoll)
		{
		}

		private void AddNotification(Notification notification)
		{
		}

		private void ForceStopNotificationTaskUpdated()
		{
		}

		private void PlayNextNotification()
		{
		}

		private void EndPlayingNotification()
		{
		}

		public void ClearNotifications()
		{
		}
	}
}
