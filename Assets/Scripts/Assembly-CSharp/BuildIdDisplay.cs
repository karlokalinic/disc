using TMPro;
using UnityEngine;

public class BuildIdDisplay : MonoBehaviour
{
	public const string buildnumFileName = "buildnum.dat";

	private static string _buildNumber;

	private TextMeshProUGUI versionText;

	public TextMeshProUGUI versionTextF1;

	private static BuildIdDisplay current;

	private static string heldErrorMessage;

	public static string BuildNumber => null;

	public void Awake()
	{
	}

	public void OnEnable()
	{
	}

	public void ShowMessage()
	{
	}

	public static void SetNastyErrorText(string errorMessage)
	{
	}
}
