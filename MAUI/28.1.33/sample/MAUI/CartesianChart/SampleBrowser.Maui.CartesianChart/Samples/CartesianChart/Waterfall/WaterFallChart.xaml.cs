#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Charts;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public partial class WaterFallChart : SampleView
    {
        public WaterFallChart()
        {
            InitializeComponent();
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            if (!IsCardView)
            {
                Chart1.Title = (Label)layout.Resources["title"];
                myYaxis.Title = new ChartAxisTitle() { Text = "Dollar (USD)" }; 
                myXAxis.Title= new ChartAxisTitle() { Text = "Month" };
            }
        }
        public override void OnDisappearing()
        {
            base.OnDisappearing();
            Chart1.Handler?.DisconnectHandler();
        }
    }
}
