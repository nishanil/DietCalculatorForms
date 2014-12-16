﻿using DietCalculator.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietCalculator.Core.View
{
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();

            Title = "Diet Calculator";

            BindingContext = new DietCalculatorViewModel(Navigation);

           
        }
    }
}
