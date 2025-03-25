#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleBrowser.SfTimePicker
{
    public partial class TimePickerCustomization : SampleView
    {
        public TimePickerCustomization()
        {
            InitializeComponent();
            if(Device.RuntimePlatform == Device.iOS)
            {
                sftimepicker.BackgroundColor = Color.FromHex("#FAFAFA");
                sftimepicker.ColumnHeaderBackgroundColor = Color.FromHex("#FAFAFA");
                sftimepicker.HeaderBackgroundColor = Color.FromHex("#FAFAFA");
            }
            if (Device.RuntimePlatform == Device.UWP)
            {
                layoutRoot.HorizontalOptions = LayoutOptions.Center;
                layoutRootGrid.WidthRequest = 500;
            }
        }
    }
}