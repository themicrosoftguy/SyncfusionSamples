#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using CoreGraphics;
using Syncfusion.SfDiagram.iOS;
using UIKit;

namespace SampleBrowser
{
    public class Connectors : SampleView
    {
        SfDiagram diagram = new SfDiagram();
        UIPickerView selectionPicker1;
		UILabel connectorStyle;
		UIButton connectorStyleButton = new UIButton();
        UILabel connectorSize;
		UIButton doneButton = new UIButton();
        UIView HeaderBar = new UIView();
        UIButton straight;
        UIButton curve;
        UIButton ortho;
        UIButton plus;
        UIButton minus;
        UILabel sizeindicator;
        UIImageView plusimg;
        UIImageView minusimg;
        public Connectors()
        {
            HeaderBar.BackgroundColor = UIColor.FromRGB(245, 245, 245);
            var label = new UILabel();
            label.Text = "Connector Types: ";
            label.TextColor = UIColor.Black;
            label.BackgroundColor = UIColor.Clear;
            label.TextAlignment = UITextAlignment.Center;
            label.Frame = new CGRect(20, 0, 180, 60);
            HeaderBar.AddSubview(label);

            straight = AddButton(220, "Images/Diagram/CSStraight.png");
            straight.TouchUpInside+= Straight_TouchUpInside;
            HeaderBar.AddSubview(straight);

			curve = AddButton(280, "Images/Diagram/CSCurve.png");
            curve.TouchUpInside += Curve_TouchUpInside;;
			HeaderBar.AddSubview(curve);

			ortho = AddButton(340, "Images/Diagram/CSOrtho.png");
			ortho.TouchUpInside += Ortho_TouchUpInside;
			ortho.BackgroundColor = UIColor.FromRGB(30, 144, 255);
			HeaderBar.AddSubview(ortho);

            selectionPicker1 = new UIPickerView();
            this.OptionView = new UIView();

			PickerModel model = new PickerModel(verticalOrientationlist);
			selectionPicker1.Model = model;

			connectorStyle = new UILabel();
			connectorStyle.Text = "Connector Style";
			connectorStyle.TextColor = UIColor.Black;
			connectorStyle.TextAlignment = UITextAlignment.Left;

			connectorSize = new UILabel();
			connectorSize.Text = "Connector Size";
			connectorSize.TextColor = UIColor.Black;
			connectorSize.TextAlignment = UITextAlignment.Left;

			//Represent the vertical button
			connectorStyleButton = new UIButton();
			connectorStyleButton.SetTitle("Default", UIControlState.Normal);
			connectorStyleButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			connectorStyleButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Center;
			connectorStyleButton.Layer.CornerRadius = 8;
			connectorStyleButton.Layer.BorderWidth = 2;
			connectorStyleButton.TouchUpInside += ShowPicker1;
            connectorStyleButton.BackgroundColor = UIColor.LightGray;
			connectorStyleButton.Layer.BorderColor = UIColor.FromRGB(246, 246, 246).CGColor;

            plus = new UIButton();
            plus.BackgroundColor = UIColor.White;
            plus.Layer.CornerRadius = 8;
            plus.Layer.BorderWidth = 0.5f;
            plus.TouchUpInside+= Plus_TouchUpInside;
            plusimg = new UIImageView();
            plusimg.Image = UIImage.FromBundle("Images/Diagram/CSplus.png");
            plus.AddSubview(plusimg);

			minus = new UIButton();
            minus.BackgroundColor = UIColor.White;
            minus.Layer.CornerRadius = 8;
			minus.Layer.BorderWidth = 0.5f;
            minus.TouchUpInside += Minus_TouchUpInside;
			minusimg = new UIImageView();
			minusimg.Image = UIImage.FromBundle("Images/Diagram/CSsub.png");
            minus.AddSubview(minusimg);

            sizeindicator =new UILabel();
            sizeindicator.Text = width.ToString();
            sizeindicator.BackgroundColor = UIColor.Clear;
            sizeindicator.TextColor = UIColor.Black;
            sizeindicator.TextAlignment = UITextAlignment.Center;

			//Represent the button
			doneButton.SetTitle("Done\t", UIControlState.Normal);
			doneButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
			doneButton.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;
			doneButton.TouchUpInside += HidePicker;
			doneButton.Hidden = true;
			doneButton.BackgroundColor = UIColor.FromRGB(246, 246, 246);
			selectionPicker1.ShowSelectionIndicator = true;
			selectionPicker1.Hidden = true;

            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();
            Node node6 = new Node();
            Node node7 = new Node();
            Node node8 = new Node();
            Node node9 = new Node();
            Node node10 = new Node();
            Node node11 = new Node();
            diagram.IsReadOnly = true;

            node1 = AddNode(456, 180, "CEO", UIColor.FromRGB(201, 32, 61));
            node2 = AddNode(286, 396, "Manager", UIColor.FromRGB(23, 132, 206));
            node3 = AddNode(646, 396, "Manager", UIColor.FromRGB(23, 132, 206));
            node4 = AddNode(204, 612, "Team Lead", UIColor.FromRGB(4, 142, 135));
            node5 = AddNode(384, 612, "Team Lead", UIColor.FromRGB(4, 142, 135));
            node6 = AddNode(564, 612, "Team Lead", UIColor.FromRGB(4, 142, 135));
            node7 = AddNode(744, 612, "Team Lead", UIColor.FromRGB(4, 142, 135));
            node8 = AddNode(108, 828, "Trainee", UIColor.FromRGB(206, 98, 9));
            node9 = AddNode(324, 828, "Trainee", UIColor.FromRGB(206, 98, 9));
            node10 = AddNode(648, 828, "Trainee", UIColor.FromRGB(206, 98, 9));
            node11 = AddNode(864, 828, "Trainee", UIColor.FromRGB(206, 98, 9));


            diagram.AddNode(node1);
            diagram.AddNode(node2);
            diagram.AddNode(node3);
            diagram.AddNode(node4);
            diagram.AddNode(node5);
            diagram.AddNode(node6);
            diagram.AddNode(node7);
            diagram.AddNode(node8);
            diagram.AddNode(node9);
            diagram.AddNode(node10);
            diagram.AddNode(node11);
            diagram.AddConnector(AddConnector(node1, node2));
            diagram.AddConnector(AddConnector(node1, node3));
            diagram.AddConnector(AddConnector(node2, node4));
            diagram.AddConnector(AddConnector(node2, node5));
            diagram.AddConnector(AddConnector(node3, node6));
            diagram.AddConnector(AddConnector(node3, node7));
            diagram.AddConnector(AddConnector(node4, node8));
            diagram.AddConnector(AddConnector(node4, node9));
            diagram.AddConnector(AddConnector(node7, node10));
            diagram.AddConnector(AddConnector(node7, node11));
            diagram.Loaded += Diagram_Loaded;
            this.AddSubview(diagram);
			HeaderBar.Frame = new CGRect(0, 0, UIScreen.MainScreen.Bounds.Width, 60);
            this.AddSubview(HeaderBar);
            model.PickerChanged += SelectedIndexChanged;
        }
        int width = 1;
        void Plus_TouchUpInside(object sender, EventArgs e)
        {
            if (width < 5)
            {
                width = (int)diagram.Connectors[0].Style.StrokeWidth + 1;
                sizeindicator.Text = width.ToString();
                for (int i = 0; i < diagram.Connectors.Count; i++)
                    diagram.Connectors[i].Style.StrokeWidth += 1;
            }
        }

