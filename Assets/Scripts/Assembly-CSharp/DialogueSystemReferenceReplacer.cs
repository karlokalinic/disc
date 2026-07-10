using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DialogueSystemReferenceReplacer : MonoBehaviour
{
	private const string PATH = "C:\\dev\\src\\sourceMeld\\Assets";

	private List<string> excludedExtensions;

	private const string DLL_REFERENCE_GUID = "b5a7519e94754fb4a8ea0c272031db78";

	private Dictionary<string, string> replacements;

	private const string BARK_ON_IDLE_DLL = "m_Script: {fileID: 11500000, guid: d24ee66ebd9446342bc603ed07a01d53, type: 3}";

	private const string BARK_ON_IDLE_SRC = "m_Script: {fileID: 11500000, guid: d24ee66ebd9446342bc603ed07a01d53, type: 3}";

	private const string OVERRIDE_NAME_DLL = "m_Script: {fileID: 11500000, guid: 98ecce4c42e1b7a4f829f705273ded84, type: 3}";

	private const string OVERRIDE_NAME_SRC = "m_Script: {fileID: 11500000, guid: 98ecce4c42e1b7a4f829f705273ded84, type: 3}";

	private const string CONVERSATION_TRIGGER_DLL = "m_Script: {fileID: 11500000, guid: f3149f3d62dd98240b892ba638febe56, type: 3}";

	private const string CONVERSATION_TRIGGER_SRC = "m_Script: {fileID: 11500000, guid: f3149f3d62dd98240b892ba638febe56, type: 3}";

	private const string PERSISTENT_POSITION_DLL = "m_Script: {fileID: 11500000, guid: 70a08bf583a262847bfb08afe0bacd23, type: 3}";

	private const string PERSISTENT_POSITION_SRC = "m_Script: {fileID: 11500000, guid: 70a08bf583a262847bfb08afe0bacd23, type: 3}";

	private const string GUI_IMAGE_DLL = "m_Script: {fileID: 11500000, guid: 667ea50fdfe7de643ad1ea735b51e807, type: 3}";

	private const string GUI_IMAGE_SRC = "m_Script: {fileID: 11500000, guid: 667ea50fdfe7de643ad1ea735b51e807, type: 3}";

	private const string DIALOGUE_SYSTEM_CONTROLLER_DLL = "m_Script: {fileID: 11500000, guid: 002f6d6ac2dbbe44994b3cebba65bc22, type: 3}";

	private const string DIALOGUE_SYSTEM_CONTROLLER_SRC = "m_Script: {fileID: 11500000, guid: 002f6d6ac2dbbe44994b3cebba65bc22, type: 3}";

	private const string BARK_TRIGGER_DLL = "m_Script: {fileID: 11500000, guid: 66fdf8d5019aaec4bab62570407b9cd1, type: 3}";

	private const string BARK_TRIGGER_SRC = "m_Script: {fileID: 11500000, guid: 66fdf8d5019aaec4bab62570407b9cd1, type: 3}";

	public void DoIt()
	{
	}

	private void WalkDirectoryTree(DirectoryInfo root)
	{
	}

	private void ReplaceInFile(FileInfo fileInfo)
	{
	}

	private void ReplaceStreaming(FileInfo fileInfo)
	{
	}
}
