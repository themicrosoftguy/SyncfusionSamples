#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using SampleBrowser.Core;
using System.Collections.ObjectModel;

namespace SampleBrowser.SfTabView
{
    internal class TabDataViewModel
    {
        internal ObservableCollection<TabData> Data = new ObservableCollection<TabData>();
        internal ObservableCollection<string> Categories = new ObservableCollection<string>();
        private ObservableCollection<string> NamesCollection = new ObservableCollection<string>();
        private ObservableCollection<double> PriceCollection = new ObservableCollection<double>();
        private ObservableCollection<string> OffersCollection = new ObservableCollection<string>();
        private ObservableCollection<string> RatingCollection = new ObservableCollection<string>();
        private ObservableCollection<string> ImageCollection = new ObservableCollection<string>();
        private ObservableCollection<string> DescriptionCollection = new ObservableCollection<string>();
        private int index = 0;

        public TabDataViewModel()
        {
            this.SetTabViewDataValuess();
            this.AddTabData();
        }

        private void SetTabViewDataValuess()
        {
            this.SetCategories();
            this.SetNames();
            this.SetPrices();
            this.SetOffers();
            this.SetRatings();
            this.SetImages();
            this.SetDescription();
        }


        private void AddTabData()
        {
            index = 0;
            foreach (var category in Categories)
            {
                for (int j = 0; j < 5; j++)
                {
                    Data.Add(new TabData
                    {
                        Category = category,
                        Name = NamesCollection[index],
                        Price = PriceCollection[index],
                        Rating = RatingCollection[index],
                        Offer = OffersCollection[index],
                        ImagePath = ImageCollection[index],
                        Description = DescriptionCollection[index]
                    });
                    index++;
                }
            }
        }

        private void SetCategories()
        {
            Categories.Add("Furniture");
            Categories.Add("Clothing");
            Categories.Add("Shoes");
            Categories.Add("Fruits");
            Categories.Add("Toys");
        }

        private void SetNames()
        {
            NamesCollection.Add("Leather Black Sofa");
            NamesCollection.Add("Wooden Standing Drawer");
            NamesCollection.Add("Semi Fabric Sofa");
            NamesCollection.Add("Dinning Chair");
            NamesCollection.Add("Fabric White Sofa");
            NamesCollection.Add("Long Sleeve Cotton Shirt");
            NamesCollection.Add("Denim Jeans");
            NamesCollection.Add("Short Sleeve T-Shirt");
            NamesCollection.Add("Casual Shirt Semi-Fit");
            NamesCollection.Add("Classic Slim Fit Suit");
            NamesCollection.Add("Light weight Shoes");
            NamesCollection.Add("Trendy Grey Shoes");
            NamesCollection.Add("Classic Formal Shoes");
            NamesCollection.Add("White Sporty Shoes");
            NamesCollection.Add("Trendy Brown Shoes");
            NamesCollection.Add("Orange");
            NamesCollection.Add("Blueberries (Imported)");
            NamesCollection.Add("Apple");
            NamesCollection.Add("Strawberry");
            NamesCollection.Add("Banana");
            NamesCollection.Add("Warriors");
            NamesCollection.Add("Robots");
            NamesCollection.Add("Mario collections");
            NamesCollection.Add("Train simulation");
            NamesCollection.Add("Icecream Truck");
        }

        private void SetPrices()
        {
            PriceCollection.Add(99.50);
            PriceCollection.Add(299.40);
            PriceCollection.Add(149.90);
            PriceCollection.Add(129.40);
            PriceCollection.Add(199.50);
            PriceCollection.Add(9.50);
            PriceCollection.Add(7.97);
            PriceCollection.Add(4.55);
            PriceCollection.Add(5.97);
            PriceCollection.Add(18.47);
            PriceCollection.Add(25.11);
            PriceCollection.Add(20.21);
            PriceCollection.Add(11.29);
            PriceCollection.Add(35.75);
            PriceCollection.Add(74.32);
            PriceCollection.Add(59.11);
            PriceCollection.Add(12.44);
            PriceCollection.Add(16.37);
            PriceCollection.Add(29.45);
            PriceCollection.Add(29.97);
            PriceCollection.Add(43.11);
            PriceCollection.Add(2.44);
            PriceCollection.Add(6.37);
            PriceCollection.Add(9.45);
            PriceCollection.Add(9.97);
        }

