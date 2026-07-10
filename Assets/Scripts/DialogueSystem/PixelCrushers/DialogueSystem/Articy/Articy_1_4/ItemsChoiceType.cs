using System;
using System.Xml.Serialization;

namespace PixelCrushers.DialogueSystem.Articy.Articy_1_4
{
	[Serializable]
	[XmlType]
	public enum ItemsChoiceType
	{
		Asset = 0,
		Assets = 1,
		AssetsUserFolder = 2,
		BooleanPropertyDefinition = 3,
		Comment = 4,
		Connection = 5,
		Dialog = 6,
		DialogFragment = 7,
		Entities = 8,
		EntitiesUserFolder = 9,
		Entity = 10,
		EnumerationPropertyDefinition = 11,
		FeatureDefinition = 12,
		Features = 13,
		FeaturesUserFolder = 14,
		FlowFragment = 15,
		Hub = 16,
		Journey = 17,
		Journeys = 18,
		JourneysUserFolder = 19,
		Jump = 20,
		Link = 21,
		Location = 22,
		Locations = 23,
		LocationsUserFolder = 24,
		Note = 25,
		Notes = 26,
		NotesUserFolder = 27,
		NumberPropertyDefinition = 28,
		ObjectCustomization = 29,
		ObjectTemplateDefinition = 30,
		ObjectTemplates = 31,
		Path = 32,
		Project = 33,
		PropertyTemplates = 34,
		ReferenceSlotPropertyDefinition = 35,
		ReferenceStripPropertyDefinition = 36,
		Spot = 37,
		Stories = 38,
		TextPropertyDefinition = 39,
		TypedObjectTemplates = 40,
		TypedObjectTemplatesUserFolder = 41,
		TypedPropertyTemplates = 42,
		TypedPropertyTemplatesUserFolder = 43,
		Zone = 44
	}
}
