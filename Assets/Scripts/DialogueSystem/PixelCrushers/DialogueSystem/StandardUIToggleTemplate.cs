using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIToggleTemplate : StandardUIContentTemplate
	{
		public UnityEngine.UI.Toggle toggle;

		protected object m_data;

		public event ToggleChangedDelegate onToggleChanged
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

		public virtual void Awake()
		{
		}

		public virtual void Assign(bool isVisible, bool isOn, object data, ToggleChangedDelegate toggleDelegate)
		{
		}

		protected virtual void OnToggleChanged(bool value)
		{
		}
	}
}
