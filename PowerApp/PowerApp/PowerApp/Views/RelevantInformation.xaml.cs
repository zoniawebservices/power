﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelevantInformation : ContentPage
    {
        public RelevantInformation()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Successful", "Data as Been Uploaded Successfully", "Ok");
        }
    }
}
