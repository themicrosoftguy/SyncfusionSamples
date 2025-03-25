#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Maui.PdfViewer;

namespace SampleBrowser.Maui.PdfViewer.SfPdfViewer;

public partial class AnnotationToolbarDesktop : AnnotationToolbarView
{
    internal StampViewDesktop? StampViewDesktop { get; set; }
	public AnnotationToolbarDesktop()
	{
		InitializeComponent();
        AssignControls();
    }

    public void SetBindings()
    {
        textMarkupButton.SetBinding(Button.TextProperty, new Binding() { Path = nameof(Syncfusion.Maui.PdfViewer.SfPdfViewer.AnnotationMode), Source = PdfViewer, Converter = new AnnotationModeToIconConverter("TextMarkup") });
        shapeButton.SetBinding(Button.TextProperty, new Binding() { Path = nameof(Syncfusion.Maui.PdfViewer.SfPdfViewer.AnnotationMode), Source = PdfViewer, Converter = new AnnotationModeToIconConverter("Shape") });
    }

    void AssignControls()
    {
        StampButton = stampButton;
        UndoButton = undoButton;
        RedoButton = redoButton;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender != signButton)
            ParentView?.CloseAllDialogs();
        if (sender is Button button)
        {
            double x = 0;
            if (button.Parent is Grid buttonGrid)
            {
                x = buttonGrid.X + centerLayout.X;
                if (button == colorPalette || button == stickyIconChangeButton || button == fontSizeDropDownButton || button == thicknessButton)
                    x += editLayout.X;
            }

            if (BindingContext is CustomToolbarViewModel viewModel)
            {
                if (button == textMarkupButton)
                {
                    ParentView?.TextMarkUpHighlightDisappear();
                    viewModel.TextMarkupListMargin = new Thickness(x, 40, 0, 0);
                }
                else if(button== fontSizeDropDownButton)
                {
                    ParentView?.FreeTextFontSizeListDisappear();
                    viewModel.FreeTextFontSizeListMargin=new Thickness(x,40,0,0);
                }
                else if(button == thicknessButton)
                {
                    viewModel.ThicknessButtonMargin=new Thickness(x,40,0,0);
                }
                else if (button == shapeButton)
                {
                    ParentView?.ShapeHighlightDisapper();
                    viewModel.ShapeListMargin = new Thickness(x, 40, 0, 0);
                }
                else if (button == stampButton)
                {
                    double stampContextMenuWidth = 176;
                    if (x + stampContextMenuWidth <= this.Bounds.Width)
                    {
                        viewModel.StampListMargin = new Thickness(x, 40, 0, 0);
                    }
                    else
                        viewModel.StampListMargin = new Thickness(this.Bounds.Width - stampContextMenuWidth, 40, 0, 0);
                    StampViewDesktop?.ShowCustomStamp();
                    if (ParentView != null && ParentView.StampView != null)
                        ParentView.StampView.StampMode = false;
                }
                else if (button == signButton)
                {
                    double signatureListWidth = 230;
                    if (x + signatureListWidth <= this.Bounds.Width)
                    {
                        viewModel.SignatureListMargin = new Thickness(x, 48, 0, 0);
                    }
                    else
                        viewModel.SignatureListMargin = new Thickness(this.Bounds.Width - signatureListWidth, 48, 0, 0);
                }
                else if(button == stickyIconChangeButton)
                    viewModel.StickyNoteListMargin = new Thickness(x, 40, 0, 0);
                else if (button == colorPalette && (viewModel.IsFreeTextFillColorVisble || viewModel.IsShapeColorPalleteVisible || viewModel.IsLineAndArrowColorPalleteVisible || viewModel.IsTextMarkUpColorPalleteVisible || viewModel.IsStickyNoteColorPalleteVisible || viewModel.IsInkColorPalleteVisible || viewModel.IsStampOpacitySliderbarVisible || viewModel.IsEraserThicknessToolbarVisible))
                    viewModel.ColorPaletteMargin = new Thickness(x, 40, 0, 0);
                else if (button == fileOperation)
                {
                    viewModel.FileOperationListMargin = new Thickness(0, 40, 0, 0);
                    viewModel.IsFileOperationListVisible = !viewModel.IsFileOperationListVisible;
                    viewModel.FileOperationHighlightColor = viewModel.IsFileOperationListVisible ? Color.FromRgba(0, 0, 0, 20) : Colors.Transparent;
                    PdfViewer!.AnnotationMode = AnnotationMode.None;
                    viewModel.ClearButtonHighlights();
                    viewModel.IsShapeListVisible = false;
                    viewModel.IsTextMarkupListVisible = false;
                    viewModel.IsStampListVisible = false;
                    viewModel.IsStickyNoteMode = false;
                }
            }
        }
    }
    private void undoRedoBtton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is CustomToolbarViewModel viewModel)
        {
            viewModel.HideDeskTopOverLays();
            viewModel.CloseAllDialogs();
        }
    }
}