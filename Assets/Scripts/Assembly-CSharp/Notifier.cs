using UnityEngine;
using UnityEngine.UI;

public class Notifier : MonoBehaviour
{
	public const string LOTSSIGN = "!";

	public Image background;

	private bool hasNewValues;

	public bool HasNewValues
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void OnEnable()
	{
	}

	public void RefreshDisplay()
	{
	}

	public void OnValidate()
	{
	}
}
