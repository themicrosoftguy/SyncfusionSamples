#region Copyright Syncfusion Inc. 2001-2024.
// ------------------------------------------------------------------------------------
// <copyright file = "PagingStyle.cs" company="Syncfusion.com">
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
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Syncfusion.SfDataGrid.XForms;
    using Syncfusion.SfDataGrid.XForms.DataPager;
    using Xamarin.Forms;

    [Xamarin.Forms.Internals.Preserve(AllMembers = true)]

    /// <summary>
    /// Derived from DataGridStyle to add the custom styles
    /// </summary>
    public class PagingStyle : DataGridStyle
    {
        /// <summary>
        /// Initializes a new instance of the PagingStyle class.
        /// </summary>
        public PagingStyle()
        {
        }

        /// <summary>
        /// Overrides this method to write a custom style for header back ground color
        /// </summary>
        /// <returns>Returns From H e x Color</returns>
        public override Color GetHeaderBackgroundColor()
        {
            return Color.FromHex("#e0e0e0");
        }

        /// <summary>
        /// Overrides this method to write a custom style for selection background color
        /// </summary>
        /// <returns>Returns From H e x Color</returns>
        public override Color GetSelectionBackgroundColor()
        {
            return Color.FromHex("#b2d8f7");
        }

        /// <summary>
        /// Overrides this method to write a custom style for selection foreground color
        /// </summary>
        /// <returns>Returns given Color</returns>
        public override Color GetSelectionForegroundColor()
        {
            return Color.Black;
        }

        /// <summary>
        /// Overrides this method to write a custom style for header foreground color
        /// </summary>
        /// <returns>Returns given Color</returns>
        public override Color GetRecordForegroundColor()
        {
            return Color.Black;
        }

        /// <summary>
        /// Overrides this method to write a custom style for record background color
        /// </summary>
        /// <returns>Returns given Color</returns>
        public override Color GetRecordBackgroundColor()
        {
            return Color.White;
        }

        /// <summary>
        /// Overrides this method to write a custom style for border color
        /// </summary>
        /// <returns>Returns given Border Color</returns>
        public override Color GetBorderColor()
        {
            return base.GetBorderColor();
        }
    }
}
