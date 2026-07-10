using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class Sticker : CollageElement
	{
		public new class InitData : CollageElement.InitData
		{
			public Vector3 Position;

			public float Rotation;

			public float Scale;
		}

		[SerializeField]
		protected float smoothFactor;

		[SerializeField]
		private Canvas canvas;

		[SerializeField]
		protected Image image;

		[SerializeField]
		protected Image outlineImage;

		public override string DisplayTerm => null;

		public override bool UsesSortingOrder => false;

		public override int SortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		public override void Init(CollageElement.InitData initData)
		{
		}

		public override CollageElement.InitData GetInitData()
		{
			return null;
		}

		protected override void InitialPlacementSubmitted()
		{
		}

		protected override void MoveSubmitted()
		{
		}

		protected override void RotateSubmitted()
		{
		}

		protected override void RefreshSelectionVisual(bool isSelected)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
