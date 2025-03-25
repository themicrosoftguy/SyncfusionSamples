
#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;
public partial class ShapesPropertyToolbar : PropertyToolbar
{
    public ShapesPropertyToolbar(CustomToolbarViewModel bindingContext)
    {
        BindingContext = bindingContext;
        InitializeComponent();
        DeleteButtonLayout = deleteButtonLayout;
    }

    private void deleteButtonLayout_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "IsVisible")
        {
            if (deleteButtonLayout.IsVisible)
            {
                deleteButtonLayout.Margin = new Thickness(10, 0, 0, 0);
                lockUnlokButtonLayout.Margin = new Thickness(10, 0, 0, 0);
            }
            else
            {
                deleteButtonLayout.Margin = new Thickness(0, 0, 0, 0);
                lockUnlokButtonLayout.Margin = new Thickness(0, 0, 0, 0);
            }
        }
    }
}