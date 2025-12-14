namespace FinalProject201;

// Utility class demonstrating safe file I/O with error handling.
// Used to satisfy try/catch and file I/O rubric requirements.

internal static class FileHelper
{
    private static string FilePath =>
        Path.Combine(FileSystem.AppDataDirectory, "app_log.txt");

    // Writes text to a file safely
    public static bool TryWrite(string text, out string message)
    {
        try
        {
            Directory.CreateDirectory(FileSystem.AppDataDirectory);
            File.AppendAllLines(FilePath, new[] { text });
            message = "File write successful.";
            return true;
        }
        catch (Exception ex)
        {
            message = $"File write failed: {ex.Message}";
            return false;
        }
    }

    // Reads text from a file safely
    public static bool TryRead(out string contents, out string message)
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                contents = "";
                message = "File does not exist.";
                return false;
            }

            contents = File.ReadAllText(FilePath);
            message = "File read successful.";
            return true;
        }
        catch (Exception ex)
        {
            contents = "";
            message = $"File read failed: {ex.Message}";
            return false;
        }
    }
}
