using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    internal class MenuTabbedPageViewModel : BaseViewModel
    {
        public MenuTabbedPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
    }
}
