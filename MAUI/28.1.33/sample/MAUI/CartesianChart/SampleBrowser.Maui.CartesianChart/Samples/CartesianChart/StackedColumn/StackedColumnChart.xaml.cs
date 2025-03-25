#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Charts;
using System.Windows.Input;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public partial class StackedColumnChart: SampleView
    {
        public StackedColumnChart()
        {
            InitializeComponent();
        }
        public override void OnAppearing()
        {
            base.OnAppearing();
            hyperLinkLayout.IsVisible = !IsCardView;

#if IOS
            if (IsCardView)
            {
                chart.WidthRequest = 350;
                chart.HeightRequest = 400;
                chart.VerticalOptions = LayoutOptions.Start;
            }
#endif

            if (!IsCardView)
            {
                yAxis.Title = new ChartAxisTitle() { Text = "Revenue (EUR)" };
                xAxis.Title = new ChartAxisTitle() { Text = "Year" };
            }
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            chart.Handler?.DisconnectHandler();
        }
    }
}
