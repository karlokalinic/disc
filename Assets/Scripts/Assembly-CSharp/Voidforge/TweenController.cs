using System.Collections.Generic;
using UnityEngine;

namespace Voidforge
{
	public class TweenController : Tween
	{
		public enum PlayType
		{
			ALL = 0,
			SUBSET = 1,
			CYCLIC = 2
		}

		[SerializeField]
		protected Tween[] controlledTweens;

		[SerializeField]
		protected bool getFromHierarchy;

		[SerializeField]
		protected bool randomOrder;

		[SerializeField]
		protected bool playSequentially;

		[SerializeField]
		protected PlayType playType;

		[SerializeField]
		protected int subsetSize;

		protected List<Tween> _playList;

		protected int _playStartIndex;

		protected int _playFinishIndex;

		protected int _playCurrentIndex;

		protected float duration => 0f;

		protected bool isReady
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void ControleeStatus(Tween controlee, bool status)
		{
		}

		public bool IsControleePlaying(Tween controlee)
		{
			return false;
		}

		private void AdvancePlaylist()
		{
		}

		protected override void OnFinishPlaying()
		{
		}

		protected override void Repaint()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
