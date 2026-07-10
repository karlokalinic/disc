namespace NotificationSystem
{
	public class NotificationXP : Notification
	{
		private int amount;

		private string format;

		private string suffixTerm;

		public NotificationXP(NotificationType type, string format, int amount, string suffixTerm)
			: base(default(NotificationType))
		{
		}

		public override void PrepareDescription()
		{
		}
	}
}
