#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XForms.Buttons;

namespace SampleBrowser.SfSwitch
{
    public class TokensViewModel
    {
        private ObservableCollection<SfSegmentItem> tokenCollections;

        public ObservableCollection<SfSegmentItem> TokenCollections
        {
            get { return tokenCollections; }
            set { tokenCollections = value; }
        }

        public TokensViewModel()
        {
            TokenCollections = new ObservableCollection<SfSegmentItem>
            {
                new SfSegmentItem {Text = "AudioBooks"},
                new SfSegmentItem {Text = "eBooks"},
                new SfSegmentItem {Text = "Comics"},
                new SfSegmentItem {Text = "Genres"},
                new SfSegmentItem {Text = "Top Sellings"}
            };
        }
    }
}
