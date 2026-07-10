using UnityEngine;
using Voidforge;

namespace FortressOccident
{
	public class FX : SingletonComponent<FX>
	{
		public SpriteRenderer obj;

		public FXSettings[] settings;

		public FXSettings settingsTimeFreeze;

		public AnimationCurve heartbeats;

		public float heartbeatSpeed;

		public float overrideEval;

		public float evalDebug;

		public int currentlyPlaying;

		public PostFX post;

		public AnimationCurve bathroomZoomCurve;

		public Material vignetteMaterial;

		public Texture2D vignetteTexture;

		public Texture2D vignetteDarkTexture;

		private bool vignetteEnabled;

		private float dir;

		private float dirTimeFreeze;

		public static bool tequilaHasWokenUp;

		public bool timeFreezeActive;

		private float counter;

		private float counterTimefreeze;

		public void PlayIntroHangover()
		{
		}

		public void PlayEnduranceLoss()
		{
		}

		public void PlayEnduranceGain()
		{
		}

		public void PlayVolitionLoss()
		{
		}

		public void fan_light_hurts()
		{
		}

		public void PlayVolitionGain()
		{
		}

		public void PlayRedcheckFail()
		{
		}

		public void PlayRedcheckPass()
		{
		}

		public void PlayTimefreeze()
		{
		}

		public void Stop()
		{
		}

		public void Play(string name)
		{
		}

		public void DisableVignette()
		{
		}

		private void Debugger()
		{
		}

		private void AnimateMaterial(float eval)
		{
		}

		private void AnimateMaterialTimeFreeze(float eval)
		{
		}

		private void AnimateVignette(float to = 0f)
		{
		}

		private void Update()
		{
		}
	}
}
