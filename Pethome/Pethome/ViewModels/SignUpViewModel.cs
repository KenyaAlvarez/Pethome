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
        public async Task RegisterCommand()
        {
            await Navigation.PushAsync(new MenuPage());
        }

        #endregion

        #region COMANDOS
        public ICommand Registercommand => new Command(async () => await RegisterCommand());
        #endregion
    }
}

