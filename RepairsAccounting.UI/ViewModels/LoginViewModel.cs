using Caliburn.Micro;
using RepairsAccounting.DataManager.Services;
using System;

namespace RepairsAccounting.UI.ViewModels
{
    public class LoginViewModel : Screen
    {
		private string _userName = "admin";
		private string _password = "123456";

		private LoginServices _service;
		public LoginViewModel(LoginServices service)
        {
			_service = service;
        }

		public string UserName
		{
			get { return _userName; }
			set
			{
				_userName = value;
				NotifyOfPropertyChange(() => UserName);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				NotifyOfPropertyChange(() => Password);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public bool CanLogIn
		{
			get
			{
				bool output = false;

				if (UserName?.Length > 0 && Password?.Length > 0)
				{
					output = true;
				}
				return output;
			}
		}

		public void LogIn()
		{
			try
			{
				var result = _service.LogIn(_userName, _password);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
