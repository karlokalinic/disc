namespace NotificationSystem
{
	public class NotificationFinishedTask : Notification
	{
		private int xpAmount;

		private string format;

		private string taskNameTerm;

		private string suffixTerm;

		public NotificationFinishedTask(NotificationType type, string format, string taskNameTerm, int xpAmount, string suffixTerm)
			: base(default(NotificationType))
		{
		}

		public override void PrepareDescription()
		{
		}
	}
}
