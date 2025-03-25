#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Android.Util;
using System;
using Android.Views;
using Android.Content;

namespace SampleBrowser
{
    public class CalendarGettingStarted : SamplePage, IDisposable
    {
        private CalendarGettingStarted_Mobile mobile;
        private CalendarGettingStarted_Tab tab;
        private Context contextTablet;

        public CalendarGettingStarted()
        {
        }

        public override View GetSampleContent(Android.Content.Context con)
        {
            if (IsTabletDevice(con))
            {
                tab = new CalendarGettingStarted_Tab();
                contextTablet = con;
                return tab.GetSampleContent(con);
            }
            else
            {
                mobile = new CalendarGettingStarted_Mobile();
                return mobile.GetSampleContent(con);
            }
        }

        public override View GetPropertyWindowLayout(Android.Content.Context context)
        {
            if (IsTabletDevice(context))
            {
                return tab.GetPropertyWindowLayout(context);
            }
            else
            {
                return mobile.GetPropertyWindowLayout(context);
            }
        }

        public override void OnApplyChanges()
        {
            base.OnApplyChanges();

            if (!IsTabletDevice(contextTablet))
            {
                mobile.OnApplyChanges();
            }
        }

        public static bool IsTabletDevice(Android.Content.Context context)
        {
            try
            {
                DisplayMetrics displayMetrics = context.Resources.DisplayMetrics;
                float screenWidth = displayMetrics.WidthPixels / displayMetrics.Xdpi;
                float screenHeight = displayMetrics.HeightPixels / displayMetrics.Ydpi;
                double size = Java.Lang.Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2));
                return size >= 6;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            if (mobile != null)
            {
                mobile.Dispose();
                mobile = null;
            }

            if (tab != null)
            {
                tab.Dispose();
                tab = null;
            }
        }
    }
}