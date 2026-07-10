using UnityEngine;

public class GyroscopeUIRotator : MonoBehaviour
{
	[SerializeField]
	private RectTransform rt;

	[SerializeField]
	private float slerpValue;

	[SerializeField]
	private float maxRotationAngle;
}
