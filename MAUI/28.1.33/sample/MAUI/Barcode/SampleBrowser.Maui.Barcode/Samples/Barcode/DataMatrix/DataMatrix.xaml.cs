#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Barcode;

namespace SampleBrowser.Maui.Barcode.SfBarcodeGenerator;

public partial class DataMatrix : SampleView
{
    public DataMatrix()
    {
        InitializeComponent();
    }
    private void inputValueEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            warningLabel.Text = "Value cannot be null or empty";
        }
        else
        {
            warningLabel.Text = "";
            barcodeGenerator.Value = e.NewTextValue;
        }
    }
}