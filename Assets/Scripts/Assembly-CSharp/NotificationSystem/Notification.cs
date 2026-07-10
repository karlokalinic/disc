namespace NotificationSystem
{
	public class Notification
	{
		public bool Breaked;

		public NotificationType Type { get; protected set; }

		public NotificationScriptableObject Settings { get; protected set; }

		public string HeaderText { get; protected set; }

		public string DescriptionText { get; protected set; }

		public bool HaveIcon { get; protected set; }

		public bool HaveSecondaryIcons { get; protected set; }

		public bool HaveDescription { get; protected set; }

		public Notification(NotificationType type)
		{
		}

		public Notification(NotificationType type, string descriptionText = "")
		{
		}

		public void BreakNotification()
		{
		}

		public bool HaveTheSameContent(Notification n)
		{
			return false;
		}

		public virtual void PrepareTexts()
		{
		}

		public virtual void PrepareHeader()
		{
		}

		public virtual void PrepareDescription()
		{
		}
	}
}
