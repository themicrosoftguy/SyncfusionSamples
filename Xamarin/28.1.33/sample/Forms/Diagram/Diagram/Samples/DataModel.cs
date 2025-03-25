#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SampleBrowser
{
    public class DataModel
    {
        //Initialize Employee Class
        internal ObservableCollection<DiagramEmployee> employee = new ObservableCollection<DiagramEmployee>();

        //Get Employee Details
        internal void Data()
        {
            if (Device.RuntimePlatform == Device.Android || Device.RuntimePlatform == Device.iOS)
            {
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2014",
                    Name = "Maria Anders",
                    Designation = "Managing Director",
                    ImageUrl = "People_Circle1.png",
                    EmailId = "maria.andres@northwind.com",
                    HasChild = true,
                });
                //hierarchy 1
                employee.Add(new DiagramEmployee()
                {
                    ID = "84937",
                    DOJ = "18/10/2011",
                    Name = "Ana Trujillo",
                    Designation = "Senior Manager",
                    ImageUrl = "People_Circle2.png",
                    EmailId = "anatrujillo@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Maria Anders"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2010",
                    Name = "Lino Rodri",
                    Designation = "Senior Manager",
                    ImageUrl = "People_Circle3.png",
                    EmailId = "lino.rodri@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Maria Anders"
                });
                //hierarchy 2
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2014",
                    Name = "Philip Cramer",
                    Designation = "Project Manager",
                    ImageUrl = "People_Circle4.png",
                    EmailId = "philip.cramer@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Ana Trujillo"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "03947",
                    DOJ = "18/10/2013",
                    Name = "Anto Moreno",
                    Designation = "Project Manager",
                    ImageUrl = "People_Circle5.png",
                    EmailId = "antomoreno@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Lino Rodri"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2013",
                    Name = "Victoria Ash",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle6.png",
                    EmailId = "victoria@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Daniel Tonini"
                });

                employee.Add(new DiagramEmployee()
                {
                    ID = "10101",
                    DOJ = "01/03/2015",
                    Name = "Eduardo Roel",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle7.png",
                    EmailId = "eduardoroel@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Felipe Kloss"
                });
                //hierarchy 3
                employee.Add(new DiagramEmployee()
                {
                    ID = "19287",
                    DOJ = "18/10/2011",
                    Name = "Clayton Hardy",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle8.png",
                    EmailId = "Clayton.hardy@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Philip Cramer"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2015",
                    Name = "Christina kaff",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle9.png",
                    EmailId = "christinakaff@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Philip Cramer"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2012",
                    Name = "Hanna Moos",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle10.png",
                    EmailId = "hanna.moos@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Anto Moreno"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2015",
                    Name = "Peter Citeaux",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle11.png",
                    EmailId = "peterciteaux@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Anto Moreno"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2017",
                    Name = "Martín Kloss",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle12.png",
                    EmailId = "martin.kloss@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Victoria Ash"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2012",
                    Name = "Elizabeth Mary",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle13.png",
                    EmailId = "elizabeth.mary@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Victoria Ash"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2016",
                    Name = "Francisco Yang",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle14.png",
                    EmailId = "franscisco@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Eduardo Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "18/10/2011",
                    Name = "Yang Wang",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle15.png",
                    EmailId = "yangwang@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Eduardo Roel"
                });

                //Hierarchy 4
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "15/10/2015",
                    Name = "Pedro Afonso",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle16.png",
                    EmailId = "pedro.afonso@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Clayton Hardy"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "15/10/2011",
                    Name = "Elizabeth Roel",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle17.png",
                    EmailId = "elizabeth.roel@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Clayton Hardy"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "59305",
                    DOJ = "15/10/2013",
                    Name = "Janine Labrune",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle18.png",
                    EmailId = "janine.labrune@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Christina kaff"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "95836",
                    DOJ = "15/10/2012",
                    Name = "Ann Devon",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle19.png",
                    EmailId = "ann.devon@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Christina kaff"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "03993",
                    DOJ = "15/10/2012",
                    Name = "Roland Mendel",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle20.png",
                    EmailId = "rolandmendel@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Hanna Moos"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "01992",
                    DOJ = "15/10/2015",
                    Name = "Aria Cruz",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle21.png",
                    EmailId = "ariacruz@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Hanna Moos"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "95837",
                    DOJ = "15/10/2016",
                    Name = "Martine Rancé",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle22.png",
                    EmailId = "martinerance@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Peter Citeaux"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "93711",
                    DOJ = "15/10/2015",
                    Name = "Maria Larsson",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle23.png",
                    EmailId = "marialarsson@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Peter Citeaux"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "04992",
                    DOJ = "15/03/2015",
                    Name = "Diego Roel",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle24.png",
                    EmailId = "diegoroel@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Martín Kloss"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "83735",
                    DOJ = "15/03/2012",
                    Name = "Peter Franken",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle25.png",
                    EmailId = "peter.franken@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Martín Kloss"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "81777",
                    DOJ = "01/03/2011",
                    Name = "Carine Schmitt",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle26.png",
                    EmailId = "carineschmitt@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Elizabeth Mary"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "99994",
                    DOJ = "01/03/2016",
                    Name = "Paolo Accorti",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle27.png",
                    EmailId = "paoloaccorti@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Elizabeth Mary"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "98823",
                    DOJ = "01/03/2011",
                    Name = "José Pedro",
                    Designation = "Software Engg",
                    ImageUrl = "People_Circle28.png",
                    EmailId = "jose.pedro@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Francisco Yang"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "20398",
                    DOJ = "01/03/2016",
                    Name = "Howard Snyd",
                    Designation = "Software Engg",
                    ImageUrl = "People_Circle29.png",
                    EmailId = "howardsnyd@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Francisco Yang"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "77738",
                    DOJ = "01/03/2017",
                    Name = "Manu Pereira",
                    Designation = "Software Engg",
                    ImageUrl = "People_Circle0.png",
                    EmailId = "manupereira@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Yang Wang"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "91292",
                    DOJ = "01/03/2010",
                    Name = "Mario Pontes",
                    Designation = "Software Engg",
                    ImageUrl = "Person0.png",
                    EmailId = "mario.pontes@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Yang Wang"
                });
                //hierarchy 5
                employee.Add(new DiagramEmployee()
                {
                    ID = "65522",
                    DOJ = "01/03/2011",
                    Name = "Carlos Schmitt",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle1.png",
                    EmailId = "carlosschmitt@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Pedro Afonso"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "99181",
                    DOJ = "01/03/2012",
                    Name = "Yoshi Latimer",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle2.png",
                    EmailId = "yoshilatimer@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Pedro Afonso"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "03993",
                    DOJ = "01/03/2011",
                    Name = "Patricia Kenna",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle3.png",
                    EmailId = "patriciakenna@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Elizabeth Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "81918",
                    DOJ = "01/03/2017",
                    Name = "Helen Bennett",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle4.png",
                    EmailId = "helenbennett@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Elizabeth Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "06999",
                    DOJ = "17/03/2010",
                    Name = "Daniel Tonini",
                    Designation = "Project Lead",
                    ImageUrl = "People_Circle5.png",
                    EmailId = "daniel.tonini@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Janine Labrune"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "73779",
                    DOJ = "17/03/2010",
                    Name = "Annette Roel",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle6.png",
                    EmailId = "annetteroel@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Janine Labrune"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "27222",
                    DOJ = "17/03/2013",
                    Name = "John Steel",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle7.png",
                    EmailId = "johnsteel@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Ann Devon"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "36339",
                    DOJ = "17/08/2013",
                    Name = "Jaime Yorres",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle8.png",
                    EmailId = "jaimeyorres@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Ann Devon"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "10295",
                    DOJ = "17/08/2013",
                    Name = "Carlos Nagy",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle9.png",
                    EmailId = "carlosnagy@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Roland Mendel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "95826",
                    DOJ = "17/08/2012",
                    Name = "Felipe Kloss",
                    Designation = "Team Lead",
                    ImageUrl = "People_Circle10.png",
                    EmailId = "felipe.kloss@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Roland Mendel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "28291",
                    DOJ = "17/08/2012",
                    Name = "Fran Wilson",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle11.png",
                    EmailId = "fran.wilson@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Aria Cruz"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "10395",
                    DOJ = "17/08/2012",
                    Name = "John Rovelli",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle12.png",
                    EmailId = "johnrovelli@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Aria Cruz"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "00041",
                    DOJ = "17/08/2014",
                    Name = "Catherine Kaff",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle13.png",
                    EmailId = "catherinekaff@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Martine Rancé"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "90906",
                    DOJ = "09/08/2014",
                    Name = "Jean Fresnière",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle14.png",
                    EmailId = "jean.freniere@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Martine Rancé"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "77282",
                    DOJ = "09/122014",
                    Name = "Simon Roel",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle15.png",
                    EmailId = "simonroel@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Maria Larsson"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "19098",
                    DOJ = "09/122014",
                    Name = "Yvonne Wong",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle16.png",
                    EmailId = "yvonnewong@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Maria Larsson"
                });

                employee.Add(new DiagramEmployee()
                {
                    ID = "75638",
                    DOJ = "09/122016",
                    Name = "Rene Phillips",
                    Designation = "Software Engg",
                    ImageUrl = "People_Circle17.png",
                    EmailId = "renephillips@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Diego Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "60021",
                    DOJ = "09/122016",
                    Name = "Yoshi Kenna",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle18.png",
                    EmailId = "yoshikenna@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Diego Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "50090",
                    DOJ = "09/122016",
                    Name = "Helen Marie",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle19.png",
                    EmailId = "helenmarie@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Peter Franken"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "80091",
                    DOJ = "09/122012",
                    Name = "Georg Louis",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle20.png",
                    EmailId = "georg.louis@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Peter Franken"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "78890",
                    DOJ = "09/122012",
                    Name = "Nardo Batista",
                    Designation = "Software Engg",
                    ImageUrl = "People_Circle21.png",
                    EmailId = "nardobatista@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Carine Schmitt"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "62777",
                    DOJ = "09/122012",
                    Name = "Horst Kloss",
                    Designation = "Senior S/W Engg",
                    ImageUrl = "People_Circle22.png",
                    EmailId = "horstkloss@northwind.com",
                    HasChild = true,
                    ReportingPerson = "Carine Schmitt"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "01973",
                    DOJ = "28/122012",
                    Name = "Mauri Moroni",
                    Designation = "Software Engg",
                    ImageUrl = "People_Circle23.png",
                    EmailId = "maurimoroni@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Paolo Accorti"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "74891",
                    DOJ = "28/122012",
                    Name = "Jonas Bergsen",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle24.png",
                    EmailId = "jonas.bergsen@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Paolo Accorti"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "66201",
                    DOJ = "28/122012",
                    Name = "Jose Pavarotti",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle25.png",
                    EmailId = "jose.pavarotti@northwind.com",
                    HasChild = false,
                    ReportingPerson = "José Pedro"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "39846",
                    DOJ = "28/122015",
                    Name = "Miguel Angel",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle26.png",
                    EmailId = "miguel.angel@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Howard Snyd"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "18276",
                    DOJ = "28/072015",
                    Name = "Jytte Petersen",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle27.png",
                    EmailId = "jyttepetersen@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Howard Snyd"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "30497",
                    DOJ = "28/072015",
                    Name = "Kloss Perrier",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle28.png",
                    EmailId = "kloss.perrier@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Manu Pereira"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "91811",
                    DOJ = "28/072015",
                    Name = "Pascal Cartrain",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle29.png",
                    EmailId = "pascal.cartrain@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Manu Pereira"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "77777",
                    DOJ = "28/072016",
                    Name = "Liz Nixon",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle0.png",
                    EmailId = "liznixon@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Mario Pontes"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "11786",
                    DOJ = "28/06/2016",
                    Name = "Liu Wong",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle1.png",
                    EmailId = "liuwong@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Mario Pontes"
                });

                //Hierarchy 6
                employee.Add(new DiagramEmployee()
                {
                    ID = "55555",
                    DOJ = "18/072016",
                    Name = "Karin Josephs",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle2.png",
                    EmailId = "karin.josephs@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Annette Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "11111",
                    DOJ = "18/072017",
                    Name = "Ruby Anabela",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle3.png",
                    EmailId = "ruby.anabela@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Annette Roel"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "93018",
                    DOJ = "18/072017",
                    Name = "Helvetis Nagy",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle4.png",
                    EmailId = "helvetis.nagy@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Felipe Kloss"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "83781",
                    DOJ = "18/072017",
                    Name = "Palle Ibsen",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle5.png",
                    EmailId = "palleibsen@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Felipe Kloss"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "84902",
                    DOJ = "18/05/2017",
                    Name = "Karl Jablonski",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle6.png",
                    EmailId = "karljablonski@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Jean Fresnière"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "83937",
                    DOJ = "18/03/2017",
                    Name = "Matti Kenna",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle7.png",
                    EmailId = "mattikenna@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Jean Fresnière"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "88729",
                    DOJ = "18/04/2015",
                    Name = "Zbyszek Yang",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle8.png",
                    EmailId = "zbyszekyang@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Yoshi Kenna"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "98765",
                    DOJ = "18/06/2015",
                    Name = "Nancy",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle9.png",
                    EmailId = "nancy@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Yoshi Kenna"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "23456",
                    DOJ = "23/12/2015",
                    Name = "Georg Pipps",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle10.png",
                    EmailId = "georg.pipps@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Horst Kloss"
                });
                employee.Add(new DiagramEmployee()
                {
                    ID = "09876",
                    DOJ = "23/12/2015",
                    Name = "Lucia Carvalho",
                    Designation = "Project Trainee",
                    ImageUrl = "People_Circle11.png",
                    EmailId = "lucia.carvalho@northwind.com",
                    HasChild = false,
                    ReportingPerson = "Horst Kloss"
                });
                return;
            }
            else if (Device.RuntimePlatform == Device.UWP)
            {
                employee.Add(new DiagramEmployee()
                {
                    Name = "Maria Anders",
                    ContactNo = 7899896099,
                    Designation = "Managing Director",
                    DOJ = "1-March-2010",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle1.png",
                    Salary = 90000,
                    HasChild = true,
                });


                employee.Add(new DiagramEmployee()
                {
                    Name = "Pedro Afonso",
                    ContactNo = 7899896099,
                    Designation = "Project Manager",
                    DOJ = "1/May/2010",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle2.png",
                    Salary = 80000,
                    ReportingPerson = "Elizabeth",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Elizabeth",
                    ContactNo = 7899896099,
                    Designation = "Team Lead",
                    DOJ = "27- Nov-2010",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle3.png",
                    Salary = 70000,
                    ReportingPerson = "George Lino",
                    HasChild = true,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Aria Cruz",
                    ContactNo = 7899896099,
                    Designation = "Project Lead",
                    DOJ = "12-feb-2010",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle4.png",
                    Salary = 70000,
                    ReportingPerson = "Philip Cramer",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Martin Sommer",
                    ContactNo = 7899896099,
                    Designation = "Senior S/W Engg",
                    DOJ = "23/may/2012",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle5.png",
                    Salary = 60000,
                    ReportingPerson = "Philip Cramer",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Jaime Yorres",
                    ContactNo = 7899896099,
                    Designation = "Project Trainee",
                    DOJ = "23/may/2012",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle6.png",
                    Salary = 50000,
                    ReportingPerson = "Carlos Nagy",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Hanna Moss",
                    ContactNo = 7899896099,
                    Designation = "Project Lead",
                    DOJ = "12-May-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle7.png",
                    Salary = 70000,
                    ReportingPerson = "Daniel Tonini",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Howard Synder",
                    ContactNo = 7899896099,
                    Designation = "Project Lead",
                    DOJ = "18-dec-2010",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle9.png",
                    Salary = 70000,
                    ReportingPerson = "George Lino",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Philip Cramer",
                    ContactNo = 7899896099,
                    Designation = "Project Manager",
                    DOJ = "07-August-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle10.png",
                    Salary = 80000,
                    ReportingPerson = "Maria Anders",
                    HasChild = true,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Daniel Tonini",
                    ContactNo = 7899896099,
                    Designation = "Project Lead",
                    DOJ = "21-Sep-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle11.png",
                    Salary = 70000,
                    ReportingPerson = "Maria Anders",
                    HasChild = true,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "George Lino",
                    ContactNo = 7899896099,
                    Designation = "Senior S/W Engg",
                    DOJ = "21-Sep-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle12.png",
                    Salary = 60000,
                    ReportingPerson = "Maria Anders",
                    HasChild = true,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Yoshi Tannamuri",
                    ContactNo = 7899896099,
                    Designation = "Project Lead",
                    DOJ = "21-Sep-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle13.png",
                    Salary = 50000,
                    ReportingPerson = "Daniel Tonini",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "John Steel",
                    ContactNo = 7899896099,
                    Designation = "Project Trainee",
                    DOJ = "21-Sep-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle14.png",
                    Salary = 40000,
                    ReportingPerson = "Martin Sommer",
                    HasChild = false,
                });

                employee.Add(new DiagramEmployee()
                {
                    Name = "Carlos Nagy",
                    ContactNo = 7899891099,
                    Designation = "Project Trainee",
                    DOJ = "21-Sep-2011",
                    EmailId = "joplin@xyz.com",
                    ImageUrl = "SampleBrowser.SfDiagram.People_Circle15.png",
                    Salary = 40000,
                    ReportingPerson = "Daniel Tonini",
                    HasChild = true,
                });
            }
        }
    }
}

