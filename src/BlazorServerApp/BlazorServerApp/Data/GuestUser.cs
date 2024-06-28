namespace BlazorServerApp.Data
{
    public static class GuestUser
    {
        public static User GetUser()=> new User
            {
                UserId = 1,
                AccessToken = "test AccessToken",
                RefreshToken = "test RefreshToken",
                EmailAddress = "test@mail.ru",
                FirstName = "test",
                LastName = "test",
                MiddleName = "test",
                Password = "test",
                ConfirmPassword = "test",
                Role = new Role
                {
                    RoleId = 1,
                    RoleDesc = "guest"
                }
            };        
    }
}
