﻿using Pethome.Views;
using Pethome.Views.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region VARIABLES
        
        #endregion

        #region CONSTRUCTOR
        public MenuViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
       
        #endregion

        #region PROCESOS
        public async Task BigdogsCommand()
        {
            await Navigation.PushAsync(new BigDogsPage());
        }

      
        #endregion

        #region COMANDOS
        public ICommand Bigdogscommand => new Command(async () => await BigdogsCommand());
        
        #endregion
    }
}

