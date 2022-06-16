using Pethome.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    public class LoginViewModel :  BaseViewModel
    {
        #region VARIABLES
        string _User;
        string _Password;
        #endregion

        #region CONSTRUCTOR
        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string User
        {
            get { return _User; }
            set { SetValue(ref _User, value); }
        }
        public string Password
        {
            get { return _Password; }
            set { SetValue(ref _Password, value); }
        }

        #endregion

        #region PROCESOS
        public async Task LoginCommand()
        {
            await Navigation.PushAsync(new MenuPage());
        }
        public async Task SignUpCommand()
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        #endregion

        #region COMANDOS
        public ICommand logincommand => new Command(async () => await LoginCommand());
        public ICommand SignUpcommand => new Command(async () => await SignUpCommand());
        #endregion
    }
}
