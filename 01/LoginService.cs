namespace CrackMe_01
{
    public interface ILoginService
    {
        bool CheckPermission(string? userName, string? password);
    }

    public class LoginService : ILoginService
    {
        public bool CheckPermission(string? userName, string? password) => userName == "admin" && password == "MB";
    }
}