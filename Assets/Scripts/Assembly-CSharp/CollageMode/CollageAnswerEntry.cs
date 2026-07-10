using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CollageMode
{
	public class CollageAnswerEntry : CollageDialogueEntry
	{
		[SerializeField]
		private RectTransform textArea;

		[SerializeField]
		private TextMeshProUGUI numberText;

		[SerializeField]
		private TextMeshProUGUI numberRTLText;

		[SerializeField]
		private string numberFormatString;

		[SerializeField]
		private string numberFormatRTLString;

		[SerializeField]
		private string skillFormatString;

		[SerializeField]
		private string skillFormatRTLString;

		[SerializeField]
		private Image backgroundImage;

		[SerializeField]
		private MultipleToggle checkToggle;

		[SerializeField]
		private Color redCheckBackgroundColor;

		[SerializeField]
		private Color whiteCheckBackgroundColor;

		[SerializeField]
		private Color noCheckBackgroundColor;

		[SerializeField]
		private Color checkTextColor;

		[SerializeField]
		private Color noCheckTextColor;

		private float textAreaOffset;

		private bool isCheck;

		private CheckType checkType;

		public CheckType CheckType => default(CheckType);

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnEnable()
		{
		}

		public void SetNumber(int number)
		{
		}

		public void SetCheckType(CheckType checkType)
		{
		}

		public override void OnInputFieldValueChanged(string value)
		{
		}

		public override void Autofill(Operation operation)
		{
		}

		protected override string PrepareAutofillString(Operation operation)
		{
			return null;
		}

		private void RefreshIsCheck()
		{
		}

		private void OnCheckToggleValueChanged()
		{
		}

		private void RefreshColors()
		{
		}
	}
}
