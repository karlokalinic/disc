using FortressOccident;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Voidforge;

public class FontButtonLayout : FOComponent
{
	public Button template;

	public UnityUIDialogueUI dialogueUI;

	private ComponentRef<VerticalLayoutGroup> layout;

	public Font[] fonts;

	public void OnEnable()
	{
	}

	private UnityAction CreateFunction(Font font)
	{
		return null;
	}

	public void OnDisable()
	{
	}

	private void ChangeFont(Font font)
	{
	}

	private void ChangeFonts(Transform transform, Font font)
	{
	}
}
