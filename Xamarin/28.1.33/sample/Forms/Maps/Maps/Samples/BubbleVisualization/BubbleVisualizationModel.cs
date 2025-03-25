#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfMaps
{
   [Preserve(AllMembers = true)]
    public class BubbleVisualizationModel
    {
        public BubbleVisualizationModel(string country, double population, double percent)
        {
            Country = country;
            Population = population;
            Percent = percent;
        }

       
        public string Country
        {
            get;
            set;
        }

        public double Population
        {
            get;
            set;
        }

        public double Percent
        {
            get;
            set;
        }
    }
}
