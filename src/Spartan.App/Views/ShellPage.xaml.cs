using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Spartan.App.ViewModels;
using Spartan.App.Views.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace Spartan.App.Views
{
    public sealed partial class ShellPage : ShellPageBase
    {
        public ShellPage()
        {
            this.InitializeComponent();
            Loaded += ViewModel.OnPageLoaded;
        }
    }

    public class ShellPageBase : AppPageBase<ShellViewModel>
    {

    }
}
