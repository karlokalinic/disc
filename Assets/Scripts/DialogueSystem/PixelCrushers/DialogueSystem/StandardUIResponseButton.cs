using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIResponseButton : MonoBehaviour
	{
		public Button button;

		public UITextField label;

		public bool setLabelColor;

		public Color defaultColor;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isClickable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isVisible { get; set; }

		public Response response { get; set; }

		public Transform target { get; set; }

		public void Reset()
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void SetFormattedText(FormattedText formattedText)
		{
		}

		public virtual void SetUnformattedText(string unformattedText)
		{
		}

		protected virtual void SetColor(Color currentColor)
		{
		}

		public virtual void OnClick()
		{
		}
	}
}
