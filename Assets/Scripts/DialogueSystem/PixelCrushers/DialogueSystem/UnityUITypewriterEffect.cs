using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[DisallowMultipleComponent]
	public class UnityUITypewriterEffect : AbstractTypewriterEffect
	{
		[Serializable]
		public class AutoScrollSettings
		{
			public bool autoScrollEnabled;

			public ScrollRect scrollRect;

			public UIScrollbarEnabler scrollbarEnabler;

			public Text sizerText;
		}

		protected enum TokenType
		{
			Character = 0,
			BoldOpen = 1,
			BoldClose = 2,
			ItalicOpen = 3,
			ItalicClose = 4,
			ColorOpen = 5,
			ColorClose = 6,
			SizeOpen = 7,
			SizeClose = 8,
			Quad = 9,
			Pause = 10,
			InstantOpen = 11,
			InstantClose = 12
		}

		protected class Token
		{
			public TokenType tokenType;

			public char character;

			public string code;

			public float duration;

			public Token(TokenType tokenType, char character, string code, float duration)
			{
			}
		}

		public AutoScrollSettings autoScrollSettings;

		public UnityEvent onBegin;

		public UnityEvent onCharacter;

		public UnityEvent onEnd;

		protected const string RichTextBoldOpen = "<b>";

		protected const string RichTextBoldClose = "</b>";

		protected const string RichTextItalicOpen = "<i>";

		protected const string RichTextItalicClose = "</i>";

		protected const string RichTextColorOpenPrefix = "<color=";

		protected const string RichTextColorClose = "</color>";

		protected const string RichTextSizeOpenPrefix = "<size=";

		protected const string RichTextSizeClose = "</size>";

		protected const string QuadPrefix = "<quad ";

		protected Text control;

		protected bool started;

		protected string original;

		protected string frontSkippedText;

		protected Coroutine typewriterCoroutine;

		protected MonoBehaviour coroutineController;

		protected StringBuilder current;

		protected List<TokenType> openTokenTypes;

		protected List<Token> tokens;

		protected int MaxSafeguard;

		public override bool isPlaying => false;

		public bool IsPlaying => false;

		public override void Awake()
		{
		}

		protected void RemoveIfDuplicate()
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

		public virtual void Pause()
		{
		}

		public virtual void Unpause()
		{
		}

		public override void StartTyping(string text, int fromIndex = 0)
		{
		}

		public override void StopTyping()
		{
		}

		public virtual void PlayText(string text, int fromIndex = 0)
		{
		}

		protected virtual void StartTypewriterCoroutine(int fromIndex)
		{
		}

		public virtual IEnumerator Play(int fromIndex = 0)
		{
			return null;
		}

		protected Token GetNextToken(List<Token> tokens)
		{
			return null;
		}

		protected void OpenRichText(StringBuilder current, Token token, List<TokenType> openTokens)
		{
		}

		protected void CloseRichText(StringBuilder current, Token token, List<TokenType> openTokens)
		{
		}

		protected void AddInstantText(StringBuilder current, List<TokenType> openTokenTypes, List<Token> tokens)
		{
		}

		protected string GetCurrentText(StringBuilder current, List<TokenType> openTokenTypes, List<Token> tokens, bool withoutTransparentText = false)
		{
			return null;
		}

		protected List<Token> Tokenize(string text)
		{
			return null;
		}

		protected Token TryTokenize(string code, TokenType tokenType, float duration, ref string remainder)
		{
			return null;
		}

		protected Token TryTokenizeColorOpen(ref string remainder)
		{
			return null;
		}

		protected Token TryTokenizeSizeOpen(ref string remainder)
		{
			return null;
		}

		private Token TryTokenizeQuad(ref string remainder)
		{
			return null;
		}

		protected virtual void StopTypewriterCoroutine()
		{
		}

		public override void Stop()
		{
		}

		protected void InitAutoScroll()
		{
		}

		protected void HandleAutoScroll()
		{
		}

		protected IEnumerator HandleAutoScrollAfterOneFrame()
		{
			return null;
		}
	}
}
