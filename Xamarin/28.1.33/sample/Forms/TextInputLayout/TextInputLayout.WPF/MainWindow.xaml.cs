#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.XForms.WPF.TextInputLayout;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace SampleBrowser.SfTextInputLayout.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();

            Core.WPF.CoreSampleBrowser.Init();

            SfTextInputLayoutRenderer.Init();

            Syncfusion.ListView.XForms.WPF.SfListViewRenderer.Init();

            LoadApplication(new SfTextInputLayout.App());
        }
    }
}
