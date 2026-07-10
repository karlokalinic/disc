using System.Collections.Generic;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		private enum WaitForSoundFinishMode
		{
			None = 0,
			Delay = 1,
			Play = 2,
			WaitForEnd = 3,
			StopOrRepeat = 4,
			FxTailWait = 5
		}

		private Transform _objectToFollow;

		private GameObject _objectToFollowGo;

		private bool _isFollowing;

		private SoundGroupVariation _variation;

		private float _priorityLastUpdated;

		private bool _useClipAgePriority;

		private WaitForSoundFinishMode _waitMode;

		private float _soundPlayTime;

		private float _fadeOutStartTime;

		private bool _fadeInOutWillFadeOut;

		private bool _hasFadeInOutSetMaxVolume;

		private float _fadeInOutInFactor;

		private float _fadeInOutOutFactor;

		private int _fadeOutEarlyTotalFrames;

		private float _fadeOutEarlyFrameVolChange;

		private int _fadeOutEarlyFrameNumber;

		private float _fadeOutEarlyOrigVol;

		private float _fadeToTargetFrameVolChange;

		private int _fadeToTargetFrameNumber;

		private float _fadeToTargetOrigVol;

		private int _fadeToTargetTotalFrames;

		private float _fadeToTargetVolume;

		private bool _fadeOutStarted;

		private float _lastFrameClipTime;

		private float _fxTailEndTime;

		private bool _isPlayingBackward;

		private bool _hasStartedNextInChain;

		private static HashSet<SoundGroupVariationUpdater> registry;

		private static Queue<SoundGroupVariationUpdater> queue;

		private Transform Trans => null;

		private AudioSource VarAudio => null;

		private MasterAudioGroup ParentGroup => null;

		private SoundGroupVariation GrpVariation => null;

		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		public void FadeOutEarly(float fadeTime)
		{
		}

		public void FadeInOut()
		{
		}

		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		public void WaitForSoundFinish(float delaySound)
		{
		}

		public void StopFading()
		{
		}

		public void StopWaitingForFinish()
		{
		}

		public void StopFollowing()
		{
		}

		private void DisableIfFinished()
		{
		}

		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		private void PlaySoundAndWait()
		{
		}

		private void StopOrChain()
		{
		}

		private void MaybeChain()
		{
		}

		private void PerformFading()
		{
		}

		public static void LateUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void _LateUpdate()
		{
		}
	}
}
