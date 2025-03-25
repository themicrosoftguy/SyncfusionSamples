#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SampleBrowser.SfTabView
{
    public class TabData : INotifyPropertyChanged
    {

        private string category;

        public string Category
        {
            get { return category; }
            set
            {
                category = value;
                RaiseOnPropertyChanged(nameof(Category));
            }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                RaiseOnPropertyChanged(nameof(Description));
            }
        }

        private string imagePath;

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value;
                RaiseOnPropertyChanged(nameof(ImagePath));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;
                RaiseOnPropertyChanged(nameof(Name));
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value;
                RaiseOnPropertyChanged(nameof(Price));
            }
        }

        private string offer;

        public string Offer
        {
            get { return offer; }
            set { offer = value;
                RaiseOnPropertyChanged(nameof(Offer));
            }
        }

        private string rating;

        public string Rating
        {
            get { return rating; }
            set { rating = value;
                RaiseOnPropertyChanged(nameof(Rating));
            }
        }

        /// <inheritdoc />
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// This method is called by the Set accessor of each property.
        /// The CallerMemberName attribute that is applied to the optional propertyName
        /// parameter causes the property name of the caller to be substituted as an argument.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
