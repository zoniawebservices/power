﻿using PowerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HydroA : ContentPage
    {
        public HydroA()
        {
            InitializeComponent();
            BindingContext = new HydroAViewModel(this.Navigation);
        }
    }
}
