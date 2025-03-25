#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using CoreGraphics;
using UIKit;

namespace SampleBrowser
{
	public class OptionViewController : UIViewController
	{
        #region ctor

        public OptionViewController()
		{
		}

        #endregion

        #region properties

        public UIView OptionView { get; set; }

        #endregion

        public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.Title = "Options";
			this.View.BackgroundColor = UIColor.White;
			OptionView.Frame = new CGRect(0, 0, 320, 400);
			this.View.AddSubview(OptionView);
		}
	}
}
