using Pethome.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pethome.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BigDogsPage : ContentPage
    {
        public BigDogsPage()
        {
            InitializeComponent();
            BindingContext = new BigDogsViewModel(Navigation);
        }
    }
}