#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Maui.Controls.Shapes;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class InkColorCode : ContentView

{
    Ellipse? selectedColorButtonHighlight;

    Button? PreButton = null;
    internal void Initialize()
    {
        InitializeComponent();
        colorPaletteBorder.Content = MyGrid;
        this.Content = colorPaletteBorder;
        this.PropertyChanged += InkColorCode_PropertyChanged;
    }

    private void InkColorCode_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(IsVisible))
        {
            if (IsVisible == false)
            {
                if (PreButton != null && selectedColorButtonHighlight != null)
                {
                    PreButton.HeightRequest = 30;
                    PreButton.WidthRequest = 30;
                    PreButton.CornerRadius = 15;
                    selectedColorButtonHighlight.Stroke = Brush.Transparent;
                    if (selectedColorButtonHighlight.Parent == null)
                    {
                        MyInk.Children.Remove(selectedColorButtonHighlight);
                    }
                    else
                    {
                        MyInk.Children.Remove(selectedColorButtonHighlight);
                        selectedColorButtonHighlight = null;
                    }
                }
            }
        }
    }

#if MACCATALYST
    Border colorPaletteBorder = new Border()
    {
        BackgroundColor = Color.FromArgb("#EEE8F4"),
        Stroke = Color.FromArgb("#26000000"),
        Padding = new Thickness(0),
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        StrokeShape = new RoundRectangle
        {
            CornerRadius = new CornerRadius(12)
        },
        Shadow = new Shadow
        {
            Offset = new Point(-1, 0),
            Brush = Color.FromRgba("#000000"),
            Radius = 8,
            Opacity = 0.5f
        },
        WidthRequest = 290,
    };
#else
    Border colorPaletteBorder = new Border()
    {
        BackgroundColor = Color.FromArgb("#EEE8F4"),
        Stroke = Color.FromArgb("#26000000"),
        StrokeThickness = 1,
        VerticalOptions = LayoutOptions.Start,
        HorizontalOptions = LayoutOptions.Start,
        StrokeShape = new RoundRectangle
        {
            CornerRadius = new CornerRadius(12)
        },
        Shadow = new Shadow
        {
            Offset = new Point(-1, 0),
            Brush = Color.FromRgba("#000000"),
            Radius = 8,
            Opacity = 0.5f
        },
        WidthRequest = 280,
    };
#endif
    private void ColorHeighlightButton_Clicked(object sender, EventArgs e)
    {
        if (PreButton != null)
        {
            PreButton.HeightRequest = 30;
            PreButton.WidthRequest = 30;
            PreButton.CornerRadius = 15;
        }
        PreButton = sender as Button;
        if (selectedColorButtonHighlight == null)
        {
            selectedColorButtonHighlight = new Ellipse();
            selectedColorButtonHighlight.WidthRequest = 30;
            selectedColorButtonHighlight.HeightRequest = 30;
            selectedColorButtonHighlight.VerticalOptions = LayoutOptions.Center;
            selectedColorButtonHighlight.HorizontalOptions = LayoutOptions.Center;
            selectedColorButtonHighlight.Stroke = Brush.Black;
            selectedColorButtonHighlight.StrokeThickness = 2;
        }
        if (sender is Button button)
        {
            button.HeightRequest = 22;
            button.WidthRequest = 22;
            button.CornerRadius = 11;
            button.HorizontalOptions = LayoutOptions.Center;
            button.VerticalOptions = LayoutOptions.Center;
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);
            Grid.SetColumn(selectedColorButtonHighlight, column);
            Grid.SetRow(selectedColorButtonHighlight, row);
            if (BindingContext is CustomToolbarViewModel bindingContext)
            {
                bindingContext.IsDeskTopColorToolbarVisible = false;
                bindingContext.IsDeskTopFillColorToolbarVisible = false;
                bindingContext.CloseFreeTextColorPallete();
                bindingContext.ColorCommand.Execute(button.BackgroundColor);
            }
        }
        if (selectedColorButtonHighlight.Parent == null)
        {
            MyInk.Children.Add(selectedColorButtonHighlight);
        }
        if(BindingContext is CustomToolbarViewModel bindingContextColorPalette)
        {
            bindingContextColorPalette.IsInkColorPalleteVisible = false;
        }
    }

    private void OpacitySliderValue_Changed(object sender, EventArgs e)
    {
        float opacity = (float)inkOpacitySlider.Value;
        if (BindingContext is CustomToolbarViewModel bindingContext)
        {
            bindingContext.IsDeskTopColorToolbarVisible = true;
            bindingContext.IsDeskTopFillColorToolbarVisible = false;
            bindingContext.OpacityCommand.Execute(opacity);
        }
    }
}