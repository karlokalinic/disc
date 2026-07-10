using PixelCrushers.DialogueSystem.TextMeshProSupport;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.Wrappers
{
	public class TextMeshProResponseButton : PixelCrushers.DialogueSystem.TextMeshProSupport.TextMeshProResponseButton, IPoolable
	{
		public const string NonBreakingSpaceString = "\ufffd";

		private string responseNumberText;

		public override string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ResponseNumberText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Awake()
		{
		}

		public virtual void InitialState(Response response, Transform target, int buttonNumber, UIAutonumberSettings autonumber)
		{
		}

		public void SetFormattedText(FormattedText formattedText, bool changeColor = true)
		{
		}

		public virtual void Initialize()
		{
		}

		public virtual void ResetState()
		{
		}
	}
}
