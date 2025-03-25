#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.ObjectModel; 
namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public class WaterFallSeriesViewModel : BaseViewModel
    {
        public ObservableCollection<ChartDataModel> RevenueDetails { get; set; }
        public ObservableCollection<ChartDataModel> Sales { get; set; }
        public ObservableCollection<ChartDataModel> NewSales { get; set; }
        public WaterFallSeriesViewModel()
        {
            this.RevenueDetails = new ObservableCollection<ChartDataModel>();
            this.Sales= new ObservableCollection<ChartDataModel>();
            this.NewSales= new ObservableCollection<ChartDataModel>();
            RevenueDetails.Add(new ChartDataModel() { Department = "Jan", Value = 25 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Feb", Value = 22.5 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Mar", Value = -10 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Apr", Value = 23 });
            RevenueDetails.Add(new ChartDataModel() { Department = "May", Value = 7 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Jun", Value = -15 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Jul", Value = -8 });
            RevenueDetails.Add(new ChartDataModel() { Department = " Aug", Value =-6  });
            RevenueDetails.Add(new ChartDataModel() { Department = "Sep", Value = -9 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Oct", Value = 22.5 });
            RevenueDetails.Add(new ChartDataModel() { Department = "Nov", Value = 12});
            RevenueDetails.Add(new ChartDataModel() { Department = " Dec", Value = -30 });
            RevenueDetails.Add(new ChartDataModel() { Department = " Total", Value = 34, IsSummary = true });
           
            Sales.Add(new ChartDataModel() { Department = "Income", Value = 46 });
            Sales.Add(new ChartDataModel() { Department = "Sales", Value = -14 });
            Sales.Add(new ChartDataModel() { Department = "Research", Value = -9});
            Sales.Add(new ChartDataModel() { Department = "Other Income", Value = 15 });
            Sales.Add(new ChartDataModel() { Department = "Gross Profit", Value = 38 , IsSummary= true });
            Sales.Add(new ChartDataModel() { Department = "Expense", Value = -13 });
            Sales.Add(new ChartDataModel() { Department = "Tax", Value = -8 });
            Sales.Add(new ChartDataModel() { Department = "Net Profit", Value =17,IsSummary=true });

            NewSales.Add(new ChartDataModel() { Department = "Income", Value = 47 });
            NewSales.Add(new ChartDataModel() { Department = "Sales", Value = -15 });
            NewSales.Add(new ChartDataModel() { Department = "Research", Value = -8 });
            NewSales.Add(new ChartDataModel() { Department = "Other Income", Value = 18 });
            NewSales.Add(new ChartDataModel() { Department = "Gross Profit", Value = 34, IsSummary = true });
            NewSales.Add(new ChartDataModel() { Department = "Expense", Value = -12 });
            NewSales.Add(new ChartDataModel() { Department = "Tax", Value = -6 });
            NewSales.Add(new ChartDataModel() { Department = "Net Profit", Value = 11, IsSummary = true });
        }
    }
}
