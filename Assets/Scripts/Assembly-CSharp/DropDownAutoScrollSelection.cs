using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropDownAutoScrollSelection : MonoBehaviour
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private TMP_Dropdown dropdown;

	private Coroutine autoscrollNextFrameCor;

	public void AutoScrollToIndex(int index)
	{
	}

	private IEnumerator AutoscrollNextFrame(int index)
	{
		return null;
	}
}
