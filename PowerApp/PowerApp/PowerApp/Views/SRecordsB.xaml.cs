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
    public partial class SRecordsB : ContentPage
    {
        public SRecordsB()
        {
            InitializeComponent();
        }
        async private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SReports());
        }
    }
}
