
using Dapper;
using Npgsql;
using Microsoft.Extensions.Configuration;
public class NpgUserPreferenceRepository : IUserPreferenceRepository
{
    private readonly IConfiguration _configuration;

    public NpgUserPreferenceRepository(IConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }   

    public async Task<List<UserPreference>> GetPreferences(string userId)
    {
        using var connection = new NpgsqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection"));

        var list = await connection.QueryAsync<UserPreference>
            ("SELECT user_id as UserId, preference_id as PreferenceId, preference_value as PreferenceValue " +
             "FROM users.user_preferences WHERE user_id = @UserId", new { UserId = userId });
        
        return list.ToList();
    }

    public async Task<bool> Create(UserPreference preference)
    {
        using var connection = new NpgsqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection"));

        var affected =
            await connection.ExecuteAsync
                ("INSERT INTO users.user_preferences(user_id, preference_id, preference_value) VALUES (@UserId, @PreferenceId, @PreferenceValue)",
                    preference);

        if (affected == 0)
            return false;

        return true;
    }
    public async Task<bool> Update(UserPreference preference)
    {
        using var connection = new NpgsqlConnection(_configuration.GetValue<string>("ConnectionStrings:DefaultConnection"));

        var affected =
            await connection.ExecuteAsync
                ("UPDATE users.user_preferences SET preference_value = @PreferenceValue WHERE user_id = @UserId and preference_id = @PreferenceId",
                    preference);

        if (affected == 0)
            return false;

        return true;
    }
}