using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LockitSyncLoader : LiteSingleton<LockitSyncLoader>
{
	[SerializeField]
	private TextMeshProUGUI version;

	[SerializeField]
	private LanguageSourceAsset baseGeneralLanguageSource;

	[SerializeField]
	private LanguageSourceAsset baseDialoguesLanguageSource;

	[SerializeField]
	private string[] languageSourcesSheetName;

	[SerializeField]
	private string[] languageSourcesSheetKeys;

	[SerializeField]
	private Text infoText;

	[SerializeField]
	private Text syncButtonText;

	[SerializeField]
	private Button syncButton;

	[SerializeField]
	private InputField syncDialoguePath;

	[SerializeField]
	private Button syncDialogueButton;

	[SerializeField]
	private TMP_Dropdown languageDropdown;

	private string currentLanguageSourceSheetKey;

	private string currentLanguageSourceSheetName;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnLanguageDropdownChanged(int index)
	{
	}

	public void UpdateLockitVersion()
	{
	}

	private void SyncDialogueLockit()
	{
	}

	private void SyncGeneralLockit()
	{
	}

	private void OnSyncGeneralLockitsStarted()
	{
	}

	private void OnSyncGeneralLockitsFinished(LanguageSourceData lockitData, bool wasNewContent, string errorMessage)
	{
	}
}
