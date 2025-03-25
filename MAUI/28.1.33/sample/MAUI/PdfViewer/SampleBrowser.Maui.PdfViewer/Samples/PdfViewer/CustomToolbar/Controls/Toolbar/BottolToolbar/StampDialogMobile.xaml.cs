#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Maui.Controls.Shapes;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class StampDialogMobile : ContentView
{
    Ellipse? selectedColorButtonHighlight;
    Button? PreButton;

    public event EventHandler<CustomStampEventArgs?>? CustomStampCreated;

    internal void Initialize()
    {
        InitializeComponent();
        this.PropertyChanged += StampDialogPropertyChanged;
    }

    private async void StampDialogPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == "IsVisible" && this.IsVisible == true)
        {
            await Task.Delay(250);
            createEntry?.Focus();
        }
        else if (e.PropertyName == "IsVisible" && this.IsVisible == false)
        {
            InitializeDialog();
        }
    }

    private void OnBackButtonClicked(object sender, EventArgs e)
    {
#if ANDROID
        HideKeyboard();
#endif
        createEntry?.Unfocus();
        this.IsVisible = false;
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(e.NewTextValue))
        {
            label.Text = "Text";
        }
        else
        {
            label.Text = e.NewTextValue;
        }
        double textWidth = MeasureTextWidth(label.Text, label.FontSize);
        double newBorderWidth = textWidth + 50;
        border.WidthRequest = newBorderWidth;
        layout.WidthRequest = newBorderWidth;
    }

    private double MeasureTextWidth(string text, double fontSize)
    {
        label.Text = text;
        Size sizeRequest = label.Measure(double.PositiveInfinity, double.PositiveInfinity);
        return sizeRequest.Width;
    }

    private void ColorHighlightButton_Clicked(object sender, EventArgs e)
    {
        if (PreButton != null)
        {
            PreButton.HeightRequest = 40;
            PreButton.WidthRequest = 40;
            PreButton.CornerRadius = 20;
        }
        PreButton = sender as Button;
        if (selectedColorButtonHighlight == null)
        {
            selectedColorButtonHighlight = new Ellipse();
            selectedColorButtonHighlight.WidthRequest = 40;
            selectedColorButtonHighlight.HeightRequest = 40;
            selectedColorButtonHighlight.VerticalOptions = LayoutOptions.Center;
            selectedColorButtonHighlight.HorizontalOptions = LayoutOptions.Center;
            selectedColorButtonHighlight.StrokeThickness = 2;
            if (Application.Current != null && Application.Current.Resources != null)
            {
                selectedColorButtonHighlight.SetAppThemeColor(Ellipse.StrokeProperty,
                    (Color)Application.Current.Resources["ContentForeground"],
                    (Color)Application.Current.Resources["ContentForeground"]);

                if (Application.Current.RequestedTheme == AppTheme.Unspecified)
                {
                    selectedColorButtonHighlight.Stroke = Color.FromArgb("#1C1B1F");
                }
            }
            else
            {
                // Fallback to a default color if Application.Current or Resources are null
                selectedColorButtonHighlight.Stroke = Color.FromArgb("#1C1B1F");
            }
        }
        if (sender is Button button)
        {
            button.HeightRequest = 32;
            button.WidthRequest = 32;
            button.CornerRadius = 16;
            createEntry.Unfocus();
            button.HorizontalOptions = LayoutOptions.Center;
            button.VerticalOptions = LayoutOptions.Center;
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);
            Grid.SetColumn(selectedColorButtonHighlight, column);
            Grid.SetRow(selectedColorButtonHighlight, row);
            border.Stroke = button.BackgroundColor;
            border.BackgroundColor = GetLightenColor(button.BackgroundColor, (float)0.85);
            label.TextColor = button.BackgroundColor;
        }
        if (selectedColorButtonHighlight.Parent == null)
        {
            stampColor.Children.Add(selectedColorButtonHighlight);
        }
    }

    internal Color GetLightenColor(Color color, float lighteningFactor)
    {
        float R = (float)color.Red;
        float G = (float)color.Green;
        float B = (float)color.Blue;

        if (lighteningFactor < -1)
            lighteningFactor = -1;
        else if (lighteningFactor > 1)
            lighteningFactor = 1;

        if (lighteningFactor < 0)
        {
            lighteningFactor = 1 + lighteningFactor;
            R *= lighteningFactor;
            G *= lighteningFactor;
            B *= lighteningFactor;
        }
        else
        {
            R = (1 - R) * lighteningFactor + R;
            G = (1 - G) * lighteningFactor + G;
            B = (1 - B) * lighteningFactor + B;
        }
        return Color.FromRgba((float)R, (float)G, (float)B, color.Alpha);
    }

    private void OnApplyButtonClicked(object sender, EventArgs e)
    {
#if ANDROID
        HideKeyboard();
#endif
        createEntry?.Unfocus();
        CustomStampEventArgs customStampEventArgs = new CustomStampEventArgs(border);
        CustomStampCreated?.Invoke(this, customStampEventArgs);
    }

    void InitializeDialog()
    {
        stampColor.Children.Remove(selectedColorButtonHighlight);
        label.Text = "Text";
        border.Stroke = Color.FromArgb("#A007A3");
        border.BackgroundColor = Color.FromArgb("#FADFFB");
        label.TextColor = Color.FromArgb("#A007A3");
        border.WidthRequest = 80;
        createEntry.Text = "";
        if (PreButton != null)
        {
            PreButton.HeightRequest = 35;
            PreButton.WidthRequest = 35;
            PreButton.CornerRadius = 20;
        }
    }
    public void ShowKeyboard()
    {
#if ANDROID
        if (createEntry.Handler != null)
        {
            if (createEntry.Handler.PlatformView is Android.Widget.TextView textView)
            {
                ShowKeyboard(textView);
            }
        }
#endif
    }
    public void HideKeyboard()
    {
#if ANDROID
        if (createEntry.Handler != null)
        {
            if (createEntry.Handler.PlatformView is Android.Widget.TextView textView)
            {
                HideKeyboard(textView);
            }
        }
#endif
    }
#if ANDROID
    private void ShowKeyboard(Android.Views.View inputView)
    {
        if (inputView.Context == null)
        {
            return;
        }
        using (var inputMethodManager = (Android.Views.InputMethods.InputMethodManager?)inputView.Context.GetSystemService(Android.Content.Context.InputMethodService))
        {
            inputMethodManager?.ShowSoftInput(inputView, Android.Views.InputMethods.ShowFlags.Forced);
        }
    }

    private void HideKeyboard(Android.Views.View inputView)
    {
        using (var inputMethodManager = (Android.Views.InputMethods.InputMethodManager?)inputView.Context?.GetSystemService(Android.Content.Context.InputMethodService))
        {
            if (inputMethodManager != null)
            {
                var token = Platform.CurrentActivity?.CurrentFocus?.WindowToken;
                inputMethodManager.HideSoftInputFromWindow(token, Android.Views.InputMethods.HideSoftInputFlags.None);
                Platform.CurrentActivity?.Window?.DecorView.ClearFocus();
            }
        }
    }
#endif

    private void OnEntryFocused(object sender, FocusEventArgs e)
    {
        if (e.IsFocused == true)
            ShowKeyboard();
        else
            HideKeyboard();
    }
}