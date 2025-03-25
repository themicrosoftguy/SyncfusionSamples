#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfTabView.Model
{
	[Preserve(AllMembers = true)]
	public class ContactsInfo : INotifyPropertyChanged
	{
		#region Fields

		private string contactName;
		private string contactNo;
		private string image;
		private string contactType;
		private DateTime messagingtime;
		#endregion

		#region Constructor

		public ContactsInfo()
		{

		}

		#endregion

		#region Public Properties

		public string ContactName
		{
			get { return this.contactName; }
			set
			{
				this.contactName = value;
				RaisePropertyChanged("ContactName");
			}
		}

		public string ContactNumber
		{
			get { return contactNo; }
			set
			{
				this.contactNo = value;
				RaisePropertyChanged("ContactNumber");
			}
		}

		public string ContactReadType
		{
			get { return contactType; }
			set
			{
				this.contactType = value;
				RaisePropertyChanged("ContactReadType");
			}
		}

		public string ContactImage
		{
			get { return this.image; }
			set
			{
				this.image = value;
				this.RaisePropertyChanged("ContactImage");
			}
		}

		public DateTime MessagingTime
        {
			get { return this.messagingtime; }
            set
            {
				this.messagingtime = value;
				this.RaisePropertyChanged("MessagingTime");
            }
        }

		public string Message { get; set; }

		#endregion

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		private void RaisePropertyChanged(String name)
		{
			if (PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(name));
		}

		#endregion
	}
}
