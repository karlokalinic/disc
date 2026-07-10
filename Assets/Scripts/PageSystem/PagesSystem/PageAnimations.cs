using DG.Tweening;
using UnityEngine;

namespace PagesSystem
{
	public static class PageAnimations
	{
		public enum Direction
		{
			Left = 0,
			Right = 1,
			Up = 2,
			Down = 3
		}

		public const Ease DEFAULT_EASE = Ease.OutCubic;

		public const float DEFAULT_DURATION = 0.53f;

		public static Sequence SlideIn(RectTransform rectTransform, Direction dir, Ease ease = Ease.OutCubic, float duration = 0.53f)
		{
			return null;
		}

		public static Sequence SlideOut(RectTransform rectTransform, Direction dir, Ease ease = Ease.OutCubic, float duration = 0.53f)
		{
			return null;
		}

		public static Sequence FadeIn(CanvasGroup group, Ease ease = Ease.OutCubic, float duration = 0.53f)
		{
			return null;
		}

		public static Sequence FadeOut(CanvasGroup group, Ease ease = Ease.OutCubic, float duration = 0.53f)
		{
			return null;
		}
	}
}