        void Minus_TouchUpInside(object sender, EventArgs e)
        {
            if (width > 1)
            {
                width = (int)diagram.Connectors[0].Style.StrokeWidth - 1;
                sizeindicator.Text = width.ToString();
                for (int i = 0; i < diagram.Connectors.Count; i++)
                    diagram.Connectors[i].Style.StrokeWidth -= 1;
            }
        }

        void HidePicker(object sender, EventArgs e)
		{
			doneButton.Hidden = true;
			selectionPicker1.Hidden = true;
		}

		private void SelectedIndexChanged(object sender, PickerChangedEventArgs e)
		{
            //this.selectedType = selectedorientation + e.SelectedValue;
            if(e.SelectedValue=="Default")
            {
                for (int i = 0; i < diagram.Connectors.Count; i++)
                    diagram.Connectors[i].Style.StrokeStyle = StrokeStyle.Default;
            }
			else if (e.SelectedValue == "Dashed")
			{
				for (int i = 0; i < diagram.Connectors.Count; i++)
                    diagram.Connectors[i].Style.StrokeStyle = StrokeStyle.Dashed;
			}
			else if (e.SelectedValue == "Dotted")
			{
				for (int i = 0; i < diagram.Connectors.Count; i++)
                    diagram.Connectors[i].Style.StrokeStyle = StrokeStyle.Dotted;
			}
		}

		public override void LayoutSubviews()
        {
            base.LayoutSubviews();
			foreach (var view in this.Subviews)
			{
				connectorStyle.Frame = new CGRect(this.Frame.X + 10, 0, PopoverSize.Width - 20, 30);
				connectorStyleButton.Frame = new CGRect(this.Frame.X + 10, 40, PopoverSize.Width - 20, 30);
                connectorSize.Frame = new CGRect(this.Frame.X + 10, 80, PopoverSize.Width - 20, 30);
                plus.Frame = new CGRect(this.Frame.X + 60, 120, 30, 30);
                plusimg.Frame = new CGRect(0,0, 30, 30);
                minus.Frame = new CGRect(this.Frame.X + 160, 120, 30, 30);
                minusimg.Frame = new CGRect(0, 0, 30, 30);
                sizeindicator.Frame = new CGRect(this.Frame.X + 110, 120, 30, 30);
				selectionPicker1.Frame = new CGRect(0, PopoverSize.Height / 2, PopoverSize.Width, PopoverSize.Height / 3);
				doneButton.Frame = new CGRect(0, PopoverSize.Height / 2.5, PopoverSize.Width, 40);
			}
            optionView();
        }
		public void optionView()
		{
			this.OptionView.AddSubview(connectorStyle);
			this.OptionView.AddSubview(connectorStyleButton);
			this.OptionView.AddSubview(connectorSize);
            this.OptionView.AddSubview(plus);
            this.OptionView.AddSubview(minus);
            this.OptionView.AddSubview(sizeindicator);
			this.OptionView.AddSubview(selectionPicker1);
			this.OptionView.AddSubview(doneButton);
		}
        private void ShowPicker1(object sender, EventArgs e)
        {
            (sender as UIButton).BackgroundColor = UIColor.LightGray;

			doneButton.Hidden = false;
			selectionPicker1.Hidden = false;
        }

