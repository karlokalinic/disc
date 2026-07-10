using System;

namespace Voidforge
{
	[Flags]
	public enum Operation
	{
		Create = 1,
		Read = 2,
		Update = 4,
		Delete = 8,
		None = 0x10,
		Default = 0,
		All = 0xF,
		AllChanges = 0xD,
		CreateRead = 3,
		CreateReadUpdate = 7,
		CreateReadDelete = 0xB,
		CreateUpdate = 5,
		CreateDelete = 9,
		ReadUpdate = 6,
		ReadUpdateDelete = 0xE,
		ReadDelete = 0xA,
		UpdateDelete = 0xC
	}
}
