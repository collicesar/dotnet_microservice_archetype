
public interface IUserPreferenceRepository
{    
    Task<List<UserPreference>> GetPreferences(string userId);
    Task<bool> Create(UserPreference preference);
    Task<bool> Update(UserPreference preference);
}