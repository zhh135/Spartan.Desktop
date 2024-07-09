using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Spartan.App.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace Spartan.App.Views
{
    public sealed partial class BrowserPage : Page
    {
        private static readonly DependencyProperty BrowserInstanceProperty = DependencyProperty.Register(
        nameof(BrowserInstance), typeof(Models.BrowserInstance), typeof(BrowserPage), new PropertyMetadata(null));

        public BrowserInstance BrowserInstance
        {
            get => ( BrowserInstance )GetValue( BrowserInstanceProperty );
            set => SetValue( BrowserInstanceProperty, value );
        }

        public BrowserPage()
        {
            this.InitializeComponent();

            Loaded += BrowserPage_Loaded;
        }

        private void BrowserPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (BrowserInstance != null)
            {
                BrowserInstance.CurrentWebViewInstance = WebViewControl;
            }
            else
            {
                BrowserInstance = new BrowserInstance();
                BrowserInstance.CurrentWebViewInstance = WebViewControl;
            }
        }
    }
}
