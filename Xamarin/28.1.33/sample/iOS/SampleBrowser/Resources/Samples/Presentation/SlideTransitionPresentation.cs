#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Syncfusion.Presentation;
using System.IO;
using COLOR = Syncfusion.Drawing;
using System.Reflection;
#if __UNIFIED__
using Foundation;
using UIKit;
using CoreGraphics;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using CGRect = System.Drawing.RectangleF;
using CGPoint = System.Drawing.PointF;
using CGSize = System.Drawing.SizeF;
#endif
namespace SampleBrowser
{
	public partial class SlideTransitionPresentation : SampleView
	{
		CGRect frameRect = new CGRect ();
		float frameMargin = 8.0f;
		UILabel label;
		UILabel label1;
		UIButton button;
		public SlideTransitionPresentation()
		{

			label1 = new UILabel();
			label = new UILabel();
			button = new UIButton(UIButtonType.System);
			button.TouchUpInside += OnButtonClicked;
		}

		void LoadAllowedTextsLabel()
		{
			label.Frame = frameRect;
			label.TextColor = UIColor.FromRGB (38/255.0f, 38/255.0f, 38/255.0f);
			label.Text = "This sample demonstrates how to create a transition effects in PowerPoint presentation slides.";
			label.Font = UIFont.SystemFontOfSize(15);
			label.Lines 				= 0;
			label.LineBreakMode 		= UILineBreakMode.WordWrap;
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) {
				label.Font = UIFont.SystemFontOfSize(18);
				label.Frame = new CGRect (5, 5,frameRect.Location.X + frameRect.Size.Width  , 50);
			} 
			else {
				label.Frame = new CGRect (frameRect.Location.X, 5, frameRect.Size.Width , 70);

			}
			this.AddSubview (label);
			button.SetTitle("Generate Presentation",UIControlState.Normal);
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) {
				button.Frame = new CGRect (0, 65, frameRect.Location.X + frameRect.Size.Width , 10);
			} 
			else {
				button.Frame = new CGRect (frameRect.Location.X, 70, frameRect.Size.Width , 10);

			}
			this.AddSubview (button);
		}




		void OnButtonClicked(object sender, EventArgs e)
		{
            string resourcePath = "SampleBrowser.Samples.Presentation.Templates.Transition.pptx";
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream fileStream = assembly.GetManifestResourceStream(resourcePath);

            IPresentation presentation = Presentation.Open(fileStream);

            //Create slide transition
            CreateTransition(presentation);

            MemoryStream stream = new MemoryStream();
            presentation.Save(stream);
            presentation.Close();
            stream.Position = 0;

			if (stream != null)
			{
				SaveiOS iOSSave = new SaveiOS ();
				iOSSave.Save ("SlideTransitionSample.pptx", "application/mspowerpoint", stream);
			}

		}

        #region Create Slide Transition

        private void CreateTransition(IPresentation presentation)
        {
            //Get the first slide from the presentation
            ISlide slide1 = presentation.Slides[0];

            // Add the 'Wheel' transition effect to the first slide
            slide1.SlideTransition.TransitionEffect = TransitionEffect.Wheel;

            // Get the second slide from the presentation
            ISlide slide2 = presentation.Slides[1];

            // Add the 'Checkerboard' transition effect to the second slide
            slide2.SlideTransition.TransitionEffect = TransitionEffect.Checkerboard;

            // Add the subtype to the transition effect
            slide2.SlideTransition.TransitionEffectOption = TransitionEffectOption.Across;

            // Apply the value to transition mouse on click parameter
            slide2.SlideTransition.TriggerOnClick = true;

            // Get the third slide from the presentation
            ISlide slide3 = presentation.Slides[2];

            // Add the 'Orbit' transition effect for slide
            slide3.SlideTransition.TransitionEffect = TransitionEffect.Orbit;

            // Add the speed for transition
            slide3.SlideTransition.Speed = TransitionSpeed.Fast;

            // Get the fourth slide from the presentation
            ISlide slide4 = presentation.Slides[3];

            // Add the 'Uncover' transition effect to the slide
            slide4.SlideTransition.TransitionEffect = TransitionEffect.Uncover;

            // Apply the value to advance on time for slide
            slide4.SlideTransition.TriggerOnTimeDelay = true;

            // Assign the advance on time value
            slide4.SlideTransition.TimeDelay = 5;

            // Get the fifth slide from the presentation
            ISlide slide5 = presentation.Slides[4];

            // Add the 'PageCurlDouble' transition effect to the slide
            slide5.SlideTransition.TransitionEffect = TransitionEffect.PageCurlDouble;

            // Add the duration value for the transition effect
            slide5.SlideTransition.Duration = 5;
        }

        #endregion

        public override void LayoutSubviews ()
		{
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) {
				frameMargin = 0.0f;
			}
			frameRect = Bounds;
			frameRect.Location = new CGPoint (frameRect.Location.X + frameMargin, frameRect.Location.Y + 1.5f * frameMargin);
			frameRect.Size = new CGSize(frameRect.Size.Width - (frameRect.Location.X + frameMargin), frameRect.Size.Height - (frameRect.Location.Y + 1.5f * frameMargin));

			LoadAllowedTextsLabel ();

			base.LayoutSubviews ();
		}
	}
}
