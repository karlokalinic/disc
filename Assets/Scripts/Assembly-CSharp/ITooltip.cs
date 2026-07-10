using Sunshine;
using UnityEngine;

public interface ITooltip
{
	void Show(TooltipSource source, RectTransform selectionRect, bool setByKeyboard = false);

	void Hide(TooltipSource source);

	void SetTooltipContent(TooltipSource tooltipSource);
}
