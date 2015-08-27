using System;
using UIKit;
using Cirrious.FluentLayouts.Touch;

namespace altest
{
	public class FirstViewController : UIViewController
	{
		UIButton modalButton;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.Magenta;

			modalButton = new UIButton ();
			modalButton.TouchUpInside += (sender, e) => 
			{
				NavigationController.PresentViewController(new MyModalViewController(), true, null);
			};

			modalButton.SetTitle ("Nested FirstVC Button", UIControlState.Normal);
			modalButton.BackgroundColor = UIColor.Blue;
			modalButton.SetTitleColor (UIColor.White, UIControlState.Normal);

			View.BackgroundColor = UIColor.Green;

			View.AddSubviews (modalButton);
			View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints ();
			View.AddConstraints
			(
				modalButton.AtTopOf(View).Plus(80),
				modalButton.WithSameCenterX(View),
				modalButton.WithSameWidth(View).Minus(20),
				modalButton.Height().EqualTo(40)
			);
		}

	}
}

