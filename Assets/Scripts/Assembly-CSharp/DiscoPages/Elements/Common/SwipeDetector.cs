using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DiscoPages.Elements.Common
{
	public class SwipeDetector : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		public struct SwipeData
		{
			public Vector2 StartPosition;

			public Vector2 CurrentPosition;

			public Vector2 EndPosition;

			public SwipeDirection Direction;

			public bool IsEndDrag;

			public Vector2 GetCurrentDirectionVector => default(Vector2);

			public Vector2 GetFromStartDirectionVector => default(Vector2);

			public bool SwipeDistanceCheckMet(float minSwipeDistance)
			{
				return false;
			}

			public float VerticalMovementDistance()
			{
				return 0f;
			}

			public float HorizontalMovementDistance()
			{
				return 0f;
			}
		}

		public enum SwipeDirection
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3
		}

		private static SwipeDetector Current;

		[SerializeField]
		private bool useGlobalEvent;

		[SerializeField]
		private bool stopDetectingSwipesAfterFirstOne;

		[SerializeField]
		private bool releaseToSwipe;

		[SerializeField]
		private float minSwipeDistance;

		private static int detectorsDragging;

		private Vector2 fingerStartPosition;

		private Vector2 fingerLastDownPosition;

		private Vector2 fingerUpPosition;

		private bool isSwiping;

		private bool hasSwipingStarted;

		private bool draggingStarted;

		public static bool IsAnyDetectorDragging => false;

		public bool GetUseGlobalEvent => false;

		public static event Action<SwipeData> OnSwipe
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<SwipeData> OnSwipeStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<SwipeData> OnSwipeEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<SwipeData> onSwipeLocal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<SwipeData> onSwipeLocalStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<SwipeData> onSwipeLocalEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void DetectSwipe(bool isEndDrag)
		{
		}

		private bool SwipeDistanceCheckMet()
		{
			return false;
		}

		private float VerticalMovementDistance()
		{
			return 0f;
		}

		private float HorizontalMovementDistance()
		{
			return 0f;
		}

		private bool IsVerticalSwipe()
		{
			return false;
		}

		private void SendSwipe(SwipeDirection direction, bool isEndDrag)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		private void OnDisable()
		{
		}
	}
}
