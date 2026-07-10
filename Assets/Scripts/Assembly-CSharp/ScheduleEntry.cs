using System;
using UnityEngine;

[Serializable]
public class ScheduleEntry
{
	public bool checkHours;

	public int startHour;

	public int startMinute;

	public int endHour;

	public int endMinute;

	public bool checkDays;

	public int startDay;

	public int endDay;

	public bool checkLua;

	public string luaExpression;

	public string overrideConversation;

	public GameObject locationObject;

	public RuntimeAnimatorController animatorController;

	public string animatorStateName;
}
