using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SimpleTabButton : MonoBehaviour
{
	[Serializable]
	private class SimpleTabButtonState
	{
		[SerializeField]
		private Color textColor;

		[SerializeField]
		private bool isBackgroundActive;

		public void Apply(SimpleTabButton tabButton)
		{
		}
	}

	[SerializeField]
	private Button button;

	[SerializeField]
	private Text text;

	[SerializeField]
	private Image backgroundImage;

	[SerializeField]
	private SimpleTabButtonState selected;

	[SerializeField]
	private SimpleTabButtonState notSelected;

	public int TabIndex { get; private set; }

	public bool IsSelected { get; private set; }

	public event Action<int> OnClicked
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

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Init(int tabIndex)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	private void OnClick()
	{
	}
}
