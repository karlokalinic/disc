using I2.Loc;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DiscoPages.Elements.MainMenu
{
	public class ArchetypeSelectMenuButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[SerializeField]
		private bool isCustomCharacterButton;

		[SerializeField]
		private ArchetypeButtonAnimatorHelper animatorHelper;

		[SerializeField]
		private Image portrait;

		[SerializeField]
		private Image portraitHoverOverlay;

		[SerializeField]
		private Localize signatureSkillLocalization;

		[SerializeField]
		private Localize descriptionLocalization;

		[SerializeField]
		private Localize nameLocalization;

		[SerializeField]
		private ArchetypeAbility inte;

		[SerializeField]
		private ArchetypeAbility psy;

		[SerializeField]
		private ArchetypeAbility phq;

		[SerializeField]
		private ArchetypeAbility mot;

		[SerializeField]
		private Button continueButton;

		private int index;

		public SunshineCharacterTemplate Archetype { get; private set; }

		public int Index
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void Initialize(SunshineCharacterTemplate archetype, Sprite portrait, UnityEvent onSelectedArchetypeChanged)
		{
		}

		public void OnPointerClick(PointerEventData e)
		{
		}

		private void OnContinuePressed()
		{
		}

		private void SetPortrait(Sprite sprite)
		{
		}

		private void SetSelected(bool isSelected, bool isOtherSelected)
		{
		}

		private void SetArchetype(SunshineCharacterTemplate archetype)
		{
		}

		private void PlayShowAnimation()
		{
		}

		private void PlayHideAnimation()
		{
		}

		private void OnSelectedArchetypeChanged()
		{
		}
	}
}
