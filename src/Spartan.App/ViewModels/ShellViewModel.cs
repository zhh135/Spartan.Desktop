using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;

using Spartan.App.Contracts.ViewModels;
using Spartan.App.Models;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;


namespace Spartan.App.ViewModels
{
    public partial class ShellViewModel :ObservableRecipient, IViewModel
    {
        [ObservableProperty] private List<BrowserInstance> _browserInstances;
        [ObservableProperty] private String _title;

        public ShellViewModel()
        {
            _browserInstances = new List<BrowserInstance>();
        }

        public void OnPageLoaded(object sender, RoutedEventArgs e)
        {
            // Create a browser instance when page loaded.
            var HomeInstance = new BrowserInstance();
            if (_browserInstances is not null)
            {
                _browserInstances.Add(HomeInstance);
            }
            else
            {
                _browserInstances = new List<BrowserInstance>();
                _browserInstances.Add(HomeInstance);   
            }
        }

        public void AddNewTab()
        {
            var newInstance = new BrowserInstance();
            _browserInstances.Add(newInstance);
        }
    }
}
