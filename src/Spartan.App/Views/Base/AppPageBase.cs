﻿using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;

using Spartan.App.Contracts.ViewModels;

namespace Spartan.App.Views.Base
{
    public abstract class AppPageBase<TViewModel> : Page
    where TViewModel : class, IViewModel
    {
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(TViewModel), typeof(TViewModel),
                                        new PropertyMetadata(default));

        public TViewModel ViewModel
        {
            get => (TViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        protected AppPageBase()
        {
            ViewModel = App.GetService<TViewModel>();
            DataContext = ViewModel;
        }
    }
}
