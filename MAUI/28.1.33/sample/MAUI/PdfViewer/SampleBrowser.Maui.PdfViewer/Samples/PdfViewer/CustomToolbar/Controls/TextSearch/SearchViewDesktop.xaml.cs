#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class SearchViewDesktop : SearchView
{
    internal void Initialize()
    {
        if (this.Content == null)
        {
            this.BindingContext = this;
            InitializeComponent();
            AssignControls();
            OnInitialized();
        }
    }

    void AssignControls()
    {
        SearchInputEntry = TextInput;
        SearchStatusLabel = StatusLabel;
        SearchBusyIndicator = BusyIndicator;
    }

    private void TextInput_TextChanged(object sender, TextChangedEventArgs e)
    {
        SearchButton.CommandParameter = TextInput.Text;
        ClearButton.CommandParameter = TextInput.Text;
    }
}