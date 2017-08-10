using DietCalculator.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DietCalculator.Core.View
{
    public partial class ResultsPage : ContentPage
    {
        public ResultsPage()
        {
            InitializeComponent();

            Title = "Results";
        }

        public ResultsPage(ResultsViewModel viewModel) : this()
        {
            BindingContext = viewModel;
        }
    }
}
