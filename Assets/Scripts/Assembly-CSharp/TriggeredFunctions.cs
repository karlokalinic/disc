using System;

[Flags]
public enum TriggeredFunctions
{
	AppearedObjectRightHand = 1,
	AppearedObjectLeftHand = 2,
	AppearedObject = 4,
	AppearedObjectZero = 8,
	AppearedProp = 0x10,
	DisappearedObjectRightHand = 0x20,
	DisappearedObjectLeftHand = 0x40,
	DisappearedObject = 0x80,
	DisappearedProp = 0x100,
	HidProp = 0x200,
	ObjectToCharPos = 0x400
}
