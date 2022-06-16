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
        string _Usuario;
        string _Password;
        #endregion

        #region CONSTRUCTOR
        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Usuario; }
            set { SetValue(ref _Usuario, value); }
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

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMANDOS
        public ICommand logincommand => new Command(async () => await LoginCommand());
        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);
        #endregion
    }
}
