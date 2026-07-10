using System;
using UnityEngine;

namespace Voidforge
{
	public class TweenColor : TweenAlpha
	{
		[Flags]
		public enum Channel
		{
			None = 0,
			Alpha = 1,
			Red = 2,
			Green = 4,
			Blue = 8,
			RGB = 0xE,
			RGBA = 0xF,
			RedAlpha = 3,
			GreenAlpha = 5,
			BlueAlpha = 9,
			RedGreen = 6,
			RedBlue = 0xA,
			GreenBlue = 0xC,
			RedGreenAlpha = 7,
			RedBlueAlpha = 0xB,
			GreenBlueAlpha = 0xD
		}

		public AnimationCurve red;

		public AnimationCurve green;

		public AnimationCurve blue;

		public Channel channelMask;

		public new bool Item
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override float duration => 0f;

		protected override Color GetColor(Color normalColor)
		{
			return default(Color);
		}
	}
}
