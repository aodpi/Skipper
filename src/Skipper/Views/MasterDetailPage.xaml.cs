using System;

using Skipper.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Skipper.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MasterDetailViewModel; }
        }

        public MasterDetailPage()
        {
            InitializeComponent();
            Loaded += MasterDetailPage_Loaded;
        }

        private async void MasterDetailPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
