#region Copyright Syncfusion Inc. 2001-2024.
// ------------------------------------------------------------------------------------
// <copyright file = "Themes.xaml.cs" company="Syncfusion.com">
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
// </copyright>
// ------------------------------------------------------------------------------------
#endregion
namespace SampleBrowser.SfPopupLayout
{
    using SampleBrowser.Core;   
    using Xamarin.Forms.Internals;
    using Xamarin.Forms.Xaml;

    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]

    /// <summary>
    /// A sampleView that contains the theme sample.
    /// </summary>
    public partial class Themes : SampleView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Themes" /> class
        /// </summary>
        public Themes()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// You can override this method while View was disappear from window
        /// </summary>
        public override void OnDisappearing()
        {
            base.OnDisappearing();

            if (this.popupLayout != null)
            {
                this.popupLayout.Dispose();
                this.popupLayout = null;
            }
        }
    }
}