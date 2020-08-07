using System;

using Skipper.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Skipper.Views
{
    public sealed partial class MapPage : Page
    {
        private MapViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MapViewModel; }
        }

        public MapPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.InitializeAsync(mapControl);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}
