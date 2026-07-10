public enum FileOpResultCode
{
	Undefined = -1,
	Success = 0,
	CreateDirectoryFailed = 10,
	DeleteFileFailed = 20,
	MoveFileFailed = 30,
	MoveFile_LoadFileFailed = 31,
	MoveFile_DeleteFileFailed = 32,
	MoveFile_SaveFileFailed = 33,
	CreateFileFailed = 40,
	ReadFileFailed = 50
}
