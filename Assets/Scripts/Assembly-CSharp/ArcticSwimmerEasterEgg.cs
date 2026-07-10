using System.Collections;
using UnityEngine;

public class ArcticSwimmerEasterEgg : MonoBehaviour
{
	private const float TequilaFOW = 19f;

	private const int dayToActivate = 4;

	private const string weatherCondition = "Snow";

	private const string luaVariableTequilaUsingBoat = "TASK.use_boat";

	private const string luaVariableIsSnowing = "auto.is_snowing";

	private WaitForSeconds waitFor3s;

	private Coroutine distanceTesterCoroutine;

	[SerializeField]
	private GameObject swimmerPath;

	[SerializeField]
	private GameObject swimmerCharacter;

	private bool IsSnowing { get; set; }

	private bool CheckIfTequilaIsOnBoat => false;

	private bool CheckIfSwimmerIsInTequilaFOW => false;

	private bool CanHaveSwimmerPathActive => false;

	private bool CanStartShowSwimmer => false;

	private bool CanHideSwimmer => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void BooleanChanged(string boolean)
	{
	}

	private void OnWeatherChanged(string newWeather)
	{
	}

	private void CheckAllConditions()
	{
	}

	private IEnumerator DistanceTester()
	{
		return null;
	}
}
