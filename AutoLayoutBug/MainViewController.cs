
using System;

using Foundation;
using UIKit;
using Cirrious.FluentLayouts.Touch;

namespace altest
{
	public partial class MainViewController : UIViewController
	{
		UIButton outerButton;
		UINavigationController navController;

		public MainViewController ()
		{
			outerButton = new UIButton ();
			outerButton.SetTitle ("Outer MainVC Button", UIControlState.Normal);
			outerButton.BackgroundColor = UIColor.Blue;
			outerButton.SetTitleColor (UIColor.White, UIControlState.Normal);
			outerButton.TouchUpInside += (object sender, EventArgs e) => 
			{
				PresentViewController(new MyModalViewController(), true, null);
			};

			navController = new UINavigationController ();
			navController.View.BackgroundColor = UIColor.Brown;
			navController.SetNavigationBarHidden (true, false);
		}
			

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			NavigationItem.Title = "Main";
			EdgesForExtendedLayout = UIRectEdge.None;

			View.AddSubviews (outerButton, navController.View);
			View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints ();
			View.AddConstraints
			(
				outerButton.AtTopOf(View).Plus(10),
				outerButton.WithSameCenterX(View),
				outerButton.WithSameWidth(View).Minus(20),
				outerButton.Height().EqualTo(50),

				navController.View.Below (outerButton).Plus(10),
				navController.View.AtLeftOf (View),
				navController.View.WithSameWidth(View),
				navController.View.WithSameHeight (View)
			); 

			navController.PushViewController (new FirstViewController (), true);
		}
	}
}

