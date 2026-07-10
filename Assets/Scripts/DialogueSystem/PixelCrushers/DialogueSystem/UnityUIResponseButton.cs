using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIResponseButton : MonoBehaviour, IPoolable
	{
		public Button button;

		public Text label;

		public Color defaultColor;

		public bool setButtonColor;

		public bool setLabelColor;

		private string responseNumberText;

		public string Text
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

		public bool clickable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool visible { get; set; }

		public Response response { get; set; }

		public Transform target { get; set; }

		public void Reset()
		{
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

		public void SetUnformattedText(string unformattedText)
		{
		}

		protected virtual void SetColor(Color currentColor)
		{
		}

		public void OnClick()
		{
		}

		public virtual void Initialize()
		{
		}

		public virtual void ResetState()
		{
		}

		public virtual void Select()
		{
		}
	}
}
