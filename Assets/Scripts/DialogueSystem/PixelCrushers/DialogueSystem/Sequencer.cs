using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using PixelCrushers.DialogueSystem.SequencerCommands;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class Sequencer : MonoBehaviour
	{
		private const string DefaultCameraAnglesResourceName = "Default Camera Angles";

		public bool disableInternalSequencerCommands;

		private bool m_hasCameraControl;

		private Camera m_originalCamera;

		private Vector3 m_originalCameraPosition;

		private Quaternion m_originalCameraRotation;

		private float m_originalOrthographicSize;

		private Transform m_speaker;

		private Transform m_listener;

		private List<QueuedSequencerCommand> m_queuedCommands;

		private List<SequencerCommand> m_activeCommands;

		private bool m_informParticipants;

		private bool m_closeWhenFinished;

		private Camera m_sequencerCameraSource;

		private Camera m_sequencerCamera;

		private GameObject m_alternateSequencerCameraObject;

		private GameObject m_cameraAngles;

		private bool m_isUsingMainCamera;

		private bool m_isPlaying;

		private static Dictionary<string, Type> m_cachedComponentTypes;

		private static Dictionary<string, string> m_shortcuts;

		private static Dictionary<string, Stack<string>> m_shortcutStack;

		private SequenceParser m_parser;

		private const float InstantThreshold = 0.001f;

		private static Regex ShortcutRegex;

		public static Sequencer s_awakeSequencer;

		public static string s_awakeEndMessage;

		public static Transform s_awakeSpeaker;

		public static Transform s_awakeListener;

		public static string[] s_awakeArgs;

		private List<int> m_setDialoguePanelPreviouslyOpenSubtitlePanels;

		private List<int> m_setDialoguePanelPreviouslyOpenMenuPanels;

		private static DisplaySettings.SubtitleSettings.ContinueButtonMode savedContinueButtonMode;

		public bool isPlaying => false;

		public GameObject cameraAngles => null;

		public Camera sequencerCamera => null;

		public Transform sequencerCameraTransform => null;

		public Transform speaker => null;

		public Transform listener => null;

		public Vector3 originalCameraPosition => default(Vector3);

		public Quaternion originalCameraRotation => default(Quaternion);

		public float originalOrthographicSize => 0f;

		public float subtitleEndTime { get; set; }

		public string entrytag { get; set; }

		public string entrytaglocal => null;

		public bool IsPlaying => false;

		public GameObject CameraAngles => null;

		public Camera SequencerCamera => null;

		public Transform SequencerCameraTransform => null;

		public Transform Speaker => null;

		public Transform Listener => null;

		public Vector3 OriginalCameraPosition => default(Vector3);

		public Quaternion OriginalCameraRotation => default(Quaternion);

		public float OriginalOrthographicSize => 0f;

		public float SubtitleEndTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public event Action FinishedSequenceHandler
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

		public static void Message(string message)
		{
		}

		public static void RegisterShortcut(string shortcut, string value)
		{
		}

		public static void UnregisterShortcut(string shortcut)
		{
		}

		public static string ReplaceShortcuts(string sequence)
		{
			return null;
		}

		private static void ReportUnrecognizedShortcuts(string sequence)
		{
		}

		public void UseCamera(Camera sequencerCamera, GameObject cameraAngles)
		{
		}

		public void UseCamera(Camera sequencerCamera, GameObject alternateSequencerCameraObject, GameObject cameraAngles)
		{
		}

		private void GetCameraAngles()
		{
		}

		private void GetCamera()
		{
		}

		private void DestroyCamera()
		{
		}

		private IEnumerator RestoreCamera()
		{
			return null;
		}

		public void SwitchCamera(Camera newCamera)
		{
		}

		public void TakeCameraControl()
		{
		}

		private void ReleaseCameraControl()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void OnDestroy()
		{
		}

		public void Update()
		{
		}

		private void FinishSequence()
		{
		}

		public void SetParticipants(Transform speaker, Transform listener)
		{
		}

		private void InformParticipants(string message)
		{
		}

		public void PlaySequence(string sequence)
		{
		}

		public void PlaySequence(string sequence, bool informParticipants, bool destroyWhenDone)
		{
		}

		public void PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
		}

		public void PlaySequence(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone, bool delayOneFrame)
		{
		}

		public IEnumerator PlaySequenceAfterOneFrame(string sequence, Transform speaker, Transform listener, bool informParticipants, bool destroyWhenDone)
		{
			return null;
		}

		public void PlayCommand(string commandName, bool required, float time, string message, string endMessage, params string[] args)
		{
		}

		public void PlayCommand(QueuedSequencerCommand commandRecord)
		{
		}

		public void PlayCommand(QueuedSequencerCommand commandRecord, string commandName, bool required, float time, string message, string endMessage, params string[] args)
		{
		}

		private bool IsTimePaused()
		{
			return false;
		}

		private void ActivateCommand(string commandName, string endMessage, Transform speaker, Transform listener, string[] args)
		{
		}

		private Type FindSequencerCommandType(string commandName)
		{
			return null;
		}

		public Type GetTypeFromName(string typeName)
		{
			return null;
		}

		private IEnumerator SendTimedSequencerMessage(string endMessage, float delay)
		{
			return null;
		}

		private void ActivateCommand(QueuedSequencerCommand queuedCommand)
		{
		}

		private void CheckQueuedCommands()
		{
		}

		public void OnSequencerMessage(string message)
		{
		}

		private void CheckActiveCommands()
		{
		}

		public void Stop()
		{
		}

		public void StopQueued()
		{
		}

		public void StopActive()
		{
		}

		private IEnumerator DestroyAfterOneFrame(SequencerCommand command)
		{
			return null;
		}

		private bool HandleCommandInternally(string commandName, string[] args, out float duration)
		{
			duration = default(float);
			return false;
		}

		private bool TryHandleCameraInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimationInternally(string commandName, string[] args, out float duration)
		{
			duration = default(float);
			return false;
		}

		private bool HandleAnimatorControllerInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleAnimatorLayerInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorBoolInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorIntInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleAnimatorFloatInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorTriggerInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAnimatorPlayInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAudioInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleAudioStopInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleMoveToInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool TryHandleLookAtInternally(string commandName, string[] args)
		{
			return false;
		}

		private void DoLookAt(Transform subject, Vector3 position, bool yAxisOnly)
		{
		}

		private bool HandleNavMeshAgentInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSendMessageInternally(string commandName, bool upwards, string[] args)
		{
			return false;
		}

		private bool HandleSetActiveInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetEnabledInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleClearSubtitleText(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetDialoguePanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleOpenPanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetPanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetMenuPanelInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetPortraitInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetTimeoutInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleSetContinueModeInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleContinueInternally()
		{
			return false;
		}

		private bool HandleSetVariableInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleShowAlertInternally(string commandName, string[] args)
		{
			return false;
		}

		private bool HandleUpdateTrackerInternally()
		{
			return false;
		}

		private bool HandleRandomizeNextEntryInternally()
		{
			return false;
		}
	}
}
