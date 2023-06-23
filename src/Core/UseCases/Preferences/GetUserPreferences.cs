
public static class GetUserPreferences
{
    public static async Task<List<UserPreference>> Handler(string userId, IUserPreferenceRepository repository)
    {
        var preferences = await repository.GetPreferences(userId);
        
        return preferences;
    }
}