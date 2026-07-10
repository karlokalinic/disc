using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class CopotypeVisualizer : LiteSingleton<CopotypeVisualizer>
{
	private struct ProfileLine
	{
		public string label;

		public string value;

		public float rtlMinHeight;

		public ProfileLine(string label, string value)
		{
			this.label = null;
			this.value = null;
			rtlMinHeight = 0f;
		}

		public ProfileLine(string label, int value)
		{
			this.label = null;
			this.value = null;
			rtlMinHeight = 0f;
		}

		public ProfileLine(string label, int value, float rtlMinHeight)
		{
			this.label = null;
			this.value = null;
			this.rtlMinHeight = 0f;
		}
	}

	public TextMeshProUGUI officerProfileName;

	public TextMeshProUGUI officerProfileTitle;

	public TextMeshProUGUI officerProfileContent;

	[SerializeField]
	private bool consoleLayout;

	[SerializeField]
	private LayoutDisabler copotypeLinesParent;

	[SerializeField]
	private CopotypeLine copotypeLinePrefab;

	private readonly List<CopotypeLine> instantiatedLines;

	private Color numberColor;

	private const string taskReadTheWatermarkDone = "TASK.read_the_watermark_done";

	private const string inventoryLedgerPerforation = "inventory.ledger_inspected_perforations";

	private const string plazaShotKontenaerSucceded = "plaza.tribunal_shot_kortenaer_success";

	private const string plazaTribunalSpiritbombSucceded = "plaza.tribunal_spiritbomb_succeeded";

	private const string kimReputation = "reputation.kim";

	private const string officerRank = "tc.rank_known";

	public void Refresh()
	{
	}

	public static bool IsProfileDiscovered()
	{
		return false;
	}

	private string GetOfficerName()
	{
		return null;
	}

	private string GetOfficerTitle()
	{
		return null;
	}

	private int GetNumberOfKilled()
	{
		return 0;
	}

	private void AddCopotypes(StringBuilder stringBuilder)
	{
	}

	private void AddLedgerTallies(StringBuilder stringBuilder)
	{
	}

	private void GenerateConsoleLayout(List<ProfileLine> profileData)
	{
	}

	private void AddCopotypesConsole(List<ProfileLine> profileData)
	{
	}

	private void AddLedgerTalliesConsole(List<ProfileLine> profileData)
	{
	}

	private void AddValue(StringBuilder sb, string explanation, int value)
	{
	}

	private void AddValue(StringBuilder sb, string explanation, string value)
	{
	}

	private int GetKimReputation()
	{
		return 0;
	}
}
