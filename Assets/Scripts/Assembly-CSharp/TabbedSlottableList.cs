using System;
using UnityEngine;
using Voidforge;

public abstract class TabbedSlottableList<TabType, Slottable, Self> : SingletonComponent<Self> where TabType : struct, IConvertible where Slottable : ITabbedSlottable<TabType, Slottable> where Self : MonoBehaviour
{
	public abstract Slottable GetByName(string name);

	public abstract string GetName(Slottable slottable);
}
