using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Spartan.App.Controls
{
    public sealed partial class SpartanWebView : WebView2
    {
        private CoreWebView2Environment environment;
        private CoreWebView2Controller controller;
        
        public SpartanWebView()
        {
            Loaded += EnsureCoreSpartanWebView;
        }

        private async void EnsureCoreSpartanWebView(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {
            
            CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();
            options.EnableTrackingPrevention = true;
            options.ExclusiveUserDataFolderAccess = true;
            options.Language = Windows.Globalization.Language.CurrentInputMethodLanguageTag;

            //environment = await CoreWebView2Environment.CreateWithOptionsAsync(null, null, options);
            //await EnsureCoreWebView2Async(environment);
        }
    }
}
