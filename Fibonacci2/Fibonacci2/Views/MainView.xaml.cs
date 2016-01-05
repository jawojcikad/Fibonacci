using Fibonacci2.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Fibonacci2.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewViewModel();
        }
    }
}
