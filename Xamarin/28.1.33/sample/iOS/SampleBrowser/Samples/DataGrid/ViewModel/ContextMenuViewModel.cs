#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace SampleBrowser
{
    public class ContextMenuViewModel
    {
        public ContextMenuViewModel()
        {
            ProductRepository product = new ProductRepository();
            products = product.GetProductDetails(100);
        }
        #region ItemsSource

        private ObservableCollection<Products> products;
        public ObservableCollection<Products> Products
        {
            get { return products; }
            set { this.products = value; }
        }
        #endregion
    }
}
