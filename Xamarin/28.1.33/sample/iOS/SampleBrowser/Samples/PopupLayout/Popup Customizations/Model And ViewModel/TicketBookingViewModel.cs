#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;

namespace SampleBrowser
{
	public class TicketBookingViewModel
	{
		public TicketBookingViewModel()
		{
			TicketInfoRepository details = new TicketInfoRepository();
			theaterInformation = details.GetDetails();
		}

		#region ItemsSource

		private ObservableCollection<TicketBookingInfo> theaterInformation;

		public ObservableCollection<TicketBookingInfo> TheaterInformation
		{
			get { return this.theaterInformation; }
			set { this.theaterInformation = value; }
		}

		#endregion

	}
}
