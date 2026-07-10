using System.Collections.Generic;
using Language.Lua;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class CheckLUA : MonoBehaviour
{
	private const string SetVariableCommand = "SetVariableValue";

	private const string VariableCommand = "Variable";

	private static HashSet<string> FunctionsLUA;

	private static HashSet<string> ArbitraryStrings;

	private static HashSet<string> ScenesNames;

	private static HashSet<string> ArrivalLocations;

	private static HashSet<string> VisCalNames;

	private static HashSet<string> CopotypeThoughts;

	private static HashSet<string> Reputations;

	private static HashSet<string> Items;

	private static HashSet<string> Actors;

	private static HashSet<string> Locations;

	private static HashSet<string> Variables;

	private static HashSet<string> VariablesFull;

	private static HashSet<string> TasksAndOrbsNames;

	private static HashSet<string> DialogueImagesTypes;

	private static HashSet<string> IgnoredFunctionsNames;

	private static HashSet<string> ItemTypesNames;

	private static HashSet<string> AreaStatesLocationsNames;

	private static HashSet<string> AreaStatesLocationsStates;

	private static HashSet<string> ItemGroupNames;

	private static HashSet<string> gainedThoughts;

	private static HashSet<string> errorsTypesIdsSet;

	private static int typosInFunctionsCount;

	private static int typosInVariablesCount;

	private static string GetLuaScript(DialogueEntry entry)
	{
		return null;
	}

	private static string GetConditionsLuaScript(DialogueEntry entry)
	{
		return null;
	}

	private static void CheckPrimaryExp(PrimaryExpr exp, string id)
	{
	}

	private static void CheckAccesses(string expresion, List<Access> acc, string id)
	{
	}

	private static void CheckExpresion(string parentExpresion, Expr expresion, string id)
	{
	}

	private static void CheckOperation(string expresion, Operation operation, string id)
	{
	}

	private static void CheckTerm(string expresion, Term term, string id)
	{
	}

	private static void CheckNumberLiteral(NumberLiteral numberLiteral, string id)
	{
	}

	private static void CheckBoolLiteral(BoolLiteral boolLiteral, string id)
	{
	}

	private static void CheckStringLiteral(string expresion, StringLiteral stringLiteral, string id)
	{
	}

	private static void CheckAssignment(Assignment ass, string id)
	{
	}

	private static void CheckReturnStatement(ReturnStmt rtnStmt, string id)
	{
	}

	private static void CheckVariable(Var var, string id)
	{
	}
}
