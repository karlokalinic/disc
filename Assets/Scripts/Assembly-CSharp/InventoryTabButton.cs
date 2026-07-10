using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTabButton : MonoBehaviour
{
	public static Color ACTIVE_TAB_COLOR;

	public static Color DISABLED_TAB_COLOR;

	public static Color TAB_COLOR;

	public Button TabButton;

	public TextMeshProUGUI ButtonText;

	public TextMeshProUGUI Separator;

	public Image Notifier;

	public Localize LocalizeText;

	public void DisableInPawnMode()
	{
	}

	public void Enable()
	{
	}
}
