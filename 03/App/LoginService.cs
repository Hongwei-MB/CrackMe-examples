using LoginWrapper;

namespace CrackMe_03
{
    public interface ILoginService
    {
        void CheckPermission(string? userName, string? password);
    }

    public class LoginService : ILoginService
    {
        private readonly ManagedLoginService _managedLoginService = new ManagedLoginService();
        public void CheckPermission(string? userName, string? password)
        {
            _managedLoginService.CheckPermission(userName ?? "", password ?? "");
        }
    }
}