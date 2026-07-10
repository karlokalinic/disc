using System;

public interface ITabbedSlottable<TabType, SlottableType> : IComparable<SlottableType> where TabType : struct, IConvertible
{
	TabType GetTab();

	bool IsFresh();
}
