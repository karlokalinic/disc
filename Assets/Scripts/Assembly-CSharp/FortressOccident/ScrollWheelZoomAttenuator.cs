using System;
using Voidforge;

namespace FortressOccident
{
	internal class ScrollWheelZoomAttenuator : DSP<float>
	{
		public ScrollWheelZoomAttenuator(int size)
			: base(0, (Func<float, float, float, float>)null)
		{
		}
	}
}
