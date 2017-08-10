using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DietCalculator.ViewModels
{
    public class AboutViewModel
    {
        public string Title { get; }
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }


    }
}
