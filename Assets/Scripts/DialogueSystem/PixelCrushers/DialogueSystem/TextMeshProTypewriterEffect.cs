using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[DisallowMultipleComponent]
	public class TextMeshProTypewriterEffect : AbstractTypewriterEffect
	{
		[Serializable]
		public class AutoScrollSettings
		{
			public bool autoScrollEnabled;

			public ScrollRect scrollRect;

			public UnityUIScrollbarEnabler scrollbarEnabler;
		}

		private enum RPGMakerTokenType
		{
			None = 0,
			QuarterPause = 1,
			FullPause = 2,
			SkipToEnd = 3,
			InstantOpen = 4,
			InstantClose = 5
		}

		public AutoScrollSettings autoScrollSettings;

		public UnityEvent onBegin;

		public UnityEvent onCharacter;

		public UnityEvent onEnd;

		private const string RPGMakerCodeQuarterPause = "\\,";

		private const string RPGMakerCodeFullPause = "\\.";

		private const string RPGMakerCodeSkipToEnd = "\\^";

		private const string RPGMakerCodeInstantOpen = "\\>";

		private const string RPGMakerCodeInstantClose = "\\<";

		private Dictionary<int, List<RPGMakerTokenType>> rpgMakerTokens;

		private TMP_Text m_textComponent;

		private bool started;

		private int charactersTyped;

		private Coroutine typewriterCoroutine;

		private MonoBehaviour coroutineController;

		public override bool isPlaying => false;

		public bool IsPlaying => false;

		private TMP_Text textComponent => null;

		private AudioSource runtimeAudioSource => null;

		public override void Awake()
		{
		}

		private void RemoveIfDuplicate()
		{
		}

		public override void Start()
		{
		}

		public override void OnEnable()
		{
		}

		public override void OnDisable()
		{
		}

		public void Pause()
		{
		}

		public void Unpause()
		{
		}

		public void Rewind()
		{
		}

		public override void StartTyping(string text, int fromIndex = 0)
		{
		}

		public override void StopTyping()
		{
		}

		public void PlayText(string text, int fromIndex = 0)
		{
		}

		private void StartTypewriterCoroutine(int fromIndex)
		{
		}

		public IEnumerator Play(int fromIndex)
		{
			return null;
		}

		private void ProcessRPGMakerCodes()
		{
		}

		private bool PeelRPGMakerTokenFromFront(ref string source, out RPGMakerTokenType token)
		{
			token = default(RPGMakerTokenType);
			return false;
		}

		private void StopTypewriterCoroutine()
		{
		}

		public override void Stop()
		{
		}

		private void HandleAutoScroll()
		{
		}
	}
}