        private void SetRatings()
        {
            RatingCollection.Add("3.9");
            RatingCollection.Add("4.1");
            RatingCollection.Add("4.4");
            RatingCollection.Add("3.7");
            RatingCollection.Add("4.5");
            RatingCollection.Add("4.7");
            RatingCollection.Add("4.2");
            RatingCollection.Add("3.5");
            RatingCollection.Add("3.9");
            RatingCollection.Add("4.1");
            RatingCollection.Add("4.9");
            RatingCollection.Add("4.1");
            RatingCollection.Add("4.5");
            RatingCollection.Add("4.3");
            RatingCollection.Add("4.1");
            RatingCollection.Add("4.4");
            RatingCollection.Add("3.9");
            RatingCollection.Add("3.7");
            RatingCollection.Add("4.3");
            RatingCollection.Add("4.1");
            RatingCollection.Add("4.5");
            RatingCollection.Add("3.9");
            RatingCollection.Add("4.1");
            RatingCollection.Add("4.9");
            RatingCollection.Add("4.1");
        }

        private void SetDescription()
        {
            DescriptionCollection.Add("Warrenty coverred upto 5 years.Its specialty is its bookcase headboard which serves as an easy access to users.Bring a new member into your family.Delivered in non - assembled pieces.");
            DescriptionCollection.Add("This versatile wardrobe which strikes the perfect balance between style and functionality. Equipped with a mirror and multiple shelves, this wardrobe is all you will need to store your never-ending wardrobe essentials.");
            DescriptionCollection.Add("Engineered wood is created by binding or glueing together at least three thin boards of wood. As a result, your engineered wood furniture will be stable and climate-resistant.");
            DescriptionCollection.Add("Particle boards are a type of engineered wood that are manufactured by binding together small wooden chips, sawdust or wood shavings with synthetic resin. Furniture made of particle boards are lightweight and sturdy.");
            DescriptionCollection.Add("Do not use an overly wet cloth. Wipe your engineered wood furniture clean with a lightly dampened cloth doused either with plain water or a mild cleaning product. Wipe dry with a clean cloth. Avoid exposure to sunlight.");
            DescriptionCollection.Add("Warrenty coverred upto 5 years.Its specialty is its bookcase headboard which serves as an easy access to users.Bring a new member into your family.Delivered in non - assembled pieces.");
            DescriptionCollection.Add("This versatile wardrobe which strikes the perfect balance between style and functionality. Equipped with a mirror and multiple shelves, this wardrobe is all you will need to store your never-ending wardrobe essentials.");
            DescriptionCollection.Add("Engineered wood is created by binding or glueing together at least three thin boards of wood. As a result, your engineered wood furniture will be stable and climate-resistant.");
            DescriptionCollection.Add("Particle boards are a type of engineered wood that are manufactured by binding together small wooden chips, sawdust or wood shavings with synthetic resin. Furniture made of particle boards are lightweight and sturdy.");
            DescriptionCollection.Add("Warrenty coverred upto 5 years. Its specialty is its bookcase headboard which serves as an easy access to users. Bring a new member into your family.Delivered in non-assembled pieces.");
            DescriptionCollection.Add("This versatile wardrobe which strikes the perfect balance between style and functionality. Equipped with a mirror and multiple shelves, this wardrobe is all you will need to store your never-ending wardrobe essentials.");
            DescriptionCollection.Add("Engineered wood is created by binding or glueing together at least three thin boards of wood. As a result, your engineered wood furniture will be stable and climate-resistant.");
            DescriptionCollection.Add("Particle boards are a type of engineered wood that are manufactured by binding together small wooden chips, sawdust or wood shavings with synthetic resin. Furniture made of particle boards are lightweight and sturdy.");
            DescriptionCollection.Add("Do not use an overly wet cloth. Wipe your engineered wood furniture clean with a lightly dampened cloth doused either with plain water or a mild cleaning product. Wipe dry with a clean cloth. Avoid exposure to sunlight.");
            DescriptionCollection.Add("High quality material has been used. Warrenty coverred upto 5 years. Its specialty is its bookcase headboard which serves as an easy access to users. Bring a new member into your family.Delivered in non-assembled pieces.");
            DescriptionCollection.Add("Engineered wood is created by binding or glueing together at least three thin boards of wood. As a result, your engineered wood furniture will be stable and climate-resistant.");
            DescriptionCollection.Add("Particle boards are a type of engineered wood that are manufactured by binding together small wooden chips, sawdust or wood shavings with synthetic resin. Furniture made of particle boards are lightweight and sturdy.");
            DescriptionCollection.Add("Do not use an overly wet cloth. Wipe your engineered wood furniture clean with a lightly dampened cloth doused either with plain water or a mild cleaning product. Wipe dry with a clean cloth. Avoid exposure to sunlight.");
            DescriptionCollection.Add("High quality material has been used. Warrenty coverred upto 5 years. Its specialty is its bookcase headboard which serves as an easy access to users. Bring a new member into your family.Delivered in non-assembled pieces.");
            DescriptionCollection.Add("This versatile wardrobe which strikes the perfect balance between style and functionality. Equipped with a mirror and multiple shelves, this wardrobe is all you will need to store your never-ending wardrobe essentials.");
            DescriptionCollection.Add("Engineered wood is created by binding or glueing together at least three thin boards of wood. As a result, your engineered wood furniture will be stable and climate-resistant.");
            DescriptionCollection.Add("Particle boards are a type of engineered wood that are manufactured by binding together small wooden chips, sawdust or wood shavings with synthetic resin. Furniture made of particle boards are lightweight and sturdy.");
            DescriptionCollection.Add("Do not use an overly wet cloth. Wipe your engineered wood furniture clean with a lightly dampened cloth doused either with plain water or a mild cleaning product. Wipe dry with a clean cloth. Avoid exposure to sunlight.");
            DescriptionCollection.Add("High quality material has been used. Warrenty coverred upto 5 years. Its specialty is its bookcase headboard which serves as an easy access to users. Bring a new member into your family.Delivered in non-assembled pieces.");
            DescriptionCollection.Add("This versatile wardrobe which strikes the perfect balance between style and functionality. Equipped with a mirror and multiple shelves, this wardrobe is all you will need to store your never-ending wardrobe essentials.");
        }

