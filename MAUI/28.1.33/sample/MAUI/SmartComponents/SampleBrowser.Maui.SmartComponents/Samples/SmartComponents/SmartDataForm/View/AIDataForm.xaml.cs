#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace SampleBrowser.Maui.SmartComponents.SmartComponents
{
    using SampleBrowser.Maui.Base;

    public partial class AIDataForm : SampleView
    {
        public AIDataForm()
        {
            InitializeComponent();
#if ANDROID || IOS
            this.Content = new DataFormMobileUI();
#else
            this.Content = new DataFormDesktopUI();
#endif
        }
    }
}