/// <summary>
/// Employee class
/// </summary>
public class DiagramEmployee : INotifyPropertyChanged
{
    private string name;
    private double salary;
    private string destination;
    private string imageurl;
    private string doj;
    private string emailid;
    private double contactno;
    private string reportingPerson;
    private bool haschild;

    public DiagramEmployee()
    {

    }

    /// <summary>
    /// Get or set the haschild
    /// </summary>
    public bool HasChild
    {
        get { return haschild; }
        set
        {
            haschild = value;
        }
    }

    private string _mDesignation;
    private string id;

    /// <summary>
    /// Get or set the designation
    /// </summary>
    public string Designation
    {
        get { return _mDesignation; }
        set
        {
            if (_mDesignation != value)
            {
                _mDesignation = value;
                OnPropertyChanged("Designation");
            }
        }
    }

    /// <summary>
    /// Get or set the name
    /// </summary>
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (name != value)
            {
                name = value;
                OnPropertyChanged(("Name"));
            }
        }
    }

    public string ID
    {
        get
        {
            return id;
        }
        set
        {
            if (id != value)
            {
                id = value;
                OnPropertyChanged(("ID"));
            }
        }
    }

    /// <summary>
    /// Get or set the reporting person
    /// </summary>
    public string ReportingPerson
    {
        get
        {
            return reportingPerson;
        }
        set
        {
            if (reportingPerson != value)
            {
                reportingPerson = value;
                OnPropertyChanged(("ReportingPerson"));
            }
        }
    }

    /// <summary>
    /// Get or set the reportingid
    /// </summary>
    public int ReportingId
    {
        get;
        set;
    }

    /// <summary>
    /// Get or set the salary
    /// </summary>
    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            if (salary != value)
            {
                salary = value;
                OnPropertyChanged(("Salary"));
            }
        }
    }

    /// <summary>
    /// Get or set the destination
    /// </summary>
    public string Destination
    {
        get
        {
            return destination;
        }
        set
        {
            if (destination != value)
            {
                if (value != null)
                {
                    destination = value;
                    OnPropertyChanged(("Destination"));
                }
            }
        }
    }

    /// <summary>
    /// Get or set the imageurl
    /// </summary>
    public string ImageUrl
    {
        get
        {
            return imageurl;
        }
        set
        {
            if (imageurl != value)
            {
                if (value != null)
                {
                    imageurl = value;
                    OnPropertyChanged(("ImageUrl"));
                }
            }
        }
    }

    /// <summary>
    /// Get or set the DOJ
    /// </summary>
    public string DOJ
    {
        get
        {
            return doj;
        }
        set
        {
            if (doj != value)
            {
                doj = value;
                OnPropertyChanged(("Doj"));
            }
        }
    }

    /// <summary>
    /// Get or set the email id
    /// </summary>
    public string EmailId
    {
        get
        {
            return emailid;
        }
        set
        {
            if (emailid != value)
            {
                emailid = value;
                OnPropertyChanged(("EmailId"));
            }
        }
    }

    /// <summary>
    /// Get or set the ContactNo
    /// </summary>
    public double ContactNo
    {
        get
        {
            return contactno;
        }
        set
        {
            if (contactno != value)
            {
                contactno = value;
                OnPropertyChanged(("ContactNo"));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string name)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}