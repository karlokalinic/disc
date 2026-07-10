using UnityEngine;

public class CharacterMaterialTracker : LiteSingleton<CharacterMaterialTracker>
{
	public Material shavedMaterial;

	public Material defaultMaterial;

	public Material leopardBodysuitMaterial;

	public Material shavedLeopardBodysuitMaterial;

	public static Material CurrentMaterial()
	{
		return null;
	}
}
