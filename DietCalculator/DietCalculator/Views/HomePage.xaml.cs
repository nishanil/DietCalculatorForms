using DietCalculator.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DietCalculator.Core.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            Title = "Diet Calculator";

            BindingContext = new DietCalculatorViewModel(Navigation);

           
        }
    }
}
