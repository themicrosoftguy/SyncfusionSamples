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
using Syncfusion.SfRangeSlider.iOS;

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
	public class CalendarConfiguration_Mobile : SampleView
	{
		private SFCalendar calendar;
		private string selectedType;
		private UILabel labelCalendarView;
		private UIButton buttonCalendarView = new UIButton();
		private UIButton doneButton = new UIButton();
		private UIPickerView pickerCalendarView;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CalendarConfiguration_Mobile()
		{
			//Calendar
			calendar = new SFCalendar();
			calendar.ViewMode = SFCalendarViewMode.SFCalendarViewModeMonth;
		    
            //calendar.
			NSMutableArray<NSString> customLabel = new NSMutableArray<NSString>();
			customLabel.Add((NSString)"SUN");
			customLabel.Add((NSString)"MON");
			customLabel.Add((NSString)"TUE");
			customLabel.Add((NSString)"WED");
			customLabel.Add((NSString)"THU");
			customLabel.Add((NSString)"FRI");
			customLabel.Add((NSString)"SAT");
			calendar.CustomDayLabels = customLabel;
			calendar.HeaderHeight = 40;
		
            //MonthViewSettings
			SFMonthViewSettings monthSettings = new SFMonthViewSettings();
			monthSettings.WeekDayFontAttribute = UIFont.FromName("Menlo-Italic", 16f);
			monthSettings.FontAttribute = UIFont.FromName("Menlo-Regular", 16f);
			monthSettings.HeaderTextColor = UIColor.White;
			monthSettings.HeaderBackgroundColor = UIColor.FromRGB(61, 61, 61);
			monthSettings.DayLabelTextColor = UIColor.White;
			monthSettings.DayLabelBackgroundColor = UIColor.FromRGB(61, 61, 61);
			monthSettings.DateSelectionColor = UIColor.FromRGB(61, 61, 61);
            monthSettings.DateSelectionTextColor = UIColor.White;
			calendar.MonthViewSettings = monthSettings;
			this.OptionView1();
			this.AddSubview(calendar);
		}

        public UIView Option { get; set; } = new UIView();

        public override void LayoutSubviews()
		{
			foreach (var view in this.Subviews)
            {
				view.Frame = Bounds;
				this.OptionView.Frame = view.Frame;
                if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
                {
                    var height = this.Frame.Height;
                    pickerCalendarView.Frame = new CGRect(0, 160, 300, 70);
                    doneButton.Frame = new CGRect(0, 100, 300, 40);

                    labelCalendarView.Frame = new CGRect(10, 20, this.Frame.Size.Width - 20, 30);

                    buttonCalendarView.Frame = new CGRect(10, 80, 300, 30);
                }
                else
                {
                    Option.Frame = new CGRect(0, 90, Frame.Width, Frame.Height);
                    labelCalendarView.Frame = new CGRect(this.Frame.X + 10, this.Frame.Y - 20, this.Frame.Size.Width - 20, 30);
                    buttonCalendarView.Frame = new CGRect(this.Frame.X + 10, this.Frame.Y + 20, this.Frame.Size.Width - 20, 30);
                    pickerCalendarView.Frame = new CGRect(this.Frame.X, this.Frame.Size.Height / 4, this.Frame.Size.Width, this.Frame.Size.Height / 3);
                    doneButton.Frame = new CGRect(0, this.Frame.Size.Height / 4, this.Frame.Size.Width, 40);
                }
			}

			base.LayoutSubviews();
		}

		private readonly IList<string> calendarViewsCollection = new List<string>
		{
			"Single Selection",
			"Multi Selection"
		};

		public void OptionView1()
		{
            //Intializing configurationc controls
            pickerCalendarView = new UIPickerView();
            labelCalendarView = new UILabel();
            buttonCalendarView = new UIButton();
			this.OptionView = new UIView();

            //CalendarView
			PickerModel model = new PickerModel(calendarViewsCollection);
            pickerCalendarView.Model = model;
            labelCalendarView.Text = "SELECTION MODE: ";
            labelCalendarView.TextColor = UIColor.Black;
            labelCalendarView.TextAlignment = UITextAlignment.Left;

            buttonCalendarView.SetTitle("Single Selection", UIControlState.Normal);
            buttonCalendarView.SetTitleColor(UIColor.Black, UIControlState.Normal);
            buttonCalendarView.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
            buttonCalendarView.Layer.CornerRadius = 8;
            buttonCalendarView.Layer.BorderWidth = 2;
            buttonCalendarView.TouchUpInside += ShowPicker1;
            buttonCalendarView.Layer.BorderColor = UIColor.FromRGB(246, 246, 246).CGColor;

			doneButton.SetTitle("Done\t", UIControlState.Normal);
			doneButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			doneButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;
			doneButton.TouchUpInside += HidePicker;
			doneButton.Hidden = true;
			doneButton.BackgroundColor = UIColor.FromRGB(246, 246, 246);

			model.PickerChanged += SelectedIndexChanged1;
            pickerCalendarView.ShowSelectionIndicator = true;
            pickerCalendarView.Hidden = true;
			
            //picker_calendarView.BackgroundColor = UIColor.Gray;

			//adding subviews to the option view
			this.Option.AddSubview(labelCalendarView);
			this.Option.AddSubview(buttonCalendarView);

			this.Option.AddSubview(pickerCalendarView);
			this.Option.AddSubview(doneButton);
		}

		private void ShowPicker1(object sender, EventArgs e)
        {
			doneButton.Hidden = false;
            pickerCalendarView.Hidden = false;
            buttonCalendarView.Hidden = true;
            labelCalendarView.Hidden = true;
		}

		private void HidePicker(object sender, EventArgs e)
        {
			doneButton.Hidden = true;
            pickerCalendarView.Hidden = true;
            buttonCalendarView.Hidden = false;
            labelCalendarView.Hidden = false;
		}

		private void SelectedIndexChanged1(object sender, PickerChangedEventArgs e)
		{
			this.selectedType = e.SelectedValue;
			if (selectedType == "Single Selection")
            {
				calendar.SelectionMode = SFCalenderSelectionMode.SFCalenderSelectionModeSingle;
			}
            else if (selectedType == "Multi Selection")
            {
				calendar.SelectionMode = SFCalenderSelectionMode.SFCalenderSelectionModeMultiple;
			}
            else if (selectedType == "Range Selection")
            {
				calendar.SelectionMode = SFCalenderSelectionMode.SFCalenderSelectionModeRange;
			}

            buttonCalendarView.SetTitle(selectedType.ToString(), UIControlState.Normal);
		}		
	}
}