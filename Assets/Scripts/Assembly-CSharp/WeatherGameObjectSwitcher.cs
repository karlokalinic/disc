using UnityEngine;

public class WeatherGameObjectSwitcher : MonoBehaviour
{
	[SerializeField]
	private string weatherName;

	[SerializeField]
	private GameObject[] objectsToEnable;

	[SerializeField]
	private bool canOnlyEnable;

	private string booleanName;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void BooleanChanged(string boolean)
	{
	}

	private void OnWeatherChanged(string newWeather)
	{
	}
}
