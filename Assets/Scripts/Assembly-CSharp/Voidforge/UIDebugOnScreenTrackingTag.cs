using UnityEngine.UI;

namespace Voidforge
{
	public class UIDebugOnScreenTrackingTag : UITargetTracker
	{
		[GetComponent]
		protected ComponentRef<Graphic> graphic;

		protected override void OnTargetVisibility(bool isVisible)
		{
		}
	}
}
