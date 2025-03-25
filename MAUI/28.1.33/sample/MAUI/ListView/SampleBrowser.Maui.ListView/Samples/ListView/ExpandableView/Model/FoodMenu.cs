#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace SampleBrowser.Maui.ListView.SfListView
{
    public class FoodMenu : INotifyPropertyChanged
    {
        #region Field        
        
        private string foodName;
        private bool isSelected;

        #endregion

        #region Properties

        public string FoodName
        {
            get
            {
                return foodName;
            }
            set
            {
                foodName = value;
                RaisedOnPropertyChanged("FoodName");
            }
        }

        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                RaisedOnPropertyChanged("IsSelected");
            }
        }
        
        #endregion

        public FoodMenu()
        {
        }

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion

    }
}
