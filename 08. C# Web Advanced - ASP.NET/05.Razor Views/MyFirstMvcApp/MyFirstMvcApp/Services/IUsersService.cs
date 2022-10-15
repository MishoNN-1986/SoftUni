namespace MyFirstMvcApp.Services
{
    public interface IUsersService
    {
        int GetCount();

        IEnumerable<string> GetUserNames();
    }
}
