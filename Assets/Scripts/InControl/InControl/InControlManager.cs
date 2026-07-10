using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	public class InControlManager : SingletonMonoBehavior<InControlManager>
	{
		public bool logDebugInfo;

		public bool invertYAxis;

		[SerializeField]
		private bool useFixedUpdate;

		public bool dontDestroyOnLoad;

		public bool suspendInBackground;

		public InControlUpdateMode updateMode;

		public bool enableICade;

		public bool enableXInput;

		public bool xInputOverrideUpdateRate;

		public int xInputUpdateRate;

		public bool xInputOverrideBufferSize;

		public int xInputBufferSize;

		public bool enableNativeInput;

		public bool nativeInputEnableXInput;

		public bool nativeInputEnableMFi;

		public bool nativeInputPreventSleep;

		public bool nativeInputOverrideUpdateRate;

		public int nativeInputUpdateRate;

		private bool applicationHasQuit;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnApplicationFocus(bool focusState)
		{
		}

		private void OnApplicationPause(bool pauseState)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnSceneWasLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		private static void LogMessage(LogMessage logMessage)
		{
		}
	}
}
