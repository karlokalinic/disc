using UnityEngine;

namespace Voidforge
{
	public class TweenAddForce : Tween, Tween.IBeforePlaying
	{
		public enum Function
		{
			EXPLOSIONFORCE = 0,
			FORCE = 1,
			FORCEATPOSITION = 2,
			RELATIVEFORCE = 3,
			RELATIVETORQUE = 4,
			TORQUE = 5
		}

		public Function function;

		public Vector3 force;

		public Vector3 position;

		public ForceMode mode;

		[SerializeField]
		protected float _duration;

		protected float lastTweenTime;

		[GetComponent]
		protected ComponentRef<Rigidbody> rbody;

		[GetComponent]
		protected ComponentRef<Rigidbody2D> rbody2D;

		public float duration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isInstantMode => false;

		void IBeforePlaying.BeforePlaying()
		{
		}

		protected override void Repaint()
		{
		}

		protected void AddForce3D(Rigidbody rb, float quant)
		{
		}

		protected void AddForce2D(Rigidbody2D rb, float quant)
		{
		}

		protected void Reset()
		{
		}
	}
}
