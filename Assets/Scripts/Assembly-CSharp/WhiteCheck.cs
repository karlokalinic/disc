using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;
using UnityEngine;

public class WhiteCheck
{
	public Action GotUpdated;

	public string FlagName;

	public SkillType SkillType;

	public int LastSkillValue;

	public int LastTargetValue;

	public Actor Actor;

	public int difficulty;

	public string checkTargetArticyId;

	public string checkPrecondition;

	public bool isOnlySeen;

	public Dictionary<string, List<CheckModifier>> CheckModifiers;

	public string ActorName => (Actor != null) ? Actor.Name : string.Empty;

	public object ActorsPortraitsBundleManager { get; internal set; }

	// Reconstructed from the shipped IL2CPP GameAssembly.dll (Unity 2020.3.12) via
	// Il2CppDumper + Ghidra decompilation of the native method bodies.
	public void ParseCheckModifiers(List<CheckModifier> checkModifiers)
	{
		if (checkModifiers == null)
		{
			return;
		}
		CheckModifiers = new Dictionary<string, List<CheckModifier>>();
		foreach (CheckModifier checkModifier in checkModifiers)
		{
			ParseCheckModifier(checkModifier.expression, checkModifier);
		}
	}

	private void ParseCheckModifier(string expression, CheckModifier checkModifier)
	{
		string key = GetVariableOrFunctionName(expression);
		Sunshine.Util.AddDistinctToDictionary(key, checkModifier, CheckModifiers);
	}

	private static string GetVariableOrFunctionName(string expression)
	{
		expression = expression.TrimStart().TrimEnd();
		int equalsIndex = expression.IndexOf("==");
		if (equalsIndex >= 0)
		{
			expression = expression.Substring(0, equalsIndex).Trim();
		}
		int variableIndex = expression.IndexOf("Variable[");
		if (variableIndex < 0)
		{
			int parenIndex = expression.IndexOf("(");
			if (parenIndex < 1)
			{
				return expression;
			}
			return expression.Substring(0, parenIndex);
		}
		int closeIndex = expression.IndexOf("]");
		string variableName = expression.Substring(variableIndex + 10, closeIndex - variableIndex - 11);
		if (!DialogueLua.DoesVariableExist(variableName))
		{
			Debug.LogWarning("Unknown variable " + variableName + " used as white check modifier condition");
		}
		return variableName;
	}
}
