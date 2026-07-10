using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuAdButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ISubmitHandler, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField]
	private Selectable selectable;

	[SerializeField]
	private Image buttonImage;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private Color unSelectedColor;

	[SerializeField]
	private Color selectedColor;

	[SerializeField]
	private Color pressedColor;

	[SerializeField]
	private Color disableColor;

	[SerializeField]
	private LayoutElement topPad;

	[SerializeField]
	private float paddingHeightWhenAdVisible;

	[SerializeField]
	private RectTransform[] inputPrompts;

	[SerializeField]
	private float anchorWhenAdVisible;

	[SerializeField]
	private string steamURL;

	[SerializeField]
	private string gogURL;

	[SerializeField]
	private string epicURL;

	public string menuHoverOnSound;

	public string menuHoverOffSound;

	private float initialTopPadding;

	private float[] initialInputPromptAnchor;

	public bool IsDisabled { get; private set; }

	public bool IsSelected { get; private set; }

	public bool IsPressed { get; private set; }

	public void Disable()
	{
	}

	public void Enable()
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	private IEnumerator OnFinishSubmit()
	{
		return null;
	}

	private void Refresh()
	{
	}

	private void Awake()
	{
	}

	private void OpenURL()
	{
	}
}
