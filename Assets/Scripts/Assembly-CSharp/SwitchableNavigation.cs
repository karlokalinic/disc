using System;
using UnityEngine.UI;

[Serializable]
internal class SwitchableNavigation
{
	public Direction direction;

	public Selectable enabledSelectable;

	public Selectable disabledSelectable;
}
