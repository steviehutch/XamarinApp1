﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace XamarinApp1.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("9diqx2Yylc2nGObz2vJe~72boTGI_Y95nNZXXwDeTfw~AgeKkBxU76GeWMtJT8L1T6pDZ48q_OmQj8jalKdp8GDIvs6oHnPWngqusYPsbTPV");

            LoadApplication(new XamarinApp1.App());
        }
    }
}
