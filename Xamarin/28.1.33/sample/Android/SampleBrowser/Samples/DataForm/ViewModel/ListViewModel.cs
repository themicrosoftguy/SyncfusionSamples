#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.ObjectModel;

namespace SampleBrowser
{
    public class ListViewGroupingViewModel
    {
        #region Fields

        private ObservableCollection<ContactsInfo> contactsInfo;

        #endregion

        #region Constructor

        public ListViewGroupingViewModel()
        {
            GenerateSource(100);
        }

        #endregion

        #region Properties

        public ObservableCollection<ContactsInfo> ContactsInfo
        {
            get { return contactsInfo; }
            set { this.contactsInfo = value; }
        }

        #endregion

        #region ItemSource

        public void GenerateSource(int count)
        {
            ContactsInfoRepository contactRepository = new ContactsInfoRepository();
            contactsInfo = contactRepository.GetContactDetails(count);
        }

        #endregion }
    }
}