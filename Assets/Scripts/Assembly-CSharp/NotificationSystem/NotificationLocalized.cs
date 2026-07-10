namespace NotificationSystem
{
	public class NotificationLocalized : Notification
	{
		private string term;

		public NotificationLocalized(NotificationType type, string term)
			: base(default(NotificationType))
		{
		}

		public override void PrepareDescription()
		{
		}
	}
}