        private UIButton AddButton(int v1, string v2)
        {
			UIButton straight = new UIButton();
			straight.BackgroundColor = UIColor.White;
			straight.TouchUpInside += Straight_TouchUpInside;
			straight.Frame = new CGRect(v1, 10, 40, 40);
			straight.Layer.CornerRadius = 20;
			straight.Layer.BorderColor = UIColor.Black.CGColor;
            straight.Layer.BorderWidth = 1.5f;
			UIImageView img = new UIImageView();
			img.Frame = new CGRect(10, 10, 20, 20);
			img.BackgroundColor = UIColor.Clear;
			img.Image = UIImage.FromBundle(v2);
			straight.AddSubview(img);
            return straight;
        }

        private readonly IList<string> verticalOrientationlist = new List<string>
		{
			"Default",
			"Dashed",
			"Dotted"
		};

        private Connector AddConnector(Port port1, Port port2)
        {
            var c1 = new Connector();
            c1.SourcePort = port1;
            c1.TargetPort = port2;
            c1.Style.StrokeWidth = 1;
            c1.Style.StrokeBrush = new SolidBrush(UIColor.FromRGB(127, 132, 133));
            c1.TargetDecoratorType = DecoratorType.None;
            return c1;
        }

        private void Diagram_Loaded(object sender)
        {
            diagram.BringToView(diagram.Nodes[0]);
        }

        private Connector AddConnector(Node sourceNode, Node targetNode)
        {
            var c1 = new Connector();
            c1.SourceNode = sourceNode;
            c1.TargetNode = targetNode;
            c1.Style.StrokeWidth = 1 ;
            c1.Style.StrokeBrush = new SolidBrush(UIColor.FromRGB(127, 132, 133));
            c1.TargetDecoratorType = DecoratorType.None;
            return c1;
        }
        Node AddNode(int x, int y, string text, UIColor nodeColor)
        {
            Node node = new Node();
            node = new Node(x, y, 144, 108);
            node.ShapeType = ShapeType.RoundedRectangle;
            node.Style.StrokeWidth = 1;
            node.Style.Brush = new SolidBrush(nodeColor);
            node.Style.StrokeBrush = new SolidBrush(UIColor.FromRGB(127, 132, 133));
            node.Annotations.Add(new Annotation() { Content = text, FontSize = 15, TextBrush = new SolidBrush(UIColor.White) });
            return node;
        }

        void Straight_TouchUpInside(object sender, EventArgs e)
        {
            (sender as UIButton).BackgroundColor = UIColor.FromRGB(30, 144, 255);
            ((sender as UIButton).Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSStraight1");
            for (int i = 0; i < diagram.Connectors.Count; i++)
                diagram.Connectors[i].SegmentType = SegmentType.StraightSegment;
            curve.BackgroundColor = UIColor.White;
            ortho.BackgroundColor = UIColor.White;
            (curve.Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSCurve");
            (ortho.Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSOrtho");
        }

        void Ortho_TouchUpInside(object sender, EventArgs e)
        {
			(sender as UIButton).BackgroundColor = UIColor.FromRGB(30, 144, 255);
			((sender as UIButton).Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSOrtho1");
			for (int i = 0; i < diagram.Connectors.Count; i++)
                diagram.Connectors[i].SegmentType = SegmentType.OrthoSegment;
			curve.BackgroundColor = UIColor.White;
            (curve.Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSCurve");
            straight.BackgroundColor = UIColor.White;
            (straight.Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSStraight");
        }

        void Curve_TouchUpInside(object sender, EventArgs e)
        {
			(sender as UIButton).BackgroundColor = UIColor.FromRGB(30, 144, 255);
			((sender as UIButton).Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSCurve1");
			for (int i = 0; i < diagram.Connectors.Count; i++)
                diagram.Connectors[i].SegmentType = SegmentType.CurveSegment;
            straight.BackgroundColor = UIColor.White;
			ortho.BackgroundColor = UIColor.White;
            (ortho.Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSOrtho");
            (straight.Subviews[0] as UIImageView).Image = UIImage.FromBundle("Images/Diagram/CSStraight");
        }
    }
}