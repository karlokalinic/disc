using UnityEngine;

public class AreaStateLuaTable
{
	public const string AREA_STATE_TABLE = "AreaState";

	private const string AREA_STATE_PROPERTY_DISSAPEAR = "disappear";

	private const string AREA_STATE_PROPERTY_EMPTY = "emptied";

	private const string AREA_STATE_PROPERTY_HAS_ENTERED = "HasEntered";

	private const string AREA_LOCATION_STATE = "LocationState";

	public static void DissapearObject(GameObject gameObject)
	{
	}

	public static void SetObjectEmpty(GameObject gameObject)
	{
	}

	public static bool IsObjectDissapeared(string objectPersistenceName)
	{
		return false;
	}

	public static bool IsObjectEmpty(string objectPersistenceName)
	{
		return false;
	}

	public static void RenewAreaStates()
	{
	}

	public static bool IsAreaKnown(string areaId)
	{
		return false;
	}

	public static void SetAreaKnown(string areaId)
	{
	}

	public static int GetLocationState(string locationName, int defaultValue)
	{
		return 0;
	}

	public static void SetLocationState(string locationName, int state)
	{
	}
}
