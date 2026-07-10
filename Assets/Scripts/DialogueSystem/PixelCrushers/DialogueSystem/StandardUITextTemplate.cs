using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUITextTemplate : StandardUIContentTemplate
	{
		[SerializeField]
		private UITextField m_text;

		public UITextField text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public void Assign(string text)
		{
		}
	}
}
