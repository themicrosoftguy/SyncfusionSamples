#region Copyright Syncfusion Inc. 2001-2024.
// ------------------------------------------------------------------------------------
// <copyright file = "Blue.cs" company="Syncfusion.com">
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.
// </copyright>
// ------------------------------------------------------------------------------------
#endregion

namespace SampleBrowser.SfDataGrid
{
    using System;
    using Syncfusion.SfDataGrid;
    using Syncfusion.SfDataGrid.XForms;
    using Xamarin.Forms;

    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]

    /// <summary>
    /// Derived from DataGridStyle to add the custom styles
    /// </summary>
    public class Blue : DataGridStyle
    {
        /// <summary>
        /// Initializes a new instance of the Blue class.
        /// </summary>
        public Blue()
        {
        }

        /// <summary>
        /// Overrides this method to write a custom style for header back ground color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetHeaderBackgroundColor()
        {
            return Color.FromRgb(89, 140, 181);
        }

        /// <summary>
        /// Overrides this method to write a custom style for header foreground color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetHeaderForegroundColor()
        {
            return Color.FromRgb(255, 255, 255);
        }

        /// <summary>
        /// Overrides this method to write a custom style for selection background color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetSelectionBackgroundColor()
        {
            return Color.FromRgb(100, 181, 246);
        }

        /// <summary>
        /// Overrides this method to write a custom style for selection foreground color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetSelectionForegroundColor()
        {
            return Color.FromRgb(255, 255, 255);
        }

        /// <summary>
        /// Overrides this method to write a custom style for caption summary row background color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetCaptionSummaryRowBackgroundColor()
        {
            return Color.FromRgb(224, 224, 224);
        }

        /// <summary>
        /// Overrides this method to write a custom style for caption summary row background color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetCaptionSummaryRowForegroundColor()
        {
            return Color.FromRgb(51, 51, 51);
        }

        /// <summary>
        /// Overrides this method to write a custom style for caption summary row background color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetBorderColor()
        {
            return Color.FromRgb(180, 180, 180);
        }

        /// <summary>
        /// Overrides this method to write a custom style for Alternating row background color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.FromRgb(227, 242, 253);
        }

        /// <summary>
        /// Overrides this method to write a custom style for get record foreground color
        /// </summary>
        /// <returns>Returns From R g b Color</returns>
        public override Color GetRecordForegroundColor()
        {
            return Color.FromRgb(0, 0, 0);
        }

        /// <summary>
        /// Overrides this method to write a Grid line visibility
        /// </summary>
        /// <returns>Returns GridLinesVisibility Horizontal</returns>
        public override GridLinesVisibility GetGridLinesVisibility()
        {
            return GridLinesVisibility.Horizontal;
        }
    }
}