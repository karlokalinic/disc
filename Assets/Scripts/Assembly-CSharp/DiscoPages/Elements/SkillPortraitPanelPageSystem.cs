using Charsheet;
using PagesSystem;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DiscoPages.Elements
{
	public class SkillPortraitPanelPageSystem : MonoBehaviour, ISkillDisplayElement, ISkillPortraitLabelHandler, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ICharsheetSelecteble
	{
		public Image portrait;

		public Image frame;

		public bool isHovered;

		public bool isSelectHovered;

		public bool isUpgradeable;

		private bool isSignature;

		public Image signatureFrame;

		public SegmentIndicator skillPips;

		public Button levelUpButton;

		public Button selectButton;

		private SkillPortraitAnimatorHelperPageSystem animatorHelper;

		private PipVisualizer levelUpPips;

		[SerializeField]
		private SkillPortrayLabel skillPortrayLabel;

		private int rankValue;

		private int statValue;

		public SkillPortraitMode mode;

		public SkillType skill;

		public static SkillType signatureSkill;

		private bool initializedFlag;

		private int portraitIndex;

		public SkillType SkillType => default(SkillType);

		public SkillPortrayLabel SkillPortraitLabel => null;

		public int PortraitIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnLanguageChanged()
		{
		}

		public void Initialize()
		{
		}

		public void UpdateData()
		{
		}

		private void UpdateWithSkillObject(Skill skillObject)
		{
		}

		public void UpdateColors()
		{
		}

		public void UpdateSelectionVisuals()
		{
		}

		public void OnPointerEnter(PointerEventData evt)
		{
		}

		public void OnPointerExit(PointerEventData evt)
		{
		}

		public SkillType GetSkillType()
		{
			return default(SkillType);
		}

		public static void OnSkillUpgrade(SkillType skillType)
		{
		}

		public static void SetSignatureSkill(SkillType skillType)
		{
		}

		public Modifiable GetModifiable()
		{
			return null;
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public string GetGameObjectName()
		{
			return null;
		}

		public void SetSkill(Skill newSkill)
		{
		}

		public bool HaveInfoTabAvailable()
		{
			return false;
		}
	}
}
