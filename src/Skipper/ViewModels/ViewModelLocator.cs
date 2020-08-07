using System;

using GalaSoft.MvvmLight.Ioc;

using Skipper.Services;
using Skipper.Views;

namespace Skipper.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<MasterDetailViewModel, MasterDetailPage>();
            Register<DataGridViewModel, DataGridPage>();
            Register<TelerikDataGridViewModel, TelerikDataGridPage>();
            Register<ChartViewModel, ChartPage>();
            Register<MapViewModel, MapPage>();
            Register<TabViewViewModel, TabViewPage>();
            Register<ImageGalleryViewModel, ImageGalleryPage>();
            Register<ImageGalleryDetailViewModel, ImageGalleryDetailPage>();
            Register<SettingsViewModel, SettingsPage>();
            Register<SchemeActivationSampleViewModel, SchemeActivationSamplePage>();
        }

        public SchemeActivationSampleViewModel SchemeActivationSampleViewModel => SimpleIoc.Default.GetInstance<SchemeActivationSampleViewModel>();

        public SettingsViewModel SettingsViewModel => SimpleIoc.Default.GetInstance<SettingsViewModel>();

        public ImageGalleryDetailViewModel ImageGalleryDetailViewModel => SimpleIoc.Default.GetInstance<ImageGalleryDetailViewModel>();

        public ImageGalleryViewModel ImageGalleryViewModel => SimpleIoc.Default.GetInstance<ImageGalleryViewModel>();

        public TabViewViewModel TabViewViewModel => SimpleIoc.Default.GetInstance<TabViewViewModel>();

        public MapViewModel MapViewModel => SimpleIoc.Default.GetInstance<MapViewModel>();

        public ChartViewModel ChartViewModel => SimpleIoc.Default.GetInstance<ChartViewModel>();

        public TelerikDataGridViewModel TelerikDataGridViewModel => SimpleIoc.Default.GetInstance<TelerikDataGridViewModel>();

        public DataGridViewModel DataGridViewModel => SimpleIoc.Default.GetInstance<DataGridViewModel>();

        public MasterDetailViewModel MasterDetailViewModel => SimpleIoc.Default.GetInstance<MasterDetailViewModel>();

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => SimpleIoc.Default.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => SimpleIoc.Default.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
