#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using Syncfusion.SfCalendar.iOS;

#if __UNIFIED__
using Foundation;
using UIKit;
using CoreGraphics;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using CGRect = System.Drawing.RectangleF;
using CGPoint = System.Drawing.PointF;
using CGSize = System.Drawing.SizeF;
using nfloat = System.Single;
using System.Drawing;
#endif

namespace SampleBrowser
{
	public class CalendarLocalization : SampleView
	{
		private CalendarLocalization_Mobile phoneView;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CalendarLocalization()
        {
            phoneView = new CalendarLocalization_Mobile();
            this.AddSubview(phoneView);
            this.OptionView = phoneView.Option;
        }

		public override void LayoutSubviews()
		{
			foreach (var view in this.Subviews)
            {
				view.Frame = Bounds;
			}
		}
	}
}