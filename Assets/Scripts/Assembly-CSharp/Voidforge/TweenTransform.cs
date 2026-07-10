using UnityEngine;

namespace Voidforge
{
	public class TweenTransform : Tween, Tween.IBeforePlaying
	{
		[SerializeField]
		protected bool tweenPosition;

		[SerializeField]
		protected Vector3 position;

		[SerializeField]
		protected bool tweenRotation;

		[SerializeField]
		protected Vector3 rotation;

		[SerializeField]
		protected bool tweenScale;

		[SerializeField]
		protected Vector3 scale;

		[SerializeField]
		protected float duration;

		protected Vector3 fromPosition;

		protected Quaternion fromRotation;

		protected Vector3 fromScale;

		protected Vector3 toPosition;

		protected Quaternion toRotation;

		protected Vector3 toScale;

		void IBeforePlaying.BeforePlaying()
		{
		}

		public void SetTarget(Vector3? position, Quaternion? rotation, Vector3? scale)
		{
		}

		protected override void Repaint()
		{
		}

		protected override void Start()
		{
		}
	}
}
