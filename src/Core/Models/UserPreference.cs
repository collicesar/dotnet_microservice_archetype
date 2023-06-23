public sealed class UserPreference
{
    public UserPreference()
    {
    }

    public UserPreference(string userId, string preferenceId, string preferenceValue)
    {
        UserId = userId;
        PreferenceId = preferenceId;
        PreferenceValue = preferenceValue;
    }

    public string UserId { get; set;}
    public string PreferenceId { get; set;}
    public string PreferenceValue { get; set;}  
}