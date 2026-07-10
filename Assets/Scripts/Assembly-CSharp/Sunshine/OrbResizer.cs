using UnityEngine;
using Voidforge;

namespace Sunshine
{
	public class OrbResizer : CameraTrackingTagListener
	{
		[SerializeField]
		protected AnimationCurve orbScale;

		protected ComponentRef<OrbUiElement> orbUiElement;

		protected override void SetParameters(float zoom)
		{
		}
	}
}
