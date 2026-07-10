namespace Pages
{
	public class SubPage : DiscoPage
	{
		public virtual bool HideQuickAccessBar => false;

		public virtual bool HideMoneyTimePortraits => false;

		public virtual bool HideMainMenuButton => false;
	}
}
