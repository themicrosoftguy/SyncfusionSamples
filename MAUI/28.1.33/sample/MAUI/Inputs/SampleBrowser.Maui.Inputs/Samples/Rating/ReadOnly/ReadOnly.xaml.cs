#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Maui.Controls;
using SampleBrowser.Maui.Base;
using Syncfusion.Maui.ProgressBar;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleBrowser.Maui.Inputs.SfRating
{

    public partial class ReadOnly : SampleView
    {
        public ReadOnly()
        {
            InitializeComponent();

#if ANDROID || IOS
            this.Content = new ReadOnlyMobile();
#else
            this.Content = new ReadOnlyDesktop();
#endif
        }
    }
}



