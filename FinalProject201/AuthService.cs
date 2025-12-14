namespace FinalProject201;

// Handles account creation + login using local file storage.
internal class AuthService
{
    private readonly string _filePath =
        Path.Combine(FileSystem.AppDataDirectory, "users.txt");

    public bool CreateAccount(string username, string password, out string message)
    {
        username = (username ?? "").Trim();
        password = (password ?? "").Trim();

        if (username.Length < 3 || password.Length < 4)
        {
            message = "Username must be 3+ chars and password must be 4+ chars.";
            return false;
        }

        try
        {
            Directory.CreateDirectory(FileSystem.AppDataDirectory);

            if (File.Exists(_filePath))
            {
                foreach (var line in File.ReadAllLines(_filePath))
                {
                    if (line.StartsWith(username + ",", StringComparison.OrdinalIgnoreCase))
                    {
                        message = "Username already exists.";
                        return false;
                    }
                }
            }

            File.AppendAllLines(_filePath, new[] { $"{username},{password}" });
            message = "Account created successfully.";
            return true;
        }
        catch (Exception ex)
        {
            // Try/Catch rubric requirement lives here
            message = $"File error while creating account: {ex.Message}";
            return false;
        }
    }

    public bool Login(string username, string password, out string message)
    {
        username = (username ?? "").Trim();
        password = (password ?? "").Trim();

        if (username == "" || password == "")
        {
            message = "Please enter both a username and password.";
            return false;
        }

        try
        {
            if (!File.Exists(_filePath))
            {
                message = "No accounts found. Please create an account.";
                return false;
            }

            foreach (var line in File.ReadAllLines(_filePath))
            {
                var parts = line.Split(',');
                if (parts.Length < 2) continue;

                if (parts[0].Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    parts[1] == password)
                {
                    message = "Login successful.";
                    return true;
                }
            }

            message = "Invalid username or password.";
            return false;
        }
        catch (Exception ex)
        {
            message = $"File error while logging in: {ex.Message}";
            return false;
        }
    }
}
