using LocalizationCustomSystem;
using UnityEngine;

public class PlatformSpecificLocalization : MonoBehaviour
{
	[SerializeField]
	private TranslationString PCTerm;

	[SerializeField]
	private TranslationString XboxTerm;

	[SerializeField]
	private TranslationString PlayStationTerm;

	[SerializeField]
	private TranslationString SwitchTerm;

	private void Awake()
	{
	}
}
