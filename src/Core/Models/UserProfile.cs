
public sealed class UserProfile
{
    public UserProfile(string username, string email)
    {
        if (string.IsNullOrEmpty(username))
            throw new ArgumentNullException(nameof(username));

        Username = username;
        Email = email;
    }

    public string Username { get; }

    public string Email { get; }
}