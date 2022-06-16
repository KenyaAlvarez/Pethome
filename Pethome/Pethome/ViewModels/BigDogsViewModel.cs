using Pethome.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    public class BigDogsViewModel : BaseViewModel
    {
        #region VARIABLES
       
        #endregion

        #region CONSTRUCTOR
        public BigDogsViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        
        #endregion

        #region PROCESOS
        public async Task LoginCommand()
        {
            await Navigation.PushAsync(new MenuPage());
        }
      

        #endregion

        #region COMANDOS
        public ICommand logincommand => new Command(async () => await LoginCommand());
       
        #endregion
    }
}

