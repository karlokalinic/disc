using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
	private bool initialized;

	private bool toggled;

	private Button button;

	private ColorBlock colorBlock;

	private ColorBlock highlightBlock;

	public Color toggledColor;

	public bool Toggled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void UpdateColor()
	{
	}
}
