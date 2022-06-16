using Pethome.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
   public class SignUpViewModel : BaseViewModel
    {
        #region VARIABLES
        string _Name;
        string _FirstName;
        string _Password;
       
        
        #endregion

        #region CONSTRUCTOR
        public SignUpViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Name
        {
            get { return _Name; }
            set { SetValue(ref _Name, value); }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { SetValue(ref _FirstName, value); }
        }

        public string Password
        {
            get { return _Password; }
            set { SetValue(ref _Password, value); }
        }

       
        #endregion

        #region PROCESOS
        public async Task registerCommand()
        {
            await Navigation.PushAsync(new LoginPage());
        }

        #endregion

        #region COMANDOS
        public ICommand registercommand => new Command(async () => await registerCommand());
        #endregion
    }
}

