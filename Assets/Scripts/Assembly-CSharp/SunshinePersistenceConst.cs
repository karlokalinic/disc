public static class SunshinePersistenceConst
{
	public const string GetListOfSaves_UnauthorizedAccessExceptionErrorMessage = "Error when trying to load list of saves, check if you have an access to save folder.";

	public const string GetListOfSaves_OtherErrorMessage = "Error when trying to load list of saves.";

	public const string GetListOfSaves_SharingViolationErrorMessage = "Error when trying to load list of saves,\none of save files seems to be opened in another program";

	public const string SaveCoR_DeleteExcessAutosavesErrorMessage = "Error when trying to Delete Excess Autosaves.";

	public const string SaveCoR_SaveErrorMessage = "Error during save file procedure.";

	public static string SaveCoR_FailedToCreateSaveDirectory;

	public static string SaveCoR_FailedToWriteLuaDataToFileString;

	public static string SaveCoR_FailedToWriteLuaDataToFileBytes;

	public static string SaveCoR_FailedToSaveSerializedPreloadData;

	public static string SaveCoR_FailedToSaveSerializePersisterData;

	public static string SaveCoR_FailedToSaveSerializeFOWData;

	public static string SaveCoR_FailedToGetScreenShotTexture;

	public static string SaveCoR_FailedToSaveModifiedTexture;

	public static string SaveCoR_FailedToTransformTextureIntoSaveImage;

	public static string SaveCoR_ZipItSaveError;

	public static string SaveCoR_ZipItAddError;

	public static string SaveCoR_ZipItError;

	public static string SaveCoR_FailedToDeleteTemporarySaveGameFiles;

	public static string SaveCoR_FailedToMoveSaveFileUnauthorizedAccessException;

	public static string SaveCoR_FailedToMoveSaveFile;

	public const string TimeZoneError = "System Time zone Corruption Error.\nGame will not be able to properly save and load SaveFiles.\nCheck system time zone in registry";
}
