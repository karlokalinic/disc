namespace Voidforge
{
	public class TweenDeactivate : Tween
	{
		public bool destroyGameObject;

		protected float duration => 0f;

		protected override void OnFinishPlaying()
		{
		}

		protected override void Repaint()
		{
		}
	}
}