        private void SetOffers()
        {
            OffersCollection.Add("5% Offer");
            OffersCollection.Add("1% Offer");
            OffersCollection.Add("10% Offer");
            OffersCollection.Add("15% Offer");
            OffersCollection.Add("20% Offer");
            OffersCollection.Add("5% Offer");
			OffersCollection.Add("10% Offer");
            OffersCollection.Add("15% Offer");
            OffersCollection.Add("20% Offer");
            OffersCollection.Add("15% Offer");
            OffersCollection.Add("5% Offer");
            OffersCollection.Add("10% Offer");
            OffersCollection.Add("10% Offer");
            OffersCollection.Add("10% Offer");
            OffersCollection.Add("20% Offer");
            OffersCollection.Add("30% Offer");
            OffersCollection.Add("15% Offer");
            OffersCollection.Add("20% Offer");
            OffersCollection.Add("35% Offer");
            OffersCollection.Add("10% Offer");
            OffersCollection.Add("5% Offer");
            OffersCollection.Add("15% Offer");
            OffersCollection.Add("20% Offer");
            OffersCollection.Add("15% Offer");
            OffersCollection.Add("10% Offer");
        }

        private void SetImages()
        {
            ImageCollection.Add("BlackSofa.jpg");
            ImageCollection.Add("TVShelf.jpg");
            ImageCollection.Add("GraySofa.jpg");
            ImageCollection.Add("Chair.jpg");
            ImageCollection.Add("AngleSofa.jpg");
            ImageCollection.Add("Whiteshirt.jpg");
            ImageCollection.Add("Shirt.jpg");
            ImageCollection.Add("Tshirt.jpg");
            ImageCollection.Add("Redcoat.jpg");
            ImageCollection.Add("Silvercoat.jpg");
            ImageCollection.Add("Canvas.jpg");
            ImageCollection.Add("Graycanvas.jpg");
            ImageCollection.Add("Boots.jpg");
            ImageCollection.Add("Blackshoe.jpg");
            ImageCollection.Add("Leather.jpg");
            ImageCollection.Add("Orange.jpg");
            ImageCollection.Add("Blueberry.jpg");
            ImageCollection.Add("Apple.jpg");
            ImageCollection.Add("Strawberry.jpg");
            ImageCollection.Add("Banana.jpg");
            ImageCollection.Add("Friends_Toy.jpg");
            ImageCollection.Add("Robot.jpg");
            ImageCollection.Add("Mario.jpg");
            ImageCollection.Add("Train.jpg");
            ImageCollection.Add("Van.jpg");
        }
    }
}
