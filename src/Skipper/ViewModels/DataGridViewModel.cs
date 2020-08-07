﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using GalaSoft.MvvmLight;

using Skipper.Core.Models;
using Skipper.Core.Services;

namespace Skipper.ViewModels
{
    public class DataGridViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
