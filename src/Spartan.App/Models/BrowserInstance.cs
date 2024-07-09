using Microsoft.UI.Xaml.Controls;

namespace Spartan.App.Models
{
    public class BrowserInstance
    {
        public WebView2 CurrentWebViewInstance { get; set; }

        public string DocumentTitle { get { return CurrentWebViewInstance.CoreWebView2.DocumentTitle; } }
        public string Url { get { return CurrentWebViewInstance.Source.ToString(); } }
        public string Favicon { get { return CurrentWebViewInstance.CoreWebView2.FaviconUri; } }

        public bool CanGoBack { get { return CurrentWebViewInstance.CoreWebView2.CanGoBack; } }
        public bool CanGoForward { get { return CurrentWebViewInstance.CoreWebView2.CanGoForward; } }

        public bool GoBack()
        {
            if (CurrentWebViewInstance.CanGoBack)
            {
                CurrentWebViewInstance.CoreWebView2.GoBack();
                return true;
            }
            return false;
        }

        public bool GoForward()
        {
            if (CurrentWebViewInstance.CanGoForward)
            {
                CurrentWebViewInstance.CoreWebView2.GoForward();
                return true;
            }
            return false;
        }
    }
}
