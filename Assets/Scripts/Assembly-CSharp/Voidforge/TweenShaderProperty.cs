using UnityEngine;

namespace Voidforge
{
	public class TweenShaderProperty : TweenValue<float>
	{
		public string propertyName;

		public AnimationCurve propertyCurve;

		private MaterialPropertyBlock block;

		[GetComponent]
		protected ComponentRef<Renderer> renderers;

		protected int? _propertyID;

		public override float Item => 0f;

		protected float duration => 0f;

		protected int propertyID => 0;

		protected override void Repaint()
		{
		}
	}
}
