
public interface IUserProfileRepository
{
    Task<UserProfile?> FindAsync(string userId);
}