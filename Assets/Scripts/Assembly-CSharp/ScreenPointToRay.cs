using UnityEngine;

public class ScreenPointToRay : MonoBehaviour
{
	public Camera cam;

	private float OrthographicSize => 0f;

	private float Aspect => 0f;

	public Ray Get(Vector2 point)
	{
		return default(Ray);
	}
}
