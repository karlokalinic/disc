using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem.TextMeshProSupport
{
	public class TextMeshProResponseButton : MonoBehaviour
	{
		public Button button;

		public TextMeshProUGUI label;

		public Color defaultColor;

		public bool setButtonColor;

		public bool setLabelColor;

		public virtual string Text
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

		public void SetFormattedText(FormattedText formattedText)
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

		public virtual void Select()
		{
		}
	}
}
