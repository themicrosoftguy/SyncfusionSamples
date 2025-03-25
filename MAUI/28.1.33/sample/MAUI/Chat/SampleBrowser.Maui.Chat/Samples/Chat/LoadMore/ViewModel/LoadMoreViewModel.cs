#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.Maui.Base.Converters;
using Syncfusion.Maui.Chat;
using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleBrowser.Maui.Chat.SfChat
{
	public class LoadMoreViewModel : INotifyPropertyChanged
	{
		#region Fields

		private ObservableCollection<object>? messages;
		private int[] authorArray;
		private Author? currentUser;
		private List<string>? messageList;
		private bool isLazyLoading;
		private LoadMoreOption loadMoreBehavior;

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="LoadMoreViewModel"/> class.
		/// </summary>
		public LoadMoreViewModel()
		{
			this.Messages = new ObservableCollection<object>();
			this.InitializeAuthors();
			this.InitializeMessageList();
			this.authorArray = new int[] { 0, 1, 2, 2, 0, 3, 4, 0, 3, 0, 5, 0, 1, 0, 2, 0, 3, 0, 4, 0, 5, 0, 5, 1 };
			this.MapAuthorToMessage();
			this.CurrentUser = this.AuthorsCollection![0];
			LoadMoreCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);
			this.InitConvo();
		}

		#endregion

		#region Public Properties

		public ObservableCollection<object>? Messages
		{
			get
			{
				return this.messages;
			}

			set
			{
				this.messages = value;
				RaisePropertyChanged("Messages");
			}
		}

		public Author? CurrentUser
		{
			get
			{
				return this.currentUser;
			}
			set
			{
				this.currentUser = value;
				RaisePropertyChanged("CurrentUser");
			}
		}


		/// <summary>
		/// Gets or sets the load more command.
		/// </summary>
		public ICommand? LoadMoreCommand { get; set; }

		/// <summary>
		/// Gets or sets the IsBusy.
		/// </summary>
		public bool IsLazyLoading
		{
			get
			{
				return this.isLazyLoading;
			}
			set
			{
				this.isLazyLoading = value;
				RaisePropertyChanged("IsLazyLoading");
			}
		}

		/// <summary>
		/// Gets or sets the LoadMoreBehavior of SfChat.
		/// </summary>
		public LoadMoreOption LoadMoreBehavior
		{
			get
			{
				return this.loadMoreBehavior;
			}

			set
			{
				this.loadMoreBehavior = value;
				RaisePropertyChanged("LoadMoreBehavior");
			}
		}

		#endregion

		#region Internal Properties

		internal ObservableCollection<Author>? AuthorsCollection
		{
			get;
			set;
		}

		internal Dictionary<int, Author>? AuthorMessageDataBase
		{
			get;
			set;
		}

		#endregion

		#region Property Changed

		public event PropertyChangedEventHandler? PropertyChanged;

		public void RaisePropertyChanged(string propName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}

		#endregion

		#region Private Methods

		#region Init

		/// <summary>
		/// Initializes the message collection for group conversation.
		/// </summary>
		private void InitializeMessageList()
		{
			this.messageList = new List<string>
			{
				"Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
				"Oh! That's great.",
				"That is good news.",
				"Are we going to develop the app natively or hybrid?",
				"We should develop this app in .NET MAUI, since it provides native experience and performance.",
				"I haven't heard of .NET MAUI. What's .NET MAUI?",
				".NET MAUI is a new library that lets you build native UIs for Android, iOS, macOS, and Windows from one shared C# codebase.",
				"You can check out this link to get started with .NET MAUI.",
				"That's great! I will look into it.",
				"Yes, please do. It saves a lot of development time from what I've heard. We may have to dig deeper to know more.",
				"What kind of application is it and when are we going to launch?",
				"A kind of emergency broadcast app.",
				"Can you please elaborate?",
				"The app will help users broadcast emergency messages to friends and family from their phones with location data during emergency situations.",
				"Can we extend this idea and broadcast the data all the time? It will be better if we provide options to broadcast to selected people based on timing or profiles.",
				"That's a great idea. We can consider that in our requirements.",
				"Do we have a layout design for the new app?",
				"We will have a dedicated design engineer to design the layout once the requirements are finalized.",
				"Is this app going to be supported in wearable technology, too?",
				"No, not yet. We are going to develop the mobile version first. Support for wearable watches can be considered for the next version, though.",
				"Are we going to recruit a new team? Otherwise, will we migrate our existing engineers?",
				"Since our current project is going to be complete by the end of next month, we can move the required resources from there to the development of this app. I will have all the details by the end of next week.",
				"Wow! That's great.",
				"Cool. Cheers",
			};
		}

		/// <summary>
		/// Initializes the author collection.
		/// </summary>
		private void InitializeAuthors()
		{
			this.AuthorsCollection = new ObservableCollection<Author>();
			var author1 = new Author() { Name = "Nancy" };
			var author2 = new Author() { Name = "Andrea" };
			var author3 = new Author() { Name = "Harrison" };
			var author4 = new Author() { Name = "Margaret" };
			var author5 = new Author() { Name = "Steven" };
			var author6 = new Author() { Name = "Michale" };
			author1.SetBinding(Author.AvatarProperty, new Binding() { Source = "people_circle1.png", Converter = new SfImageSourceConverter() });
			author2.SetBinding(Author.AvatarProperty, new Binding() { Source = "people_circle0.png", Converter = new SfImageSourceConverter() });
			author3.SetBinding(Author.AvatarProperty, new Binding() { Source = "people_circle14.png", Converter = new SfImageSourceConverter() });
			author4.SetBinding(Author.AvatarProperty, new Binding() { Source = "people_circle13.png", Converter = new SfImageSourceConverter() });
			author5.SetBinding(Author.AvatarProperty, new Binding() { Source = "people_circle23.png", Converter = new SfImageSourceConverter() });
			author6.SetBinding(Author.AvatarProperty, new Binding() { Source = "people_circle26.png", Converter = new SfImageSourceConverter() });

			this.AuthorsCollection.Add(author1);
			this.AuthorsCollection.Add(author2);
			this.AuthorsCollection.Add(author3);
			this.AuthorsCollection.Add(author4);
			this.AuthorsCollection.Add(author5);
			this.AuthorsCollection.Add(author6);
		}

		/// <summary>
		/// Initializes the conversation and adds messages.
		/// </summary>
		private void InitConvo()
		{
			for (int i = messageList!.Count - 8; i < this.messageList.Count; i++)
			{ 
				this.Messages!.Add(this.CreateMessage(this.messageList[i], this.AuthorMessageDataBase![i]));
			}
		}

		/// <summary>
		/// Initializes which message belongs to which author.
		/// </summary>
		private void MapAuthorToMessage()
		{
			this.AuthorMessageDataBase = new Dictionary<int, Author>();
			for (int i = 0; i < this.messageList!.Count; i++)
			{
				this.AuthorMessageDataBase.Add(i, this.AuthorsCollection![this.authorArray[i]]);
			}
		}

		#endregion

		/// <summary>
		/// Creating message to based on the given string.
		/// </summary>
		/// <param name="text">The text of the new message.</param>
		/// <param name="auth">The author of the new message.</param>
		/// <returns>The <see cref="TextMessage"/> created with the given string.</returns>
		private TextMessage CreateMessage(string text, Author auth)
		{
			if (text.Contains("link to get started with .NET MAUI."))
			{
				return new HyperlinkMessage()
				{
					DateTime = DateTime.Now,
					Author = auth,
					Text = text,
					Url = "https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui?view=net-maui-8.0"
				};
			}
			return new TextMessage()
			{
				DateTime = DateTime.Now,
				Author = auth,
				Text = text,
			};
		}

		/// <summary>
		/// Action Raised when the load more command.
		/// </summary>        
		private bool CanLoadMoreItems(object obj)
		{
			if (this.Messages!.Count >= this.messageList!.Count)
			{
				isLazyLoading = false;
				return false;
			}

			return true;
		}

		/// <summary>
		/// Action raised when the load more command is executed.
		/// </summary>
		private async void LoadMoreItems(object obj)
		{
			IsLazyLoading = true;
			await Task.Delay(3000);
			LoadMoreMessages();
			IsLazyLoading = false;
			if ((this.LoadMoreBehavior == LoadMoreOption.Auto || this.LoadMoreBehavior == LoadMoreOption.AutoOnScroll) && this.messageList!.Count == this.Messages!.Count)
			{
				this.LoadMoreBehavior = LoadMoreOption.None;
			}
		}

		private void LoadMoreMessages()
		{
			if (this.Messages != null)
			{
				for (int i = 1; i <= 5; i++)
				{
					if (this.messageList!.Count != this.Messages.Count)
					{
						this.Messages.Insert(0, this.CreateMessage(messageList[this.messageList.Count - this.Messages.Count - 1], AuthorMessageDataBase![this.messageList.Count - this.Messages.Count - 1]));
					}
				}
			}
		}

		#endregion
	}
}
