using System.Collections;
using UnityEngine;

namespace Sunshine
{
	public class PleasureWheelSwitcher : StateSwitcher
	{
		public float fadeTime;

		private MeshRenderer[] allMeshes;

		private SpriteRenderer[] allSprites;

		private Renderer[] allPSRenderers;

		private float count;

		private float fadePosition;

		public new void Awake()
		{
		}

		public override void BecomeActive()
		{
		}

		public override void StopBeingActive()
		{
		}

		private IEnumerator Fade(bool to)
		{
			return null;
		}

		private void SetFade(float fade)
		{
		}
	}
}
