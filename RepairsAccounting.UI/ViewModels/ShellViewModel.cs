using Caliburn.Micro;

namespace RepairsAccounting.UI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        public ShellViewModel()
        {
            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public void ExitApplication()
        {
            TryClose();
        }

        public void Repairs()
        {
            //ActivateItem(IoC.Get<UserDisplayViewModel>());
        }

        public void LogOut()
        {
            //_user.ResetUserModel();
            //_apiHelper.LogOffUser();
            //ActivateItem(IoC.Get<LoginViewModel>());
            //NotifyOfPropertyChange(() => IsLoggedIn);
        }
    }
}
