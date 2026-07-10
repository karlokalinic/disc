using PixelCrushers.DialogueSystem;
using Sunshine;
using Sunshine.Metric;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CharacterSheetTooltip : Tooltip<CharacterSheetTooltip>
{
	private class ModifierSort
	{
		public string label;

		public int amount;

		public ModifierType modifierType;

		public bool hideAmount;

		public ModifierSort(string label, int amount, ModifierType modifierType)
		{
		}

		public ModifierSort(string label, int amount, ModifierType modifierType, bool hideAmount)
		{
		}
	}

	public Color positiveChangeColor;

	public Color negativeChangeColor;

	public Color itemNameColor;

	public Color statColor;

	public Color statNumberColor;

	public CanvasGroup canvasGroup;

	public TextMeshProUGUI titleText;

	public TextMeshProUGUI shortDescriptionText;

	public TextMeshProUGUI effectsText;

	public Image portraitImg;

	public HorizontalLayoutGroup contentLayoutGroup;

	private SkillType _skillType;

	private string previousActorName;

	private AsyncOperationHandle<Sprite> spriteHandle;

	private bool isAsyncPrepared;

	public override void SetTooltipContent(TooltipSource tooltipSource)
	{
	}

	private void OnDisable()
	{
	}

	private void LoadPortraitAsync(Actor actor)
	{
	}

	private void UnloadPortraitAsync()
	{
	}

	private void SetPortrait(AsyncOperationHandle<Sprite> portraitHandle)
	{
	}

	public static Actor ActorFromModifiable(SkillType skillType)
	{
		return null;
	}

	public static Actor ActorFromModifiable(Modifiable modifiable)
	{
		return null;
	}

	private int GetModifiersSum(Modifiable modifiable)
	{
		return 0;
	}

	private string GatherModifiableData(Modifiable modifiable)
	{
		return null;
	}

	private bool ShouldHighlightModifier(Modifier modifier)
	{
		return false;
	}

	private static string GetSkillOrAbilityName(Modifiable modifiable)
	{
		return null;
	}

	private Modifiable GetSkillOrAbility(TooltipSource tooltipSource)
	{
		return null;
	}
}
