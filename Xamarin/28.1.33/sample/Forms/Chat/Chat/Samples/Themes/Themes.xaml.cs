#region Copyright Syncfusion Inc. 2001-2024.
// ------------------------------------------------------------------------------------
// <copyright file = "GridGettingStarted.xaml.cs" company="Syncfusion.com">
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.// </copyright>
// ------------------------------------------------------------------------------------
#endregion

namespace SampleBrowser.SfChat
{
    using SampleBrowser.Core;

    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]

    /// <summary>
    /// A sampleView that contains the GettingStarted sample.
    /// </summary>
    public partial class Themes : SampleView
    {
        public Themes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Raises when <see cref="Themes"/> page disappears.
        /// </summary>
        public override void OnDisappearing()
        {
            base.OnDisappearing();
            this.viewModel.IsDisposed = true;
            this.viewModel.AuthorsCollection.Clear();
            this.viewModel.Messages.Clear();
            this.viewModel.AuthorMessageDataBase.Clear();
            if (this.sfChat != null)
            {
                this.sfChat.Dispose();
                this.sfChat = null;
            }
        }
    }
}