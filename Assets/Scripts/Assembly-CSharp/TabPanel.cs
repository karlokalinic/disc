using System;
using UnityEngine;

public abstract class TabPanel<TabType> : MonoBehaviour where TabType : struct, IConvertible
{
	public abstract void ToggleFreshNotifier(TabType tabGroup, bool isActive);

	public abstract void ActivatePanel(TabType tabGroup, bool initializing = false);

	public abstract void UpdateScrollViewSize();
}
