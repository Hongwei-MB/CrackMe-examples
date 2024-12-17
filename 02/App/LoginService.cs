using LoginWrapper;

namespace CrackMe_02
{
    public interface ILoginService
    {
        bool CheckPermission(string? userName, string? password);
    }

    public class LoginService : ILoginService
    {
        private readonly ManagedLoginService _managedLoginService = new ManagedLoginService();
        public bool CheckPermission(string? userName, string? password)
        {
            return _managedLoginService.CheckPermission(userName??"", password??"");
        }
    }
}