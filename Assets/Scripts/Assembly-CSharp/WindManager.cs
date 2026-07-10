using UnityEngine;

public class WindManager : MonoBehaviour
{
	public float cloudSpeedScale;

	public static WindManager instance;

	private WindZone wz;

	private float maxWind;

	private static Vector2 pos;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static void SetWind(float to)
	{
	}

	public static Vector2 GetPos()
	{
		return default(Vector2);
	}

	public static Vector2 GetDir()
	{
		return default(Vector2);
	}

	public static float GetStrength()
	{
		return 0f;
	}
}
