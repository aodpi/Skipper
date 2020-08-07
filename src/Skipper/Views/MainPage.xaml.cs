using System;

using Skipper.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Skipper.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
