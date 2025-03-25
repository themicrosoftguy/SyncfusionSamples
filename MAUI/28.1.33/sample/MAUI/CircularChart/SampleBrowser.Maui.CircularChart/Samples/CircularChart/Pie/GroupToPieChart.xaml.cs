#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Charts;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SampleBrowser.Maui.CircularChart.SfCircularChart
{
    public partial class GroupToPieChart : SampleView
    {
        public GroupToPieChart()
        {
            InitializeComponent();
            groupTo.SelectedIndex = 0;
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            pieSeries1.EnableTooltip = !IsCardView;
            hyperLinkLayout.IsVisible = !IsCardView;
#if IOS || ANDROID
            if (!IsCardView)
            {
                pieSeries1.Radius = 1;
                pieSeries1.DataLabelSettings.LabelPlacement = DataLabelPlacement.Inner;
            }
#endif


#if IOS
            if (IsCardView)
            {
                Chart.WidthRequest = 350;
                Chart.HeightRequest = 400;
                Chart.VerticalOptions = LayoutOptions.Start;
            }
#endif
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            Chart.Handler?.DisconnectHandler();
        }

        private void groupTo_SelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
        {
            var index = groupTo.SelectedIndex;
            if (index != -1)
            {
                switch (index)
                {
                    case 0:
                        {
                            pieSeries1.GroupTo = 3;
                            pieSeries1.YBindingPath = "Value";
                            pieSeries1.GroupMode = PieGroupMode.Value;
                            label.LabelFormat = "$#.##'T";
                            break;
                        }
                    case 1:
                        {
                            pieSeries1.YBindingPath = "Size";
                            pieSeries1.GroupTo = 10;
                            pieSeries1.GroupMode = PieGroupMode.Percentage;
                            label.LabelFormat = "P0";
                            break;
                        }
                    case 2:
                        {
                            pieSeries1.GroupTo = 90;
                            pieSeries1.YBindingPath = "Value";
                            pieSeries1.GroupMode = PieGroupMode.Angle;
                            label.LabelFormat = "$#.##'T";
                            break;
                        }
                }
            }
        }
    }

    public class ItemsSourceConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var data = value as List<object>;
                if (data != null && data.Count > 5)
                {
                    var data_list = data.Where(x => data.IndexOf(x) < 6).ToList();

                    string name = "Others";
                    double yvalue = data.Where(x => data.IndexOf(x) >= 6).Sum(x => (x is ChartDataModel model) ? model.Value : 0);
                    double size = data.Where(x => data.IndexOf(x) >= 6).Sum(x => (x is ChartDataModel model) ? model.Size : 0);
                    data_list.Add(new ChartDataModel(name, yvalue, size));

                    return data_list;
                }
                else if (data != null)
                    return data;
                else
                {
                    return new List<object>() { value };
                }
            }
            
            return new List<object>();
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class StringFormatConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value != null && value is ChartDataModel model)
            {
                if(parameter is PieSeries series)
                {
                    switch (series.GroupMode)
                    {
                        case PieGroupMode.Percentage:
                            return string.Format("{0:P0}", model.Size);
                        default:
                            return string.Format("${0:F2} T", model.Value);
                    }
                }
            }

            return "";
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value;
        }
    }

}