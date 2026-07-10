using UnityEngine;

public static class RestoredGameState
{
    const string Prefix = "restored.";
    public const int JournalCapacity = 7;

    public static void SetFlag(string key, bool value = true)
    {
        if (string.IsNullOrEmpty(key)) return;
        PlayerPrefs.SetInt(Prefix + "flag." + Normalize(key), value ? 1 : 0);
        PlayerPrefs.Save();
    }

    public static bool HasFlag(string key)
    {
        if (string.IsNullOrEmpty(key)) return true;
        string normalized = Normalize(key);
        if (PlayerPrefs.GetInt(Prefix + "flag." + normalized, 0) != 0) return true;
        if (PlayerPrefs.GetInt("dialogue." + key, 0) != 0) return true;
        if (PlayerPrefs.GetInt("rootworld.trigger." + key, 0) != 0) return true;
        return false;
    }

    public static void Increment(string key)
    {
        if (string.IsNullOrEmpty(key)) return;
        string pref = Prefix + "count." + Normalize(key);
        PlayerPrefs.SetInt(pref, PlayerPrefs.GetInt(pref, 0) + 1);
        PlayerPrefs.Save();
    }

    public static int Count(string key)
    {
        return string.IsNullOrEmpty(key) ? 0 : PlayerPrefs.GetInt(Prefix + "count." + Normalize(key), 0);
    }

    public static void UnlockLocation(string key)
    {
        if (string.IsNullOrEmpty(key)) return;
        SetFlag("location." + Normalize(key));
    }

    public static bool IsLocationUnlocked(string key)
    {
        return !string.IsNullOrEmpty(key) && HasFlag("location." + Normalize(key));
    }

    public static void SetObjective(string objective)
    {
        if (string.IsNullOrEmpty(objective)) return;
        PlayerPrefs.SetString(Prefix + "objective", objective);
        Remember("Objective: " + objective);
        PlayerPrefs.Save();
    }

    public static string CurrentObjective()
    {
        return PlayerPrefs.GetString(Prefix + "objective", "Talk to Kim and Klaasje, then follow the strongest lead.");
    }

    public static void Remember(string line)
    {
        if (string.IsNullOrEmpty(line)) return;
        for (int i = JournalCapacity - 1; i > 0; i--)
            PlayerPrefs.SetString(Prefix + "journal." + i, PlayerPrefs.GetString(Prefix + "journal." + (i - 1), ""));
        PlayerPrefs.SetString(Prefix + "journal.0", line);
        PlayerPrefs.Save();
    }

    public static string JournalLine(int index)
    {
        if (index < 0 || index >= JournalCapacity) return "";
        return PlayerPrefs.GetString(Prefix + "journal." + index, "");
    }

    public static string Normalize(string key)
    {
        return key.Trim().ToLowerInvariant().Replace(' ', '_');
    }
}