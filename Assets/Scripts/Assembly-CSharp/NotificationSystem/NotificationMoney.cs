namespace NotificationSystem
{
	public class NotificationMoney : Notification
	{
		private int amount;

		private string prefix;

		private string suffixTerm;

		public NotificationMoney(NotificationType type, string prefix, int amount, string suffixTerm)
			: base(default(NotificationType))
		{
		}

		public override void PrepareDescription()
		{
		}
	}
}
