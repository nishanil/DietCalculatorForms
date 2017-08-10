using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietCalculator.Core.ViewModel
{
    public class ResultsViewModel
    {
        public string CaloriesPerDay { get; set; }
        public string LeanBodyMass { get; set; }
        public string PercentBodyFat { get; set; }
        public string WaistHipsRatio { get; set; }
        public string BMI { get; set; }
        public string CholesterolRatio { get; set; }
        public string WaistHeightRatio { get; set; }
        public string IdealWeight { get; set; }
    }
}
