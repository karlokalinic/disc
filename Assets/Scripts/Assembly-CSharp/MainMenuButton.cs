using System;
using System.Runtime.CompilerServices;
using I2.Loc;
using Sunshine.Views;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, ISubmitHandler, ISelectHandler, IDeselectHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Serializable]
	private class MainMenuButtonState
	{
		[SerializeField]
		private Color textColor;

		[SerializeField]
		private Color backgroundColor;

		[SerializeField]
		private Color hoverColor;

		[SerializeField]
		private Color hoverTextColor;

		[SerializeField]
		private bool isBackgroundActive;

		public void Apply(MainMenuButton menuButton)
		{
		}

		public void UpdateColors(MainMenuButton menuButton)
		{
		}
	}

	public static MainMenuButton CurrentActiveMenuButton;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private Localize localization;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private Image hoverImage;

	[SerializeField]
	private ViewType relatedViewType;

	[SerializeField]
	private Selectable selectable;

	[SerializeField]
	private MainMenuButtonState selected;

	[SerializeField]
	private MainMenuButtonState inRelatedView;

	[SerializeField]
	private MainMenuButtonState normal;

	[SerializeField]
	private MainMenuButtonState disabled;

	[NonSerialized]
	public Color HoverTextColor;

	[NonSerialized]
	public Color TextColor;

	[NonSerialized]
	public Func<bool> CanBeUsed;

	[NonSerialized]
	public Func<bool> ShouldBeDisabledIfCanNotBeUsed;

	public string menuHoverOnSound;

	public string menuHoverOffSound;

	public Selectable GetSelectable => null;

	public ViewType RelatedViewType => default(ViewType);

	public bool IsDisabled { get; private set; }

	public bool IsSelected { get; private set; }

	public bool IsInRelatedView { get; private set; }

	public UnityEvent OnClick { get; private set; }

	public event Action DeselectAll
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

	public void Disable()
	{
	}

	public void Enable()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnChangedView(ViewType viewType)
	{
	}

	private void Refresh()
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void SetLabel(string label)
	{
	}

	public void SetLocalizationTerm(string term)
	{
	}

	public void SetRelatedViewType(ViewType viewType)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void HideHoverImage()
	{
	}

	private void PlayCorrectResponseSound()
	{
	}
}
