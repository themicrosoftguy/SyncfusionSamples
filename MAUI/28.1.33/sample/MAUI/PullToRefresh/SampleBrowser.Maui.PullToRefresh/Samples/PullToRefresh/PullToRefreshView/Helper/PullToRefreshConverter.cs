#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBrowser.Maui.PullToRefresh
{
    /// <summary>
    /// Converter class helps to convert DateTime to string format.
    /// </summary>
    public class DateToStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value == null) return "";

            var date = (DateTime)value;
            if (parameter == null)
            {
                return "1:23 PM, " + date.ToString("d MMMM yyyy");
            }
            else
            {
                return date.Date.CompareTo(DateTime.Today) == 0 ? "Today" : date.ToString("ddd d");
            }

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
