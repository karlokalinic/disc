using Sunshine.Metric;
using UnityEngine;

[CreateAssetMenu]
public class SunshineCharacterTemplate : ScriptableObject
{
	public int Intellect;

	public int Psyche;

	public int Fysique;

	public int Motorics;

	public SkillType signatureSkill;

	public int LogicBonus;

	public int EncyclopediaBonus;

	public int RhetoricBonus;

	public int DramaBonus;

	public int ConceptualizationBonus;

	public int VisualCalculusBonus;

	public int VolitionBonus;

	public int InlandEmpireBonus;

	public int EmpathyBonus;

	public int AuthorityBonus;

	public int SuggestionBonus;

	public int EspritDeCorpsBonus;

	public int PhysicalInstrumentBonus;

	public int ElectrochemistryBonus;

	public int EnduranceBonus;

	public int HalfLightBonus;

	public int PainThresholdBonus;

	public int ShiversBonus;

	public int HandEyeCoordinationBonus;

	public int PerceptionBonus;

	public int ReactionBonus;

	public int SavoirFaireBonus;

	public int InterfacingBonus;

	public int ComposureBonus;

	[Space]
	public int GoodCopAmount;

	[TextArea]
	public string Description;
}
