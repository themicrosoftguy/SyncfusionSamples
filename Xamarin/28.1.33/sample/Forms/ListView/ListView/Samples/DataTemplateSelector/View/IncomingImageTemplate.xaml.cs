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
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace SampleBrowser.SfListView
{
    [Preserve(AllMembers = true)]
    public partial class IncomingImageMessageTemplate : ViewCell
    {
		#region IncomingImageTemplate
		public IncomingImageMessageTemplate()
		{
			InitializeComponent();
            if (Device.RuntimePlatform == Device.UWP)
                this.gridLayout.ColumnSpacing = -23;
            else
                this.frame.BackgroundColor = Color.FromRgb(192, 238, 252);
		}

        #endregion
    }
}