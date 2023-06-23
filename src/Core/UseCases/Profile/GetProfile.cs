
public static class GetProfile
{
    public static async Task<UserProfile?> Handler(IUserProfileRepository profileRepository)
    {
        var profile = await profileRepository.FindAsync("cesar.colli");
        
        return profile;
    }
}