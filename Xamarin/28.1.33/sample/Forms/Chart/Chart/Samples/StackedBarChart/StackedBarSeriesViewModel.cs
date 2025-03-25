#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.ObjectModel;

namespace SampleBrowser.SfChart
{


    public class StackedBarSeriesViewModel
    {
        public ObservableCollection<ChartDataModel> StackedBarData1 { get; set; }

        public ObservableCollection<ChartDataModel> StackedBarData2 { get; set; }

        public ObservableCollection<ChartDataModel> StackedBarData3 { get; set; }

        public StackedBarSeriesViewModel()
        {
            StackedBarData1 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Jan", 6),
                new ChartDataModel("Feb", 8),
                new ChartDataModel("Mar", 12),
                new ChartDataModel("Apr", 15.5),
                new ChartDataModel("May", 20),
                new ChartDataModel("Jun", 24),
           };
            StackedBarData2 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Jan", 6),
                new ChartDataModel("Feb", 8),
                new ChartDataModel("Mar", 11),
                new ChartDataModel("Apr", 16),
                new ChartDataModel("May", 21),
                new ChartDataModel("Jun", 25),
            };
            StackedBarData3 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Jan", -1),
                new ChartDataModel("Feb", -1.5),
                new ChartDataModel("Mar", -2),
                new ChartDataModel("Apr", -2.5),
                new ChartDataModel("May", -3),
                new ChartDataModel("Jun", -3.5),
            };
        }
    }
}