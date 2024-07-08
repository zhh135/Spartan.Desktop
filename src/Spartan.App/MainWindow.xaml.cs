using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Spartan.App.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUIEx;


namespace Spartan.App
{
    public sealed partial class MainWindow : WindowEx
    {
        private static MainWindow? _Current;
        public new static MainWindow Current => _Current ??= new();

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
