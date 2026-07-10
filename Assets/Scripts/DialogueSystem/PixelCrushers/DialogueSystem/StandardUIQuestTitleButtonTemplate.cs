using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIQuestTitleButtonTemplate : StandardUIContentTemplate
	{
		public Button button;

		public UITextField label;

		public StandardUIToggleTemplate trackToggleTemplate;

		public virtual void Awake()
		{
		}

		public virtual void Assign(string questName, string displayName, ToggleChangedDelegate trackToggleDelegate)
		{
		}
	}
}
