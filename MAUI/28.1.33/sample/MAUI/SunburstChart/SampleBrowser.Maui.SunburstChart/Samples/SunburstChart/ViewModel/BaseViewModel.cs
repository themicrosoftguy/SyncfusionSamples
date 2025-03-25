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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleBrowser.Maui.SunburstChart.SfSunburstChart
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;  

        public ObservableCollection<Brush> CustomBrush1 { get; set; }
        public ObservableCollection<Brush> CustomBrush2 { get; set; }
        public ObservableCollection<Brush> CustomBrush3 { get; set; }

        private bool enableAnimation = true;
        public bool EnableAnimation
        {
            get { return enableAnimation; }
            set
            {
                enableAnimation = value;
                OnPropertyChanged("EnableAnimation");
            }
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public BaseViewModel()
        {
            CustomBrush1 = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#2A9AF3")),
               new SolidColorBrush(Color.FromArgb("#0DC920")),
               new SolidColorBrush(Color.FromArgb("#F5921F")),
               new SolidColorBrush(Color.FromArgb("#E64191")),
               new SolidColorBrush(Color.FromArgb("#2EC4B6")),
            };

            CustomBrush2 = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#1089E9")),
               new SolidColorBrush(Color.FromArgb("#08CDAA")),
               new SolidColorBrush(Color.FromArgb("#F954A3")),
               new SolidColorBrush(Color.FromArgb("#F9C200")),
               new SolidColorBrush(Color.FromArgb("#9656FF")),
            };

            CustomBrush3 = new ObservableCollection<Brush>()
            {
               new SolidColorBrush(Color.FromArgb("#D41089E9")),
               new SolidColorBrush(Color.FromArgb("#D408CDAA")),
               new SolidColorBrush(Color.FromArgb("#D49656FF")),
               new SolidColorBrush(Color.FromArgb("#D4CDB509")),
               new SolidColorBrush(Color.FromArgb("#D4F954A3")),
            };
        }
    }

    public class ChartColorModel : ObservableCollection<Brush>
    {

    }
}