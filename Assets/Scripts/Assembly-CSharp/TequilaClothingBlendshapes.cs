using System.Collections.Generic;
using Sunshine;
using UnityEngine;

public static class TequilaClothingBlendshapes
{
	private const string BODY = "tequila_body";

	private static Dictionary<string, int> blendShapeRegister;

	private static readonly int onTequila;

	public static void CheckBlendshapes(string itemName, object item, bool equipping)
	{
	}

	public static void ChangeBodyBlendshapes(object item, bool equipping)
	{
	}

	public static void ChangeBodyBlendshapes(SkinnedCharacterItem item, bool equipping)
	{
	}

	public static void ChangeBodyBlendshapes(HeadWearBehaviour item, bool equipping)
	{
	}

	public static void CrossCheckBlendshapes(SkinnedCharacterItem item1, object item2, bool equipping)
	{
	}

	private static void CrossCheckBlendshapes(SkinnedCharacterItem item1, SkinnedCharacterItem item2, bool equipping)
	{
	}

	private static void CrossCheckBlendshapes(SkinnedCharacterItem item1, HeadWearBehaviour item2, bool equipping)
	{
	}

	private static void ChangeBlendshapesOfItem(IEnumerable<string> blendshapeNames, SkinnedCharacterItem item, bool equipping)
	{
	}

	public static void ChangeBlendshape(SkinnedMeshRenderer r, string blendshapeName, bool equipping)
	{
	}

	private static void RegisterBlendshape(string name)
	{
	}

	private static void UnregisterBlendshape(string name)
	{
	}

	private static bool LastInstanceOfBlendShapeModifier(string name)
	{
		return false;
	}

	public static SkinnedCharacterItem GetClothedItemByName(string itemName)
	{
		return null;
	}

	private static HeadWearBehaviour GetHeadWearItemByName(string itemName)
	{
		return null;
	}

	private static SkinnedMeshRenderer GetSkinnedMeshRendererByName(string itemName)
	{
		return null;
	}

	public static void TequilaShavedBlendshape(SkinnedMeshRenderer r, bool shaved)
	{
	}

	public static void UpdateTequilaStencil(GameObject go, bool to)
	{
	}
}
