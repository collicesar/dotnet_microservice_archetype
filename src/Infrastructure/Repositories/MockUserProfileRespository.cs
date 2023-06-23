
public class MockUserProfileRespository : IUserProfileRepository
{
    public async Task<UserProfile?> FindAsync(string userId)
    {
        return new UserProfile("cesar.colli", "cesar.colli@digitalfemsa.com");
    }
}