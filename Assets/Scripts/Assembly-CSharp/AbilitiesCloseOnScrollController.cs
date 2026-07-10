using DiscoPages.Elements.Common;
using Pages.Common.Charsheet;
using UnityEngine;

public class AbilitiesCloseOnScrollController : MonoBehaviour
{
	[SerializeField]
	private SwipeDetector swipeDetector;

	[SerializeField]
	private CharsheetPage charsheetPage;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CloseAbilities(SwipeDetector.SwipeData data)
	{
	}
}
