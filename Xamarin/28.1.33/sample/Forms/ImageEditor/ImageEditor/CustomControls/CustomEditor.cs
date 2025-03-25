#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleBrowser.SfImageEditor.CustomControls
{
    public class CustomEditor : Editor
    {
        public CustomEditor()
        {
        }

        public static readonly BindableProperty WatermarkTextProperty =
            BindableProperty.Create("WatermarkText", typeof(string), typeof(CustomEditor), "Enter a caption !!!", BindingMode.Default, null, null);


        public string WatermarkText
        {
            get { return (string)GetValue(WatermarkTextProperty); }
            set { SetValue(WatermarkTextProperty, value); }
        }
    }

    public class RoundedColorButton : Button
    {
        
    }


    public class CustomButton : Button
    {

    }
    public class CustomImageView :Image
    {


    }
}
