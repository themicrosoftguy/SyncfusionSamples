#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.ComponentModel;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class SearchViewMobile : SearchView, INotifyPropertyChanged
{
    public new event PropertyChangedEventHandler? PropertyChanged;

    protected override void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        if (IsTextEntered)
            ClearButton.IsVisible = true;

        if (name.Equals("IsMatchCase") && IsMoreOptionsVisible)
            IsMoreOptionsVisible = false;
    }

    bool _isMoreOptionsVisible = false;
    bool isTextEntered = false;

    public bool IsMoreOptionsVisible
    {
        get
        {
            return _isMoreOptionsVisible;
        }
        set
        {
            _isMoreOptionsVisible = value;
            OnPropertyChanged(nameof(IsMoreOptionsVisible));
        }
    }

    public bool IsTextEntered
    {
        get
        {
            return isTextEntered;
        }
        set
        {
            isTextEntered = value;
            OnPropertyChanged(nameof(IsTextEntered));
        }
    }

    public SearchViewMobile()
    {
        this.BindingContext = this;
        InitializeComponent();
        AssignControls();
        OnInitialized();
    }

	void AssignControls()
	{
        SearchInputEntry = TextInput;
		SearchStatusLabel = StatusLabel;
		SearchBusyIndicator = BusyIndicator;
    }

    private void ChangeMatchCaseDialogVisibility_Clicked(object sender, EventArgs e)
    {
        if (IsMoreOptionsVisible)
            IsMoreOptionsVisible = false;
        else
            IsMoreOptionsVisible = true;
    }
    public override void Close()
    {
        if (IsMoreOptionsVisible)
            IsMoreOptionsVisible = false;
        base.Close();
    }

    private void TextInput_TextChanged(object sender, TextChangedEventArgs e)
    {
        IsTextEntered = true;
        SearchButton.CommandParameter = TextInput.Text;
        ClearButton.CommandParameter = TextInput.Text;
    }
}