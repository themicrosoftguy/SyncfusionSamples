#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public class RangeBarSerieViewModel : BaseViewModel
    {
        public ObservableCollection<ChartDataModel> TemperatureData { get; set; }
        public RangeBarSerieViewModel()
        {
            TemperatureData = new ObservableCollection<ChartDataModel>()
        {
                   new ChartDataModel("Jan",7, 3),
                   new ChartDataModel("Feb",8, 3),
                   new ChartDataModel("Mar",12, 5),
                   new ChartDataModel("Apr",16, 7),
                   new ChartDataModel("May",20, 11),
                   new ChartDataModel("Jun",23, 14),
                   new ChartDataModel("Jul",25, 16),
                   new ChartDataModel("Aug",25, 16),
                   new ChartDataModel("Sep",21, 13),
                   new ChartDataModel("Oct",16, 10),
                   new ChartDataModel("Nov",11, 6),
                   new ChartDataModel("Dec",8, 3),
            };
        }
    }
}
