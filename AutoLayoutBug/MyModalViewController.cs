
using System;

using Foundation;
using UIKit;

namespace altest
{
	public partial class MyModalViewController : UIViewController
	{
		UIButton dismmissButton;

		public MyModalViewController ()
		{
			dismmissButton =new UIButton();
			dismmissButton.TouchUpInside += (object sender, EventArgs e) => 
			{
				DismissViewController(true, null);
			};
		}
			

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			View.BackgroundColor = UIColor.Red;

			dismmissButton.SetTitle ("dismmiss", UIControlState.Normal);
			dismmissButton.BackgroundColor = UIColor.Blue;
			dismmissButton.SetTitleColor (UIColor.White, UIControlState.Normal);

			dismmissButton.Frame = new CoreGraphics.CGRect (10, 80, 100, 50);

			View.AddSubview (dismmissButton);
		}
	}
}

