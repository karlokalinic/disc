using System.Collections;
using Coffee.UISoftMask;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SunshineContinueButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Button buttonComponent;

	public static SunshineContinueButton instance;

	private ContState state;

	[SerializeField]
	private string disabledImageTerm;

	[SerializeField]
	private string enabledImageTerm;

	[SerializeField]
	private string hazyImageTerm;

	[SerializeField]
	private string endConversationImageTerm;

	[SerializeField]
	private string intImageTerm;

	[SerializeField]
	private string psyImageTerm;

	[SerializeField]
	private string fysImageTerm;

	[SerializeField]
	private string motImageTerm;

	[SerializeField]
	private string specialEndConversationImageTerm;

	private SoftMaskable[] childMaskables;

	private SoftMaskable softMaskable;

	public string prevLanguage;

	public ContState State => default(ContState);

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetState(ContState buttonState)
	{
	}

	public void SetInteractable(bool interactable)
	{
	}

	public void StartConversation()
	{
	}

	public void WasClicked()
	{
	}

	public void CheckLayoutRebuild()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void OnLanguageChanged()
	{
	}

	private void TestDisabled()
	{
	}

	private void TestEnabled()
	{
	}

	private void TestHazy()
	{
	}

	private void TestEnd()
	{
	}

	private void TestInt()
	{
	}

	private void TestPsy()
	{
	}

	private void TestFys()
	{
	}

	private void TestMot()
	{
	}

	private IEnumerator RefreshSoftMaskable()
	{
		return null;
	}
}
