#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SampleBrowser.Maui.Shimmer.SfShimmer;

public partial class Articles : SampleView
{
    IDispatcherTimer timer;
    public Articles()
	{
		InitializeComponent();
        timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromMilliseconds(3000);
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        if (listView == null || shimmer == null)
        {
            return;
        }
        if (DeviceInfo.Current.Platform == DevicePlatform.WinUI || DeviceInfo.Current.Platform == DevicePlatform.MacCatalyst)
        {
            height = 600;
        }

        listView.RowHeight = (int)(height / 6);
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        shimmer.IsActive = false;
        timer.Stop();
    }

    public override void OnDisappearing()
    {
        timer.Stop();
        timer.Tick -= Timer_Tick;
    }
}

public class BookViewModel
{
    private ObservableCollection<BookInfo> info1;

    public ObservableCollection<BookInfo> Info1
    {
        get { return info1; }
        set { info1 = value; }
    }

    public BookViewModel()
    {
        info1 = new ObservableCollection<BookInfo>
        {
            new BookInfo() { BookImage = "book0.png",Author = "James McCaffrey", BookName = "Neural Networks Using C#", Summary = "Neural networks are an exciting field of software development used to calculate outputs from input data." },
            new BookInfo() { BookImage = "book1.png",Author = "Dirk Strauss", BookName = "C# Code Contracts", Summary = "Code Contracts provide a way to convey code assumptions in your .NET applications. In C# Code Contracts Succinctly, author Dirk Strauss explains how to use Code Contracts to validate logical correctness in code." },
            new BookInfo() { BookImage = "book2.png",Author = "James McCaffrey", BookName = "Machine Learning Using C#", Summary = "In Machine Learning Using C# Succinctly, you'll learn several different approaches to applying machine learning to data analysis and prediction problems." },
            new BookInfo() { BookImage = "book3.png",Author = "Mark Twain", BookName = "Entity Framework Code First", Summary = "Follow author Ricardo Peres as he introduces the newest development mode for Entity Framework, Code First." },
            new BookInfo() { BookImage = "book4.png",Author = "Joseph Conrad", BookName = "SQL Server for C# Developers", Summary = "Developers of C# applications with a SQL Server database can learn to connect to a database using classic ADO.NET and look at different methods of developing databases using the Entity Framework." },
            new BookInfo() { BookImage = "book5.png",Author = "Nathaniel Hawthorne", BookName = "Assembly Language", Summary = "Assembly language is as close to writing machine code as you can get without writing in pure hexadecimal." },
        };
    }
}

public class BookInfo : INotifyPropertyChanged
{
    #region Fields

    private string? bookName;
    private string? bookImage;
    private string? summary;
    private string? author;

    #endregion

    #region Constructor

    public BookInfo()
    {

    }

    #endregion

    #region Public Properties

    public string? BookName
    {
        get { return this.bookName; }
        set
        {
            this.bookName = value;
            RaisePropertyChanged("ContactName");
        }
    }

    public string? Author
    {
        get { return this.author; }
        set
        {
            this.author = value;
            RaisePropertyChanged("Author");
        }
    }

    public string? Summary
    {
        get { return this.summary; }
        set
        {
            this.summary = value;
            RaisePropertyChanged("Message");
        }
    }

    public string? BookImage
    {
        get { return this.bookImage; }
        set
        {
            if (value != null)
            {
                this.bookImage = value;
                this.RaisePropertyChanged("ContactImage");
            }
        }
    }

    #endregion

    #region INotifyPropertyChanged implementation

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged(String name)
    {
        if (PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    #endregion
}