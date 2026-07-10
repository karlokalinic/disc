using System.Runtime.CompilerServices;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class SoundGroupVariation : MonoBehaviour
	{
		public delegate void SoundFinishedEventHandler();

		public class PlaySoundParams
		{
			public string SoundType;

			public float VolumePercentage;

			public float? Pitch;

			public Transform SourceTrans;

			public bool AttachToSource;

			public float DelaySoundTime;

			public bool IsChainLoop;

			public bool IsSingleSubscribedPlay;

			public float GroupCalcVolume;

			public bool IsPlaying;

			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		public enum FadeMode
		{
			None = 0,
			FadeInOut = 1,
			FadeOutEarly = 2,
			GradualFade = 3
		}

		public enum RandomPitchMode
		{
			AddToClipPitch = 0,
			IgnoreClipPitch = 1
		}

		public enum RandomVolumeMode
		{
			AddToClipVolume = 0,
			IgnoreClipVolume = 1
		}

		public enum DetectEndMode
		{
			None = 0,
			DetectEnd = 1
		}

		public int weight;

		public bool useLocalization;

		public bool useRandomPitch;

		public RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public string internetFileUrl;

		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		public float fxTailTime;

		public float original_pitch;

		public float original_volume;

		public bool isExpanded;

		public bool isChecked;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public float fadeMaxVolume;

		public FadeMode curFadeMode;

		public DetectEndMode curDetectEndMode;

		public int frames;

		private float initSpreadValue;

		private AudioSource _audioSource;

		private readonly PlaySoundParams _playSndParam;

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private bool _isWaitingForDelay;

		private float _maxVol;

		private int _instanceId;

		private bool? _audioLoops;

		private SoundGroupVariationUpdater _varUpdater;

		private int _previousSoundFinishedFrame;

		private Transform _trans;

		private GameObject _go;

		private AudioSource _aud;

		private Transform _objectToFollow;

		private Transform _objectToTriggerFrom;

		private MasterAudioGroup _parentGroupScript;

		private bool _attachToSource;

		private string _resFileName;

		public AudioDistortionFilter DistortionFilter => null;

		public AudioReverbFilter ReverbFilter => null;

		public AudioChorusFilter ChorusFilter => null;

		public AudioEchoFilter EchoFilter => null;

		public AudioLowPassFilter LowPassFilter => null;

		public AudioHighPassFilter HighPassFilter => null;

		public Transform ObjectToFollow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform ObjectToTriggerFrom
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasActiveFXFilter => false;

		public MasterAudioGroup ParentGroup => null;

		public float OriginalPitch => 0f;

		public float OriginalVolume => 0f;

		public string SoundGroupName => null;

		public bool IsAvailableToPlay => false;

		public float LastTimePlayed { get; set; }

		private int InstanceId => 0;

		public Transform Trans => null;

		public GameObject GameObj => null;

		public AudioSource VarAudio => null;

		public bool AudioLoops => false;

		public string ResFileName => null;

		public SoundGroupVariationUpdater VariationUpdater => null;

		public bool IsWaitingForDelay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PlaySoundParams PlaySoundParm => null;

		public bool IsPlaying => false;

		public float SetGroupVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private bool ShouldLoadAsync => false;

		public event SoundFinishedEventHandler SoundFinished
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

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetSpatialBlend()
		{
		}

		public void SetParamsToMono()
		{
		}

		public void RestoreStereoParams()
		{
		}

		public void LoadInternetFile()
		{
		}

		private void SetPriority()
		{
		}

		public void DisableUpdater()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void StopSoundEarly()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		private void InternetFileFailedToLoad()
		{
		}

		private void InternetFileLoaded()
		{
		}

		private void ResourceFailedToLoad()
		{
		}

		private void FinishSetupToPlay()
		{
		}

		public void JumpToTime(float timeToJumpTo)
		{
		}

		public void AdjustVolume(float volumePercentage)
		{
		}

		public void Pause()
		{
		}

		private void MaybeUnloadClip()
		{
		}

		public void Stop(bool stopEndDetection = false)
		{
		}

		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		public void FadeOutNow()
		{
		}

		public void FadeOutNow(float fadeTime)
		{
		}

		public bool WasTriggeredFromTransform(Transform trans)
		{
			return false;
		}

		public void ClearSubscribers()
		{
		}
	}
}
