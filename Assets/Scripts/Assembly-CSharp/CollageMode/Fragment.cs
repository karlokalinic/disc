using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class Fragment : CollageElement
	{
		public new class InitData : CollageElement.InitData
		{
			public Vector3 Position;
		}

		[SerializeField]
		protected Canvas canvas;

		[SerializeField]
		protected Image image;

		[SerializeField]
		protected Image outlineImage;

		[SerializeField]
		private float snapDistance;

		[SerializeField]
		private float selectionBorderSize;

		private HiddenImageFragmentData imagePartData;

		private FragmentsCluster currentCluster;

		public override string DisplayTerm => null;

		public string Name => null;

		public HiddenImageCompleteData FullImageData => null;

		public FragmentsCluster CurrentCluster => null;

		protected override bool CanRotate => false;

		protected override bool CanScale => false;

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

		protected override void InitialPlacementSubmitted()
		{
		}

		protected override void MoveSubmitted()
		{
		}

		protected override void MoveStarted()
		{
		}

		protected override void RefreshSelectionVisual(bool isSelected)
		{
		}

		private void SnapToNearestFragment()
		{
		}

		public override void Init(CollageElement.InitData initData)
		{
		}

		public override CollageElement.InitData GetInitData()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
