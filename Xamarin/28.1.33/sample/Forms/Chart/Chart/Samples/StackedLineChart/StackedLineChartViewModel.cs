#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SampleBrowser.SfChart
{
    public class StackedLineChartViewModel
    {
        public ObservableCollection<ChartDataModel> StackedLineData1 { get; set; }

        public ObservableCollection<ChartDataModel> StackedLineData2 { get; set; }

        public ObservableCollection<ChartDataModel> StackedLineData3 { get; set; }

        public ObservableCollection<ChartDataModel> StackedLineData4 { get; set; }

        public StackedLineChartViewModel()
        {
            StackedLineData1 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Food", 55),
                new ChartDataModel("Transport", 33),
                new ChartDataModel("Medical", 43),
                new ChartDataModel("Clothes", 32),
                new ChartDataModel("Books", 56),
                new ChartDataModel("Others", 23)
            };
            StackedLineData2 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Food", 40),
                new ChartDataModel("Transport", 45),
                new ChartDataModel("Medical", 23),
                new ChartDataModel("Clothes", 54),
                new ChartDataModel("Books", 18),
                new ChartDataModel("Others", 54)
            };
            StackedLineData3 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Food", 45),
                new ChartDataModel("Transport", 54),
                new ChartDataModel("Medical", 20),
                new ChartDataModel("Clothes", 23),
                new ChartDataModel("Books", 43),
                new ChartDataModel("Others", 33)
            };
            StackedLineData4 = new ObservableCollection<ChartDataModel>
            {
                new ChartDataModel("Food", 48),
                new ChartDataModel("Transport", 28),
                new ChartDataModel("Medical", 34),
                new ChartDataModel("Clothes", 54),
                new ChartDataModel("Books", 55),
                new ChartDataModel("Others", 56)
            };
        }
    }
}
