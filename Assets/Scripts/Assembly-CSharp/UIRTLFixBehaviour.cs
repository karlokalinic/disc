using TMPro;
using UnityEngine;

public class UIRTLFixBehaviour : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI textMeshComponent;

	[SerializeField]
	private bool forceChangeAligmentIfRTL;

	[SerializeField]
	private HorizontalAlignmentOptions rtlAlimentOption;

	[SerializeField]
	private HorizontalAlignmentOptions noneRTLAlimentOption;

	private void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void OnLocalize()
	{
	}
}
