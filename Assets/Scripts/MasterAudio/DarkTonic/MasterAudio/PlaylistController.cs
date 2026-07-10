using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

namespace DarkTonic.MasterAudio
{
	public class PlaylistController : MonoBehaviour
	{
		public delegate void SongChangedEventHandler(string newSongName);

		public delegate void SongEndedEventHandler(string songName);

		public enum AudioPlayType
		{
			PlayNow = 0,
			Schedule = 1,
			AlreadyScheduled = 2
		}

		public enum PlaylistStates
		{
			NotInScene = 0,
			Stopped = 1,
			Playing = 2,
			Paused = 3,
			Crossfading = 4
		}

		public enum FadeMode
		{
			None = 0,
			GradualFade = 1
		}

		public enum AudioDuckingMode
		{
			NotDucking = 0,
			SetToDuck = 1,
			Ducked = 2
		}

		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		private const float MinSongLength = 0.5f;

		private float desiredVolume;

		public bool startPlaylistOnAwake;

		public bool isShuffle;

		public bool isAutoAdvance;

		public bool loopPlaylist;

		public float _playlistVolume;

		public bool isMuted;

		public string startPlaylistName;

		public int syncGroupNum;

		public AudioMixerGroup mixerChannel;

		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		public float spatialBlend;

		public bool songChangedEventExpanded;

		public string songChangedCustomEvent;

		public bool songEndedEventExpanded;

		public string songEndedCustomEvent;

		private AudioSource _activeAudio;

		private AudioSource _transitioningAudio;

		private float _activeAudioEndVolume;

		private float _transitioningAudioStartVolume;

		private float _crossFadeStartTime;

		private readonly List<int> _clipsRemaining;

		private int _currentSequentialClipIndex;

		private AudioDuckingMode _duckingMode;

		private float _timeToStartUnducking;

		private float _timeToFinishUnducking;

		private float _originalMusicVolume;

		private float _initialDuckVolume;

		private float _duckRange;

		private MusicSetting _currentSong;

		private GameObject _go;

		private string _name;

		private FadeMode _curFadeMode;

		private float _slowFadeTargetVolume;

		private float _slowFadeVolStep;

		private MasterAudio.Playlist _currentPlaylist;

		private float _lastTimeMissingPlaylistLogged;

		private Action _fadeCompleteCallback;

		private readonly List<MusicSetting> _queuedSongs;

		private bool _lostFocus;

		private AudioSource _audioClip;

		private AudioSource _transClip;

		private MusicSetting _newSongSetting;

		private bool _nextSongRequested;

		private bool _nextSongScheduled;

		private int _lastRandomClipIndex;

		private float _lastTimeSongRequested;

		private readonly Dictionary<AudioSource, double> _scheduledSongsByAudioSource;

		private static List<PlaylistController> _instances;

		private static int _songsPlayedFromPlaylist;

		private AudioSource _audio1;

		private AudioSource _audio2;

		private Transform _trans;

		private bool _willPersist;

		private AudioSource[] audioSources;

		private Coroutine spatialBlendTransition;

		public float DesiredVolume => 0f;

		private bool SongIsNonAdvancible => false;

		private bool ShouldLoadAsync => false;

		public bool ControllerIsReady { get; private set; }

		public PlaylistStates PlaylistState => default(PlaylistStates);

		public AudioSource ActiveAudioSource => null;

		public static List<PlaylistController> Instances
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject PlaylistControllerGameObject => null;

		public AudioSource CurrentPlaylistSource => null;

		public AudioClip CurrentPlaylistClip => null;

		public AudioClip FadingPlaylistClip => null;

		public AudioSource FadingSource => null;

		public bool IsCrossFading { get; private set; }

		public bool IsFading => false;

		public float PlaylistVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MasterAudio.Playlist CurrentPlaylist => null;

		public bool HasPlaylist => false;

		public string PlaylistName => null;

		private bool IsMuted => false;

		private bool PlaylistIsMuted
		{
			set
			{
			}
		}

		private float CrossFadeTime => 0f;

		private bool IsAutoAdvance => false;

		public GameObject GameObj => null;

		public string ControllerName => null;

		public bool CanSchedule => false;

		private Transform Trans => null;

		public int ClipsRemainingInCurrentPlaylist => 0;

		public event SongChangedEventHandler SongChanged
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

		public event SongEndedEventHandler SongEnded
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

		public void SetSpatialBlend()
		{
		}

		private void SetAudiosIfEmpty()
		{
		}

		private void SetAudioSpatialBlend(float blend)
		{
		}

		private void Start()
		{
		}

		private void CoUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void Update()
		{
		}

		public void SpatialBlendChange(float value, float duration)
		{
		}

		private IEnumerator SpatialBlendTransition(float value, float duration)
		{
			return null;
		}

		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		public void ClearQueue()
		{
		}

		public void ToggleMutePlaylist()
		{
		}

		public void MutePlaylist()
		{
		}

		public void UnmutePlaylist()
		{
		}

		public void UpdateDuckedVolumeMultiplier()
		{
		}

		public void PausePlaylist()
		{
		}

		public bool ResumePlaylist()
		{
			return false;
		}

		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		public void FadeToVolume(float targetVolume, float fadeTime, Action callback = null)
		{
		}

		public void PlayRandomSong()
		{
		}

		public void PlayARandomSong(AudioPlayType playType, bool isMidsong)
		{
		}

		private void RemoveRandomClip(int randIndex)
		{
		}

		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		public void PlayNextSong()
		{
		}

		public void PlayTheNextSong(AudioPlayType playType, bool isMidsong)
		{
		}

		private void AdvanceSongCounter()
		{
		}

		public void StopLoopingCurrentSong()
		{
		}

		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		public bool TriggerPlaylistClip(string clipName)
		{
			return false;
		}

		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolMultiplier)
		{
		}

		private void InitControllerIfNot()
		{
		}

		public void UpdateMasterVolume()
		{
		}

		public void StartPlaylist(string playlistName)
		{
		}

		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		public void RestartPlaylist()
		{
		}

		private void FadeOutPlaylist()
		{
		}

		private void InitializePlaylist()
		{
		}

		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		private void FillClips()
		{
		}

		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		public void FinishLoadingNewSong(AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		private void RemoveScheduledClip()
		{
		}

		private void ScheduleNextSong()
		{
		}

		private void FadeInScheduledSong()
		{
		}

		private double CalculateNextTrackStartTime()
		{
			return 0.0;
		}

		private void ScheduleClipPlay(double scheduledPlayTime)
		{
		}

		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		private void CeaseAudioSource(AudioSource source)
		{
		}

		private void SetDuckProperties()
		{
		}

		private void AudioDucking()
		{
		}

		private bool SongShouldLoop(MusicSetting setting)
		{
			return false;
		}

		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}
	}
}
